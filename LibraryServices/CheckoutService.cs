using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class CheckoutService : ICheckout
    {
        private LibraryContext context;

        public CheckoutService(LibraryContext libraryContext)
        {
            context = libraryContext;
        }

        public void Add(Checkout newCheckout)
        {
            context.Add(newCheckout);
            context.SaveChanges();
        }

        public void CheckInItem(int assetId)
        {
     

            var item = context.LibraryAssets
                        .FirstOrDefault(a => a.ID == assetId);

            context.Update(item);

            //remove any existing checkouts on the item
            RemoveExistingCheckouts(assetId);

            //close any existing checkout history
            CloseExistingCheckoutHistories(assetId);

            //look for existing holds on the item
            var currentHolds = context.Holds
                                .Include(h => h.LibraryAsset)
                                .Include(h => h.LibraryCard)
                                .Where(h => h.LibraryAsset.ID == assetId);

            //if there are holds, checkout the item to the librarycard with the earliest hold
            if(currentHolds.Any())
            {
                CheckoutToEarliestHold(assetId, currentHolds);
                
            }

            else
            {
                //otherwise, update the item status to available.
                UpdateAssetStatus(assetId, "Available");

                context.SaveChanges();
            }

        }

        private void CheckoutToEarliestHold(int assetId, IQueryable<Hold> currentHolds)
        {
            var earliestHold = currentHolds.OrderBy(holds => holds.HoldPlaced)
                                           .FirstOrDefault();

            var card = earliestHold.LibraryCard;

            context.Remove(earliestHold);
            context.SaveChanges();

            CheckOutItem(assetId, card.Id);
        }

        public bool IsCheckedOut(int assetId)
        {
            var isCheckedOut = context.Checkouts.Where(co => co.LibraryAsset.ID == assetId).Any();

            return isCheckedOut;
        }

        public void CheckOutItem(int assetId, int LibraryCardId)
        {
            if(IsCheckedOut(assetId))
            {
                return;
                //add logic here to handle feedback to the user.
            }

            var item = context.LibraryAssets.FirstOrDefault(a => a.ID == assetId);

            UpdateAssetStatus(assetId, "Checked Out");

            var libraryCard = context.LibraryCards
                              .Include(card => card.Checkouts)
                              .FirstOrDefault(card => card.Id == LibraryCardId);

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = DateTime.Now,
                Until = GetDefaultCheckoutTime(DateTime.Now)
            };

            context.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = DateTime.Now,
                LibraryAsset = item,
                LibraryCard = libraryCard
            };

            context.Add(checkoutHistory);
            context.SaveChanges();
        }

        private DateTime GetDefaultCheckoutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        public IEnumerable<Checkout> GetAll()
        {
            return context.Checkouts;
        }

        public Checkout GetById(int checkoutId)
        {
            return GetAll().FirstOrDefault(checkout => checkout.Id == checkoutId);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return context.CheckoutHistories
                    .Include(h => h.LibraryAsset)
                    .Include(h => h.LibraryCard)
                    .Where(h => h.LibraryAsset.ID == id);
        }

        public string GetCurrentHoldPatronName(int holdId)
        {
            var hold = context.Holds
                       .Include(h => h.LibraryAsset)
                       .Include(h => h.LibraryCard)
                       .FirstOrDefault(h => h.Id == holdId);

            var cardId = hold?.LibraryCard.Id;

            var patron = context.Patrons
                        .Include(p => p.LibraryCard)
                        .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron?.Firstname + " " + patron?.Lastname;
        }

        public DateTime GetCurrentHoldPlaced(int holdId)
        {
            return context.Holds
                       .Include(h => h.LibraryAsset)
                       .Include(h => h.LibraryCard)
                       .FirstOrDefault(h => h.Id == holdId)
                       .HoldPlaced;
        }

        public IEnumerable<Hold> GetCurrentHolds(int id)
        {
            return context.Holds
                    .Include(h => h.LibraryCard)
                    .Where(h => h.LibraryAsset.ID == id);
        }

        public Checkout GetLatestCheckout(int assetId)
        {
            return context.Checkouts.Where(c => c.LibraryAsset.ID == assetId)
                    .OrderByDescending(c => c.Since)
                    .FirstOrDefault();
        }

        public void MarkFound(int assetId)
        {
            UpdateAssetStatus(assetId, "Available");
            RemoveExistingCheckouts(assetId);
            CloseExistingCheckoutHistories(assetId);

            context.SaveChanges();
        }

        private void UpdateAssetStatus(int assetId, string statusName)
        {
            var item = context.LibraryAssets.FirstOrDefault(a => a.ID == assetId);
            context.Update(item);
            item.Status = context.Statuses.FirstOrDefault(status => status.Name == statusName);
        }

        private void CloseExistingCheckoutHistories(int assetId)
        {
            //close any existing checkout history.
            var now = DateTime.Now;
            var history = context.CheckoutHistories.FirstOrDefault(h => h.LibraryAsset.ID == assetId && h.CheckedIn == null);

            if (history != null)
            {
                context.Update(history);
                history.CheckedIn = now;
            }
        }

        private void RemoveExistingCheckouts(int assetId)
        {
            //remove any existing checkouts on the item
            var checkout = context.Checkouts.FirstOrDefault(co => co.LibraryAsset.ID == assetId);

            if (checkout != null)
            {
                context.Remove(checkout);
            }

        }

        public void MarkLost(int assetId)
        {
            UpdateAssetStatus(assetId, "Lost");

            context.SaveChanges();
            
        }

        public void PlaceHold(int assetId, int LibraryCardId)
        {
            var now = DateTime.Now;
            var asset = context.LibraryAssets
                        .Include(a => a.Status)
                        .FirstOrDefault(a => a.ID == assetId);
            var card = context.LibraryCards.FirstOrDefault(c => c.Id == LibraryCardId);

            if(asset.Status.Name == "Available")
            {
                UpdateAssetStatus(assetId, "On Hold");
            }

            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            context.Add(hold);
            context.SaveChanges();
        }

        public string GetCurrentCheckoutPatron(int assetId)
        {
            var checkout = GetCheckoutByAssetId(assetId);

            if(checkout == null)
            {
                return "";
            }

            var cardId = checkout.LibraryCard.Id;

            var patron = context.Patrons
                        .Include(p => p.LibraryCard)
                        .FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron.Firstname + " " + patron.Lastname;
        }

        private Checkout GetCheckoutByAssetId(int assetId)
        {
            return context.Checkouts
                    .Include(c => c.LibraryAsset)
                    .Include(c => c.LibraryCard)
                    .FirstOrDefault(c => c.LibraryAsset.ID == assetId);
        }
    }
}

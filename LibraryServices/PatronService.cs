using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private LibraryContext context;

        public PatronService(LibraryContext _context)
        {
            context = _context;
        }

        public void Add(Patron newPatron)
        {
            context.Add(newPatron);
            context.SaveChanges();
        }

        public Patron Get(int patronid)
        {
            return GetAll()
                   .FirstOrDefault(patron => patron.Id == patronid);
        }

        public IEnumerable<Patron> GetAll()
        {
            return context.Patrons
                   .Include(patron => patron.LibraryCard)
                   .Include(patron => patron.HomeLibraryBranch);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistories(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return context.CheckoutHistories
                            .Include(co => co.LibraryCard)
                            .Include(co => co.LibraryAsset)
                            .Where(co => co.LibraryCard.Id == cardId)
                            .OrderByDescending(co => co.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return context.Checkouts
                    .Include(co => co.LibraryCard)
                    .Include(co => co.LibraryAsset)
                    .Where(co => co.LibraryCard.Id == cardId);
        }

        

        IEnumerable<Hold> IPatron.GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return context.Holds
                    .Include(h => h.LibraryCard)
                    .Include(h => h.LibraryAsset)
                    .Where(h => h.LibraryCard.Id == cardId)
                    .OrderBy(h => h.HoldPlaced);
        }
    }
}

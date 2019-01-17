using LibraryData;
using LibraryManagement.Models.Catalog;
using LibraryManagement.Models.Checkouts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset assets;
        private ICheckout checkouts;

        public CatalogController(ILibraryAsset _assets, ICheckout _checkouts)
        {
            assets = _assets;
            checkouts = _checkouts;
        }

        public IActionResult Index()
        {
            var assetModels = assets.GetAll();

            var listingResult = assetModels
                                .Select(result => new AssetIndexListingModel
                                {
                                    Id = result.ID,
                                    ImageUrl = result.ImageUrl,
                                    AuthorOrDirector = assets.GetAuthorOrDirector(result.ID),
                                    DeweyCallNumber = assets.GetDeweyIndex(result.ID),
                                    Title = result.Title,
                                    Type = assets.GetType(result.ID)

                                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };


            return View(model);
        }

        public IActionResult Detail(int assetId)
        {
            
            var asset = assets.GetById(assetId);

            var currentHolds = checkouts.GetCurrentHolds(assetId)
                               .Select(a => new AssetHoldModel
                               {
                                   DateHoldPlaced = checkouts.GetCurrentHoldPlaced(a.Id).ToString("d"),
                                   PatronName = checkouts.GetCurrentHoldPatronName(a.Id)
                               });

            var model = new AssetDetailModel
            {
                AssetId = assetId,
                Title = asset.Title,
                Type = assets.GetType(assetId),
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = assets.GetAuthorOrDirector(assetId),
                CurrentLocation = assets.GetCurrentLocation(assetId).Name,
                Dewey = assets.GetDeweyIndex(assetId),
                ISBN = assets.GetISBN(assetId),
                CheckoutHistory = checkouts.GetCheckoutHistory(assetId),
                LatestCheckout = checkouts.GetLatestCheckout(assetId),
                PatronName = checkouts.GetCurrentCheckoutPatron(assetId),
                CurrentHolds = currentHolds
            };

            return View(model);
        }

        public IActionResult CheckIn(int assetId)
        {
            checkouts.CheckInItem(assetId);
            return RedirectToAction("Detail", new { assetId = assetId} );
        }

        public IActionResult Checkout(int assetId)
        {
            var asset = assets.GetById(assetId);

            var model = new CheckoutModel
            {
                AssetId = assetId,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = checkouts.IsCheckedOut(assetId)
            };

            return View(model);
        }

        public IActionResult Hold(int assetId)
        {
            var asset = assets.GetById(assetId);

            var model = new CheckoutModel
            {
                AssetId = assetId,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = checkouts.IsCheckedOut(assetId),
                HoldCount = checkouts.GetCurrentHolds(assetId).Count()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int libraryCardId)
        {
            checkouts.CheckOutItem(assetId, libraryCardId);
            return RedirectToAction("Detail", new { assetId = assetId });
        }

        public IActionResult MarkFound(int assetId)
        {
            checkouts.MarkFound(assetId);
            return RedirectToAction("Detail", new { assetId = assetId });
        }

        public IActionResult MarkLost(int assetId)
        {
            checkouts.MarkLost(assetId);
            return RedirectToAction("Detail", new { assetId = assetId });
        }

        [HttpPost]
        public IActionResult PlaceHold(int assetId, int libraryCardId)
        {
            checkouts.PlaceHold(assetId, libraryCardId);
            return RedirectToAction("Detail", new { assetId = assetId });
        }
    }
}

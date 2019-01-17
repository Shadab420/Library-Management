using LibraryData;
using LibraryData.Models;
using LibraryManagement.Models.Patron;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    public class PatronController : Controller
    {
        private IPatron patron;

        public PatronController(IPatron _patron)
        {
            patron = _patron;
        }

        public IActionResult Index()
        {
            var allPatrons = patron.GetAll();
            var patronModels = allPatrons.Select(patron => new PatronDetailModel
            {
                Id = patron.Id,
                FirstName = patron.Firstname,
                LastName = patron.Lastname,
                LibraryCardId = patron.LibraryCard.Id,
                OverDueFees = patron.LibraryCard.Fees,
                HomeLibraryBranch = patron.HomeLibraryBranch.Name
            }).ToList();

            var model = new PatronIndexModel()
            {
                Patrons = patronModels
            };
            return View(model);
        }

        public IActionResult Detail(int patronId)
        {
            var patrn = patron.Get(patronId);

            var model = new PatronDetailModel
            {
                LastName = patrn.Lastname,
                FirstName = patrn.Firstname,
                Address = patrn.Address,
                HomeLibraryBranch = patrn.HomeLibraryBranch.Name,
                MemberSince = patrn.LibraryCard.Created,
                OverDueFees = patrn.LibraryCard.Fees,
                LibraryCardId = patrn.LibraryCard.Id,
                Phone = patrn.Mobile,
                AssetsCheckedOut = patron.GetCheckouts(patronId).ToList() ?? new List<Checkout>(),
                CheckoutHistory = patron.GetCheckoutHistories(patronId).ToList() ?? new List<CheckoutHistory>(),
                Holds = patron.GetHolds(patronId).ToList() ?? new List<Hold>()
            };

            return View(model);
        }
    }
}
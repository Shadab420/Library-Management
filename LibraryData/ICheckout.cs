using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);

        void Add(Checkout newCheckout);
        void CheckInItem(int assetId);
        void CheckOutItem(int assetId, int LibraryCardId);
        void PlaceHold(int assetId, int LibraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);

        bool IsCheckedOut(int assetId);

        string GetCurrentCheckoutPatron(int assetId);  
        string GetCurrentHoldPatronName(int holdId);
        DateTime GetCurrentHoldPlaced(int holdId);
        
    }
}

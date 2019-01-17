using LibraryData.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface IPatron
    {
        Patron Get(int patronid);
        IEnumerable<Patron> GetAll();
        void Add(Patron newPatron);


        IEnumerable<CheckoutHistory> GetCheckoutHistories(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int patronId);
    }
}

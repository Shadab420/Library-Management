using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryBranchService : ILibraryBranch
    {
        private LibraryContext context;

        public LibraryBranchService(LibraryContext _context)
        {
            context = _context;
        }

        public void AddLibraryBranch(LibraryBranch newLibraryBranch)
        {
            context.Add(newLibraryBranch);
            context.SaveChanges();
        }

        public LibraryBranch Get(int branchId)
        {
            return GetAll().FirstOrDefault(b => b.Id == branchId);
        }

        public IEnumerable<LibraryBranch> GetAll()
        {
            return context.LibraryBranches
                   .Include(b => b.Patrons)
                   .Include(b => b.LibraryAssets);
        }          

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return context.LibraryBranches
                   .Include(b => b.LibraryAssets)
                   .FirstOrDefault(b => b.Id == branchId).LibraryAssets;
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {
            var hours = context.BranchHours.Where(b => b.Id == branchId);

            return DataHelpers.HumanizeBusinessHours(hours);
                   
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return context.LibraryBranches
                   .Include(b => b.Patrons)
                   .FirstOrDefault(b => b.Id == branchId).Patrons;
        }

        public bool IsBranchOpen(int branchId)
        {
            var currentTimeHour = DateTime.Now.Hour;
            var currentDayOfWeek = (int)DateTime.Now.DayOfWeek+1;
            var hours = context.BranchHours.Where(h => h.Branch.Id == branchId);

            var daysHours = hours.FirstOrDefault(h => h.DayOfWeek == currentDayOfWeek);

            return currentTimeHour < daysHours.CloseTime && currentTimeHour>= daysHours.OpenTime;
        }
    }
}

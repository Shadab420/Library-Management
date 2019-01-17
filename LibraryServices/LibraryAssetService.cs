using System;
using System.Collections.Generic;
using System.Linq;
using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext context;

        public LibraryAssetService(LibraryContext dbcontext)
        {
            context = dbcontext;
        }

        public void Add(LibraryAsset newAsset)
        {
            context.Add(newAsset);
            context.SaveChanges();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return context.LibraryAssets
                .Include(asset => asset.Status)
                .Include(asset => asset.Location);
        }

        public LibraryAsset GetById(int id)
        {
            return GetAll()
                   .FirstOrDefault(asset => asset.ID == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetDeweyIndex(int id)
        {
            //discriminator column in database
            if (context.Books.Any(book => book.ID == id))
            {
                return context.Books.FirstOrDefault(book => book.ID == id).DeweyIndex;
            }
            else return "";

        }

        public string GetISBN(int id)
        {
            if (context.Books.Any(book => book.ID == id))
            {
                return context.Books.FirstOrDefault(book => book.ID == id).ISBN;
            }
            else return "";
        }

        public string GetTitle(int id)
        {
            return context.LibraryAssets.FirstOrDefault(asset => asset.ID == id).Title;
        }

        public string GetType(int id)
        {
            var book = context.LibraryAssets.OfType<Book>()
                        .Where(b => b.ID == id);

            return book.Any() ? "Book" : "Video";
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = context.LibraryAssets.OfType<Book>()
                        .Where(asset => asset.ID == id).Any();

            var isVideo = context.LibraryAssets.OfType<Video>()
                        .Where(asset => asset.ID == id).Any();

            return isBook ? 
                        context.Books.FirstOrDefault(book => book.ID == id).Author :
                        context.Videos.FirstOrDefault(video => video.ID == id).Director ?? "Unknown";
        }
    }
}

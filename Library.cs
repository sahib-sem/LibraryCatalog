using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    internal class Library
    {

        public string Name { get; set; }
        public string Location { get; set; }

        List<Book> books;
        List<MediaItem> mediaItems;

        public Library(string name, string location ) { 
            books = new List<Book>();
            mediaItems = new List<MediaItem>();
            Name = name;
            Location = location;
        }

        public void AddBook( Book book )
        {
            books.Add( book );
        }

        public void RemoveBook( Book book )
        {
            books.Remove(book);
        }

        public void AddMediaItem( MediaItem mediaItem )
        {
            mediaItems.Add( mediaItem );
        }
        public void removeMediaItem( MediaItem mediaItem )
        {
            mediaItems.Remove( mediaItem );
        }

        public void printCatalog()
        {
            foreach ( Book book in books)
            {
                Console.WriteLine($"Book title: {book.title}\t Author:{book.Author}\t published in {book.PublicationYear}\t ISBN: {book.ISBN} ");

            }

            foreach ( MediaItem mediaItem in mediaItems)
            {
                Console.WriteLine(
                    $"Media title: {mediaItem.title}\t Type: {mediaItem.MediaType}\t duration: {mediaItem.duration.ToString()}"

                    );
            }
        }
    }
}

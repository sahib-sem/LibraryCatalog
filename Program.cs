namespace LibraryCatalog
{
    internal class Program
    {
        static void Main(string[] args)

            //The Alchemist
//Novel by Paulo Coelho

        {
            Library myLibrary = new Library("aau library", "Addis Ababa");
            myLibrary.AddBook(new Book("atomic habits", "IABOA0Q139841", "james clear" , "2020"));
            myLibrary.AddBook(new Book("rich dad poor dad", "QOEUR01324QEWD", "robert kiyosaki", "2018"));
            myLibrary.AddBook(new Book("The Alchemist", "QOEUR01324QEWD", "Paulo Coelho", "1988"));

            myLibrary.AddMediaItem(new MediaItem("popular music", "Audio", new TimeSpan(0, 0, 4, 32)));

            myLibrary.printCatalog();
        }
    }
}
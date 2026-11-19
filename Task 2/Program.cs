using System.Text;
using System;
namespace Task_2    
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    } 
    
    internal class Program
    {
        #region Question 18
        /*
        static void PrintFirstBook(string[] bookList)
        {
            if (bookList.Length == 0)
            {
                return;
            }

            Console.WriteLine(bookList[0]);
        }
        */
        #endregion

        static void Main(string[] args)
        {

            #region Question 1
            /*
            Task 1
            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);  
            */
            #endregion

            // --------------------------------------------------------------------------------------
            #region Question 2
            /*
            Task 2  
            string firstString = "Abra";
            string secondString = "Kadbra";

            Console.WriteLine(ReferenceEquals(firstString, secondString));
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 3

            /*
            Task 3  
            StringBuilder text = new StringBuilder();
            text.Append("Book List");
            text.Append(" - Updated");

            Console.WriteLine(text);
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 4
            /*
            Task 4
            text.Replace("Book List", "Library");

            Console.WriteLine(text);
            */
            #endregion

            // --------------------------------------------------------------------------------------


            #region Question 5
            /*
            Task 5
            string title = "Clean Code";
            int pages = 464;

            string sentence = "Book: " + title + ", Pages: " + pages;
            Console.WriteLine(sentence);
            */

            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 6
            /*
            Task 6
            string sentence = $"Book: {title}, Pages: {pages}";
            Console.WriteLine(sentence); // Output: Book: Clean Code, Pages: 464
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 7
            /*
            Task 7
            string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            Console.WriteLine(sentence);
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 8
            /*
            Task 8
            int pages = 464;

            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 9
            /*
            Task 9
            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 10
            /*
            Task 10
            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 11
            /*
            Task 11
            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 12
            /*
            Task 12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}- {books[i]}.");
            }   
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 13
            /*
            Task 13 
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i = 0;

            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 14
            /*
            Task 14
            int count = 0;

            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } 
            while (count < 3);
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 15
            /*
            Task 15
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 16
            /*
            Task 16
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
                
                if (book == "Refactoring")
                {
                    break; 
                }
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Question 17
            /*    
            Task 17
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
            */
            #endregion

            // --------------------------------------------------------------------------------------

            #region Continue question 18
            /*
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            PrintFirstBook(books);
            */
            #endregion

        }
    }
}
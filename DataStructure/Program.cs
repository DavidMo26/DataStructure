using System;

namespace DataStructure 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******Create books and library*****//
            Book b1 = new Book("Harry Potter", "The boy who lived", "J. K. Rowling", "Fantasy");
            Book b2 = new Book("The Lord of the Rings", "A long-expected party", "J. R. R. Tolkien", "Fantasy");
            Book b4 = new Book("The Da Vinci", "Walkthrough Guide", "Dan Brown", "Thriller");
            MyLibrary library = new MyLibrary();

            //******Add function*****//
            Console.WriteLine("Add funtion : ");           
            Console.WriteLine("Books in library : " + library.Count());
            if (library.AddBook(b1))
                Console.WriteLine("Harry Potter was added to the library");
            Console.WriteLine("Books in library : " + library.Count() + "\n\n");

            //******Remove function*****//
            Console.WriteLine("Remove funtion : ");
            Console.WriteLine("Books in library : " + library.Count());
            if (library.RemoveBook("Harry Potter"))
                Console.WriteLine("Harry Potter was removed from the library");
            Console.WriteLine("Books in library : " + library.Count() + "\n\n");

            //*****HaveThisBook funtion****//
            library.AddBook(b1);
            Console.WriteLine("HaveThisBook funtion : ");
           if(library.HaveThisBook("Harry Potter"))
                Console.WriteLine("Harray Potter in library");          
            if (!library.HaveThisBook("The Lord of the Rings"))
                Console.WriteLine("The Lord of the Rings is not in library" + "\n\n");

            //*****GetBook funtion***//
            Console.WriteLine("GetBook funtion : ");
            Book b3 = b1;
            Console.WriteLine(b3 + "\n\n");

            //**********GetBookByAuthor function*****//
            Console.WriteLine("GetBook funtion : ");
            Console.WriteLine(library.GetBookByAuthor("J. K. Rowling"));

            //******GetAuthors function****//
            Console.WriteLine("\n\nGetAuthors funtion : ");
            library.AddBook(b2);
            List<string> Authors = library.GetAuthors();
            Console.WriteLine(Authors[0] + "\n" + Authors[1] + "\n\n");


            //****GetBooksSortedByAuthorName function***//
            Console.WriteLine("GetBooksSortedByAuthorName funtion : ");
            library.AddBook(b4);
            Authors = library.GetAuthors();
            Console.WriteLine("Before sort : \n" + Authors[0] + "\n" + Authors[1] +"\n"+ Authors[2]);
            List<Book> SortedAuthors = library.GetBooksSortedByAuthorName();
            Console.WriteLine("After sort : \n" + SortedAuthors[0] + "\n" + SortedAuthors[1] + "\n" + SortedAuthors[2] + "\n\n");


            //*****GetBooksTitleSorted function****//
            Console.WriteLine("GetBooksTitleSorted function : ");
            List<string> Titles = library.GetTitles();
            Console.WriteLine("Before sort : \n" + Titles[0] + "\n" + Titles[1] + "\n" + Titles[2]);
            List<Book> SortedTitles = library.GetBooksTitleSorted();
            Console.WriteLine("After sort : \n" + SortedTitles[0] + "\n" + SortedTitles[1] + "\n" + SortedTitles[2] + "\n\n");

            //***Clear function****//
            Console.WriteLine("Clear function : ");
            Console.WriteLine("Before clear : " + library.Count());
            library.Clear();
            Console.WriteLine("After clear : " + library.Count());





        }
    }
}
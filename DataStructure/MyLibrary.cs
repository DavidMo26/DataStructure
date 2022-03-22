using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class MyLibrary
    {
        Dictionary<string,Book> Books { get; set; }

        public MyLibrary()
        {
            Books = new Dictionary<string,Book>();
        }


        public bool AddBook(Book book)
        {
            if (book==null)
                return false;
            return Books.TryAdd(book.Title, book);        }
        public bool RemoveBook(string Key)
        {
            return Books.Remove(Key);
        }
        public bool HaveThisBook(string Key)
        {
            return Books.ContainsKey(Key);
        }
        public Book GetBook(string Key)
        {
            return Books[Key];
        }
        public Book GetBookByAuthor(string Author)
        {
            Dictionary<string ,Book> BooksHelp = new Dictionary<string ,Book>();
            foreach (var item in Books.Values)
                BooksHelp.Add(item.Author, item);
            return BooksHelp[Author];          
        }
        public void Clear()
        {
            Books.Clear();
        }
        public List<string> GetAuthors()
        {
            List<string> Authors = new List<string>();
            foreach (Book item in Books.Values)          
                Authors.Add(item.Author);
            return Authors;           
        }
        public List<Book> GetBooksSortedByAuthorName()
        {
            return Books.Values.OrderBy(book => book.Author).ToList();
        }
        public List<Book> GetBooksTitleSorted()
        {
            return Books.Values.OrderBy(books => books.Title).ToList();
        }
        public int Count()
        {
            return Books.Count;
        }
        public override string ToString()
        {
            string KeyPlusValue = "";
            foreach (KeyValuePair<string,Book> item in Books)            
                KeyPlusValue += "Key : " + item.Key + " " + item.Value;
            return KeyPlusValue;            
        }
        public List<string> GetTitles()
        {
            List<string> Titles = new List<string>();
            foreach (Book item in Books.Values)
                Titles.Add(item.Title);
            return Titles;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Book
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Book(string Title, string Content, string Author, string Category)
        {
            this.Title = Title;
            this.Content = Content;
            this.Author = Author;
            this.Category = Category;
        }
        public override string ToString()
        {
           return JsonSerializer.Serialize(this);
        }

    }
}

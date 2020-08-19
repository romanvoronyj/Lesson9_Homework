using System;

namespace Lesson9_HW_Task4
{
    class BookTitle
    {
        public string bookName { get; set; }
        public void Show()
        {
            Console.WriteLine("'{0}'", this.bookName);
        }
    }
    class Author
    {
        public string bookAuthor { get; set; }
        public void Show()
        {
            Console.WriteLine("{0}", this.bookAuthor);
        }
    }
    class Content
    {
        public string bookContent { get; set; }
        public void Show()
        {
            Console.WriteLine("{0}", this.bookContent);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BookTitle myBook = new BookTitle();
            myBook.bookName = "All Quiet on the Western Front";
            Console.ForegroundColor = ConsoleColor.Green;
            myBook.Show();
            Author thisAuthor = new Author();
            thisAuthor.bookAuthor = "Erikh Maria Remark";
            Console.ForegroundColor = ConsoleColor.Blue;
            thisAuthor.Show();
            Content thisContent = new Content();
            thisContent.bookContent = "The story about First World War";
            Console.ForegroundColor = ConsoleColor.Yellow;
            thisContent.Show();

            Console.ReadKey();

        }
    }
}

    

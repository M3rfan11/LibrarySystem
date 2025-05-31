namespace library
{
    class Book
    {
        public string bookTitle { get; set; }
        public bool isBorrowed { get; set; }

        public Book(string Title)
        {
            bookTitle = Title;
            isBorrowed = false;
        }

        public void Borrow() => isBorrowed = true;

        public void ReturnBook() => isBorrowed = false;

        public void displayBookInfo()
        {
            System.Console.WriteLine($"{bookTitle} - is {(isBorrowed? "Borrowed": "Available")}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace library
{
    class library
    {
        private List<Member> members = new List<Member>();
        private List<Book> books = new List<Book>();
        private int memberCounter = 1;
        public void menu()
        {
            while (true)
            {
                System.Console.WriteLine("\n Library menu:");
                System.Console.WriteLine("1. Add Member");
                System.Console.WriteLine("2. Add Book");
                System.Console.WriteLine("3. Borrow Book");
                System.Console.WriteLine("4. Return Book");
                System.Console.WriteLine("5. View Members");
                System.Console.WriteLine("6. View Books");
                System.Console.WriteLine("7. Exit");
                System.Console.Write("Choose an Option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddMember(); break;
                    case "2": AddBook(); break;
                    case "3": BorrowBook(); break;
                    case "4": ReturnBook(); break;
                    case "5": ViewMembers(); break;
                    case "6": ViewBooks(); break;
                    case "0": return;

                    default: System.Console.WriteLine("You're not good enough with numbers>>> Invalid Option."); break;

                }



            }

        }

        private void AddMember()
        {
            System.Console.Write("Enter the Name of the member: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter the E-mail of the member: ");
            string email = Console.ReadLine();
            members.Add(new Member(memberCounter++, name, email));
            Console.WriteLine("Member registered successfully.....   ");

        }

        private void AddBook()
        {
            System.Console.Write("Enter the Title of the Book: ");
            string Title = Console.ReadLine();

            books.Add(new Book(Title));
            Console.WriteLine("Book Added successfully.....");

        }

        private void BorrowBook()
        {
            Console.Write("Enter your member ID: ");
            int id = int.Parse(Console.ReadLine());

            var member = members.FirstOrDefault(m => m.memberID == id);
            if (member == null)
            {
                System.Console.WriteLine("Member not found x");
                return;
            }
            System.Console.Write("Enter the name of the book: ");
            string bookName = Console.ReadLine();

            var book = books.FirstOrDefault(b => b.bookTitle == bookName && !b.isBorrowed);
            if (book == null)
            {
                System.Console.WriteLine("Book is not available x");
                return;
            }
            book.Borrow();
            System.Console.WriteLine($"{bookName} is borrowed by {member.name}");

        }

        private void ReturnBook()
        {
            System.Console.Write("Enter the name of the book you want to return: ");
            string Title = Console.ReadLine();
            var book = books.FirstOrDefault(b => b.bookTitle == Title && b.isBorrowed);
            if (book == null)
            {
                System.Console.WriteLine("This book is not borrowed x");
                return;

            }
            else
            {
                book.ReturnBook();
                System.Console.WriteLine("Book returned....");
            }

        }

        private void ViewBooks()
        {
            System.Console.WriteLine("Book List: ");
            if (books.Count == 0)
            {
                System.Console.WriteLine("No Books Found x");

            }
        foreach (var book in books)
        {
                book.displayBookInfo();
        }
        }

        private void ViewMembers()
        {
             System.Console.WriteLine("Members List: ");
            if (members.Count == 0)
            {
                System.Console.WriteLine("No Members Registered x");

            }
        foreach (var m in members)
        {
                m.PersonInformation();
        }
        }
    }
}
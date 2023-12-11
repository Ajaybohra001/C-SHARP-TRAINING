using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Remoting.Services;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Connection context = new Connection())
            { bool ch = true;
                do
                {
                    Console.WriteLine("1.Add a Book");
                    Console.WriteLine("2.Add a Author");
                    Console.WriteLine("3.Add a Person");
                    Console.WriteLine("4.Exit");


                    Console.WriteLine("Enter the choice.");
                   string choice=Console.ReadLine();

                    switch(choice)
                    {
                        case "1": 
                            Console.WriteLine("Enter the BookID.");
                            var bkId=int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the Book Name.");
                            var bkName=Console.ReadLine();

                            Console.WriteLine("Enter the Author Name.");
                            var autName=Console.ReadLine(); 

                            var book=new Book() {bookId=bkId,bookName= bkName,authorName=autName};
                            context.Books.Add(book);
                            
                            Console.WriteLine("Book Added");
                            break;

                        case "2":
                            Console.WriteLine("Enter the AuthorID.");
                            var authId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the Author Name.");
                            var authName = Console.ReadLine();

                            Console.WriteLine("Enter the Author Email.");
                            var authEmail = Console.ReadLine();

                            var author = new Author() {authorId=authId,authorName=authName,authorEmail=authEmail };
                            context.Authors.Add(author);

                            Console.WriteLine("Author Added");
                            break;

                        case "3":
                            Console.WriteLine("Enter the PersonID.");
                            var persId = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the Person Name.");
                            var persName = Console.ReadLine();

                            Console.WriteLine("Enter the person phone number.");
                            var persPhn = Console.ReadLine();

                            Console.WriteLine("Enter the Book id.");
                            var perBookId=int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the Date of Issue.");
                            var doi=DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the date of return.");
                            var dor=DateTime.Parse(Console.ReadLine()) ;
                            var person = new Person() { personId=persId,personName=persName,personPhoneNo=persPhn,bookId=perBookId,dateOfIssue=doi,dateOfReturn=dor };
                            context.Persons.Add(person);

                            Console.WriteLine("Author Added");
                            break;

                        case "4":
                            Environment.Exit(0);
                            break;

                        default:Console.WriteLine("Enter the correct option");
                            break;

                        



                    }
                    Console.WriteLine("Do you want to continue (Y/N):");
                    var input=Console.ReadLine();

                    if(input=="N"||input=="n")
                    {
                        ch = false;
                    }




                } while (ch);
                //Book book1 = new Book() { bookId = 1, bookName = "Software Engineering", authorName = "Ajay" };
                //Book book2 = new Book() { bookId = 2, bookName = "AI ML", authorName = "Prince" };
                //context.Books.Add(book1);
                //context.Books.Add(book2);
                //Console.WriteLine("Book Added");


                //var author1 = new Author() { authorId = 101, authorName = "Ajay", authorEmail = "ajaybohra000@gmail.com" };
                //var author2 = new Author() { authorId = 102, authorName = "Prince", authorEmail = "prince@gmail.com" };

                //context.Authors.Add(author1);
                //context.Authors.Add(author2);
                //Console.WriteLine("Author added");

                //var person1 = new Person() { personId = 91, personName = "Utkarsh", personPhoneNo = "8288288812", bookId = 1, dateOfIssue = DateTime.Now, dateOfReturn = DateTime.Parse("05-01-2024") };
                //context.Persons.Add(person1);
                //Console.WriteLine("Person Added");




                context.SaveChanges();
               

                
                Console.ReadKey();
            }
        }
    }
}

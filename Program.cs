using LibraryMenegmentSistyem.Interface;
using LibraryMenegmentSistyem.Models;

namespace LibraryMenegmentSistyem
{
    public class Program
    {
        static void Main(string[] args)
        {

            // indexer ucundu
            //LibraryCatalog.Books();





            Librarian librarian1 = new Librarian()
            {
                Id = 1,
                Name = "Elekber",
            };
            Librarian librarian2 = new Librarian()
            {
                Id = 2,
                Name = "Murad",
            };
            Librarian librarian3 = new Librarian()
            {
                Id = 3,
                Name = "Zamin",
            };
            Librarian librarian4 = new Librarian()
            {
                Id = 4,
                Name = "Ruslan",
            };

            Librarian[] librarians = { librarian1, librarian2, librarian3, librarian4 };

            ILibrarianService librarianService = new LibrarianService(librarians);







            #region GetAllLibrarians
            //Librarian[] LibrarianAll = librarianService.GetAllLibrarians();
            //foreach (var lb in LibrarianAll)
            //{
            //    Console.WriteLine($"Adi:{lb.Name} \nID:{lb.Id}");
            //}

            #endregion

            #region GetLibrarianById
            //Console.WriteLine("Axtarmaq istediyiniz kitabxanacinin ID-sini daxil edin");
            //int searchId = int.Parse(Console.ReadLine());
            //Librarian librarianObj = librarianService.GetLibrarianById(searchId);
            //Console.WriteLine($"Id:{librarianObj.Id} \nAdi:{librarianObj.Name} ");

            #endregion




            #region DeleteLibrarian
            //Console.WriteLine("Silmek istedyiniz elementin ID-sini yazin");
            //int removeID = int.Parse(Console.ReadLine());
            //librarianService.DeleteLibrarian(removeID, false);
            //Librarian[] librarianAll = librarianService.GetAllLibrarians();
            //foreach (var st in librarianAll)
            //{
            //    Console.WriteLine($"Adi:{st.Name} \nSoyadi:{st.Id}");
            //}
            #endregion



            #region CreateLibrarian
            Librarian newLibrarian = new Librarian
            {
                Id = default,
                Name = null,

            };
            Console.Write("Elave etmek istediyin telebenin ID-sini yaz: ");
            newLibrarian.Id = int.Parse(Console.ReadLine());
            Console.Write("Elave etmek istediyin telebenin adini yaz: ");
            newLibrarian.Name = Console.ReadLine();
           
            Console.WriteLine("Yeni telebe elave edildi");
            librarianService.CreateLibrarian(newLibrarian);
            Librarian[] updatedLibrarian = librarianService.GetAllLibrarians();
            foreach (var st in updatedLibrarian)
            {
                Console.WriteLine($"Adi:{st.Name} \nId:{st.Id}");
            }
            #endregion









        }
    }
}
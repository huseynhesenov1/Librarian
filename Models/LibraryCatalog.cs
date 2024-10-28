using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models;

public class LibraryCatalog
{
    public static void Books()
    {
        Libİtem libItem1 = new Libİtem()
        {
            Tittle = "What men Live by ",
            Id = 1
        };
        Libİtem libItem2 = new Libİtem()
        {
            Tittle = "Pride and Prejudice",
            Id = 2
        };
        Libİtem libItem3 = new Libİtem()
        {
            Tittle = "Notes from the underground",
            Id = 3
        };
        Libİtem libItem4 = new Libİtem()
        {
            Tittle = "Crime and Punishment",
            Id = 4
        };
        LibraryItem[] libItems = { libItem1, libItem2, libItem3, libItem4 };
        Console.WriteLine("Enter the ID you want to search for");

        try
        {
            int searchId = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < libItems.Length; i++)
            {
                if (libItems[i].Id == searchId)
                {
                    Console.WriteLine(libItems[i].Tittle);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                throw new Exception("A book with this ID was not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Book is not Found: " + ex.Message);
        }
    }
}
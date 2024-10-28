using LibraryMenegmentSistyem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models;

public class LibrarianService : ILibrarianService
{
    private Librarian[] _librarians;
    public LibrarianService(Librarian[] librarians)
    {
        _librarians = librarians;
    }
    public void CreateLibrarian(Librarian librarian)
    {
        Librarian[] newLibrarian = new Librarian[_librarians.Length + 1];
        for (int i = 0; i < _librarians.Length; i++)
        {
            newLibrarian[i] = _librarians[i];
        }
        newLibrarian[_librarians.Length] = librarian;
        _librarians = newLibrarian;

    }

    public void DeleteLibrarian(int id, bool isSoftDelete)
    {
        var librarian = GetLibrarianById(id);
        if (librarian != null)
        {
            if (isSoftDelete)
            {
                
            }
            else
            {
                int index = Array.IndexOf(_librarians, librarian);
                if (index >= 0)
                {

                    Librarian[] newLibrarians = new Librarian[_librarians.Length - 1];

                    for (int i = 0; i < index; i++)
                    {
                        newLibrarians[i] = _librarians[i];
                    }

                    for (int i = index + 1; i < _librarians.Length; i++)
                    {
                        newLibrarians[i - 1] = _librarians[i];
                    }

                    _librarians = newLibrarians;
                }
            }
        }
        else
        {
            Console.WriteLine($"Student with Id {id} not found.");
        }
    
}

    

    public Librarian[] GetAllLibrarians()
    {

        return _librarians;

    }

    public Librarian GetLibrarianById(int id)     
    {
        for (int i = 0; i < _librarians.Length; i++)
        {
            if (_librarians[i].Id == id)
            {
                return _librarians[i];
            }
        }
        return default;
    }

   
}

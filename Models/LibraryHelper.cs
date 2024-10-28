using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models
{
    public static class LibraryHelper
    {
        public static int CalculateAge(this DateTime PublicationYear)
        {
            int BookAge = 2024 - PublicationYear.Year;
            return BookAge;
        }


        public static string ToTitleCase(this string Tittle)
        {
            string bookName = Tittle.ToLower();
            return bookName;
        }
    }
}

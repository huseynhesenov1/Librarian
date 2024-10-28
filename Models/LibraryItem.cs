using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models
{
    public abstract class LibraryItem
    {
        public string Tittle { get; set; }
        public int Id { get; set; }
        public DateTime? PublicationYear { get; set; }  
        public abstract void DisplayInfo();

         
     }
    public class Libİtem : LibraryItem
    {
        
        public override void DisplayInfo()
        {
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models
{
    internal sealed class LibraryMember:Person
    {
        public DateTime MembershipDate { get; set; }
    }
}

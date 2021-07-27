using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AutoMapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class MemberVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string Township { get; set; }
        public string Road { get; set; }
        public string Section { get; set; }
        public string No { get; set; }
    }
}

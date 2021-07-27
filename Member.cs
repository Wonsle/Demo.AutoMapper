using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AutoMapper
{
    public class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Member()
        {
            this.Name = "Kevin,Lin";
            this.Phone = "0912-456-789";
            this.Address = "台北市,大安區,羅斯福路,四段,1號";
            //10617台北市大安區羅斯福路四段1號
        }
    }
}

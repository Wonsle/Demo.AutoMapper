using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;

namespace Demo.AutoMapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class MemberMapping : Profile
    {
        public MemberMapping()
        {
            CreateMap<Member, MemberVM>();
            CreateMap<MemberVM, Member>();
        }
    }
}

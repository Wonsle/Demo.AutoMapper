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
            var member = new Member();
            var _config = new MapperConfiguration(cfg => cfg.AddProfile<MemberMapping>());
            var _mapper = _config.CreateMapper();
            var memberVM = _mapper.Map<MemberVM>(member);
            var member2 = _mapper.Map<Member>(memberVM);
        }
    }

    public class MemberMapping : Profile
    {
        public MemberMapping()
        {
            CreateMap<Member, MemberVM>()
                .ForMember(x => x.FirstName, y => y.MapFrom(o => o.Name.Split(',')[0]))
                .ForMember(x => x.LastName, y => y.MapFrom(o => o.Name.Split(',')[1]))
                .ForMember(x => x.Country, y => y.MapFrom(o => o.Address.Split(',')[0]))
                .ForMember(x => x.Township, y => y.MapFrom(o => o.Address.Split(',')[1]))
                 .ForMember(x => x.Road, y => y.MapFrom(o => o.Address.Split(',')[2]))
                 .ForMember(x => x.Section, y => y.MapFrom(o => o.Address.Split(',')[3]))
                 .ForMember(x => x.No, y => y.MapFrom(o => o.Address.Split(',')[4]));
            CreateMap<MemberVM, Member>()
                .ForMember(x => x.Name, y => y.MapFrom(o => $"{o.FirstName},{o.LastName}"))
                .ForMember(x => x.Address
                , y => y.MapFrom(o => $"{o.Country},{o.Township},{o.Road},{o.Section},{o.No}"));
        }
    }
}

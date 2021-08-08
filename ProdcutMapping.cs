using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Demo.AutoMapper
{
    public class ProdcutMapping : Profile
    {
        public ProdcutMapping()
        {
            CreateMap<ProductInfo, ProductSimpleInfo>();
            CreateMap<ProductSimpleInfo, ProductInfo>();
        }
    }
}

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
            ProductInfoDemo();
        }

        private static void MemberDemo()
        {
            //建立MapperConfig
            var _config = new MapperConfiguration(cfg => cfg.AddProfile<MemberMapping>());
            //建立Mapper
            var _mapper = _config.CreateMapper();

            var member = new Member();
            var memberVM = _mapper.Map<MemberVM>(member); // 將Member轉型成MemberVM
            var member2 = _mapper.Map<Member>(memberVM);  // 將MemberVM轉型成Member
        }

        private static void ProductInfoDemo()
        {
            //建立MapperConfig
            var _config = new MapperConfiguration(cfg => cfg.AddProfile<ProdcutMapping>());
            //建立Mapper
            var _mapper = _config.CreateMapper();

            var product = new ProductInfo().GetProduct();

            ProductSimpleInfo productSimpleInfo = _mapper.Map<ProductSimpleInfo>(product);
            ProductInfo product1 = _mapper.Map<ProductInfo>(productSimpleInfo);

            var products = new ProductInfo().GetProducts();
            List<ProductSimpleInfo> productSimpleInfos = _mapper.Map<List<ProductSimpleInfo>>(products);
            List<ProductInfo> productInfos = _mapper.Map<List<ProductInfo>>(productSimpleInfos);
        }
    }
}

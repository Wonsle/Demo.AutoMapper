using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AutoMapper
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Specification { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int WarrantyDay { get; set; }
        public string Instruction { get; set; }

        public ProductInfo GetProduct()
        {
            return new ProductInfo
            {
                Id = 1,
                ProductName = "UDM-Pro",
                Specification = @"(8) 10/100/1000 RJ45 LAN Ports
(1) 10/100/1000 RJ45 WAN Port
(1) 1/10G SFP+ LAN Port
(1) 1/10G SFP+ WAN Port",
                Price = 11999M,
                ReleaseDate = new DateTime(2019, 7, 1),
                WarrantyDay = 365,
                Instruction = "The Dream Machine Pro (UDM Pro) is an enterprise-grade UniFi OS Console that offers a scalable networking experience and comprehensive platform for multi-application use."
            };
        }

        public List<ProductInfo> GetProducts()
        {
            var infos = new List<ProductInfo>();
            infos.Add(new ProductInfo
            {
                Id = 1,
                ProductName = "UDM-Pro",
                Specification = @"(4) LAN 10/100/1000 RJ45 Ports
(1) WAN 10 / 100 / 1000 RJ45 Port",
                Price = 11999M,
                ReleaseDate = new DateTime(2019, 7, 1),
                WarrantyDay = 365,
                Instruction = "The Dream Machine Pro (UDM Pro) is an enterprise-grade UniFi OS Console that offers a scalable networking experience and comprehensive platform for multi-application use."
            });
            infos.Add(new ProductInfo
            {
                Id = 1,
                ProductName = "UDM",
                Specification = "",
                Price = 9999M,
                ReleaseDate = new DateTime(2019, 7, 1),
                WarrantyDay = 365,
                Instruction = "The Dream Machine (UDM) is an easy-to-use UniFi OS console with a built-in, high-performance WiFi access point"
            });

            return infos;
        }
    }
}

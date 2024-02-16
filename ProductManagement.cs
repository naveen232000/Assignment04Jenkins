using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04Jenkins
{
    public class ProductManagement
    {
        List<Products> products=new List<Products>() { 
        new Products(){PId=1,PName="Scale",PPrice=10.00,PBrand="Nataraj",ManufacturingDate=new DateTime(day:23,month:12,year:2023) },
        new Products(){PId=2,PName="Fevi Stik",PPrice=35.00,PBrand="Pidilite",ManufacturingDate=new DateTime(day:20,month:11,year:2024),ExpDate=new DateTime(day:25,month:10,year:2025) },
        new Products(){PId=3,PName="Link pen 7.0",PPrice=10.00,PBrand="LINK",ManufacturingDate=new DateTime(day:23,month:12,year:2023),ExpDate=new DateTime(day:23,month:12,year:2024) },
        new Products(){PId=4,PName="Correction Tape",PPrice=20.00,PBrand="Tombow",ManufacturingDate=new DateTime(day:30,month:07,year:2023),ExpDate=new DateTime(day:30,month:07,year:2025) },
        new Products(){PId=1,PName="Highlighters",PPrice=50.00,PBrand="Sharpie",ManufacturingDate=new DateTime(day:23,month:12,year:2023),ExpDate=new DateTime(day:23,month:12,year:2024) },
        };

        public void AllProducts() 
        {
            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.PId,10}{prod.PName,10}{prod.PPrice,10}{prod.PBrand,10}{prod.ManufacturingDate,10}{prod.ExpDate,10}");
            }
        }
    }
}

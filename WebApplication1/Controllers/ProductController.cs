using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> cf = new List<Product>()
        {
            new Product()
            {
                Id=1,
                Image="~/img/hinh-anh-cafe-dep-ly-cafe-ca-phe-sua-da-ca-phe-den-6.jpeg",
                Name="Cà phê sữa",
                Price = 12000,
                Categories = 0,
            },
            new Product()
            {
                Id=2,
                Image="~/img/hinh-anh-cafe-dep-ly-cafe-ca-phe-sua-da-ca-phe-den-7.png",
                Name="Cà phê đen",
                Price = 10000,
                Categories=0
            },
            new Product()
            {
                Id=3,
                Image="~/img/windows-cafe-568082.jpg",
                Name="Cà Phê Muối",
                Price = 20000,
                Categories=0
            },
            new Product()
            {
                Id=4,
                Image="~/img/tải xuống.jpg",
                Name="Nước Ép Cam",
                Price = 35000,
                Categories=1
            },
            new Product()
            {
                Id=5,
                Image="~/img/tải xuống (1).jpg",
                Name="Nước Ép Cà Rốt",
                Price = 35000,
                Categories=1
            },
            new Product()
            {
                Id=6,
                Image="~/img/images (1).jpg",
                Name="Nước Ép Dứa",
                Price = 35000,
                Categories=1
            },
            new Product()
            {
                Id=7,
                Image="~/img/images.jpg",
                Name="Chanh Dây Lọc Hạt",
                Price = 35000,
                Categories=1
            },
            new Product()
            {
                Id=8,
                Image="~/img/cach-lam-banh-bong-lan-trung-muoi-bang-noi-com-dien6.jpg",
                Name="Bông Lan Trứng Muối",
                Price = 80000,
                Categories=2
            },
            new Product()
            {
                Id=9,
                Image="~/img/istockphoto-185259224-612x612.jpg",
                Name="Bánh Socola",
                Price = 50000,
                Categories=2
            },
            new Product()
            {
                Id=10,
                Image="~/img/kem-chuoi-dau-tay-1.jpg",
                Name="Bánh Vị MatCha",
                Price = 50000,
                Categories=2
            },
            new Product()
            {
                Id=11,
                Image="~/img/1200-1200x676-33.jpg",
                Name="Bánh Su Kem",
                Price = 40000,
                Categories=2
            },
            new Product()
            {
                Id=12,
                Image="~/img/bluebery.jpg",
                Name="Sinh Tố Việt Quất",
                Price = 35000,
                Categories=3
            },
            new Product()
            {
                Id=12,
                Image="~/img/strawbery.jpg",
                Name="Sinh Tố Dâu Tây",
                Price = 35000,
                Categories=3
            },
            new Product()
            {
                Id=13,
                Image="~/img/Bơ.png",
                Name="Sinh Tố Bơ",
                Price = 35000,
                Categories=3
            },
            new Product()
            {
                Id=14,
                Image="~/img/xoài.png",
                Name="Sinh Tố Xoài",
                Price = 35000,
                Categories=3
            }
        };
        [HttpGet]
        public IActionResult Index(int cate)
        {
            List<Product> list = new List<Product>();
            foreach (var p in cf)
            {
                if(p.Categories==cate)
                {
                    list.Add(p);
                }
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            //linQ
            var result = cf.Where(c => c.Id == id).FirstOrDefault<Product>();
            var c = new ProductViewModel()
            {
                Id = result.Id,
                Image = result.Image,
                Name = result.Name,
                Price = result.Price
            };
            return View(c);
        }
        public IActionResult Insert(ProductViewModel model)
        {
            var c = new Product()
            {
                Id = cf.Count + 1,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Categories = 0
            };
            cf.Add(c);  
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Update(ProductViewModel model)
        {
            var cof = new Product()
            {
                Id = model.Id,
                Image = model.Image,
                Name = model.Name,
                Price = model.Price,
                Categories = 0
            };
            for(int i = 0; i < cf.Count; i++)
            {
                if (cf[i].Id == model.Id)   
                    cf[i] = cof;
            }
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Delete(int id)
        {
            var c = cf.Where(c => c.Id == id).FirstOrDefault<Product>();
            cf.Remove(c);
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Check(int id)
        {
            List<Product> list = new List<Product>();
            Product cof = new Product();
            for(int i=0;i<cf.Count;i++)
            {
                if(cf[i].Id==id)
                {
                    cof = cf[i];
                    list.Add(cof);
                }
            }
           
            return View(list);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Coffee()
        {
            List<Coffee> list = new List<Coffee>();
            int id = 1;
            string img = "~/img/hinh-anh-cafe-dep-ly-cafe-ca-phe-sua-da-ca-phe-den-6.jpeg";
            string name = "Cà phê sữa";
            int price = 12000;
            Coffee cf = new Coffee(id, img,name, price);
            list.Add(cf);
            int id2 = 2;
            string img2 = "~/img/hinh-anh-cafe-dep-ly-cafe-ca-phe-sua-da-ca-phe-den-7.png";
            string name2 = "Cà phê đen";
            int price2 = 10000;
            Coffee cf2 = new Coffee(id2, img2,name2, price2);
            list.Add(cf2);
            int id3 = 3;
            string img3 = "~/img/windows-cafe-568082.jpg";
            string name3 = "Cà Phê Muối";
            int price3 = 20000;
            Coffee cf3 = new Coffee(id3, img3, name3, price3);
            list.Add(cf3);
            return View(list);
        }

        public IActionResult Cake()
        {
            List<Cake> List = new List<Cake>();
            int[] id =new int[] { 1, 2, 3, 4 };
            string[] img = new string[] { "~/img/istockphoto-185259224-612x612.jpg", "~/img/1200-1200x676-33.jpg", "~/img/cach-lam-banh-bong-lan-trung-muoi-bang-noi-com-dien6.jpg", "~/img/kem-chuoi-dau-tay-1.jpg" };
            string[] name = new string[] { "Bánh socola", "Bánh Su Kem", "Bánh Bông Lan Trứng Muối", "Bánh Vị MatCha" };
            int[] price = new int[] {40000,20000,80000,65000};
            for(var i=0;i<4;i++)
            {
                Cake ck = new Cake(id[i], img[i], name[i], price[i]);
                List.Add(ck);
            }    
            return View(List);
        }
        public IActionResult Juice() 
        {
            List<Juice> List = new List<Juice>();
            int[] id = new int[] { 1, 2, 3, 4 };
            string[] img = new string[] { "~/img/tải xuống (1).jpg", "~/img/tải xuống.jpg", "~/img/images (1).jpg", "~/img/images.jpg" };
            string[] name = new string[] { "Nước Ép Cà Rốt", "Nước ép Cam", "Nước ép Dứa", "Chanh Dây Lọc Hạt" };
            int[] price = new int[] { 35000, 40000, 30000, 30000 };
            for (var i = 0; i < 4; i++)
            {
                Juice jc = new Juice(id[i], img[i], name[i], price[i]);
                List.Add(jc);
            }
            return View(List);
        } 
        public IActionResult Smoothies()
        {
            List<Smoothie> List = new List<Smoothie>();
            int[] id = new int[] { 1, 2, 3, 4 };
            string[] img = new string[] { "~/img/bluebery.jpg", "~/img/strawbery.jpg", "~/img/Bơ.png", "~/img/xoài.png" };
            string[] name = new string[] { "Sinh tố Việt Quất", "Sinh Tố Dâu", "Sinh Tố Bơ", "Sinh Tố Xoài" };
            int[] price = new int[] { 35000, 40000, 30000, 30000 };
            for (var i = 0; i < 4; i++)
            {
                Smoothie sm= new Smoothie(id[i], img[i], name[i], price[i]);
                List.Add(sm);
            }
            return View(List);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

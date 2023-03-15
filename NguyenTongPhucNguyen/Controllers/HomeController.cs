using NguyenTongPhucNguyen.Context;
using NguyenTongPhucNguyen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenTongPhucNguyen.Controllers
{
    public class HomeController : Controller
    
    {
        WebBanHangEntities BanHang = new WebBanHangEntities();
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();
            model.ListCategories = BanHang.Category.ToList();
            model.ListBrands = BanHang.Brand.ToList();
            model.ListUsers = BanHang.User.ToList();
            model.ListProducts = BanHang.Product.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
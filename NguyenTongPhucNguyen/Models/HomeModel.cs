using NguyenTongPhucNguyen.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenTongPhucNguyen.Models
{
    public class HomeModel
    {
        public List<Category> ListCategories { get; set; }
        public List<Product> ListProducts { get; set; }
        public List<User> ListUsers { get; set; }
        public List<Brand> ListBrands { get; set; }
    }
}
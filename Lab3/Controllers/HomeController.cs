using Lab3.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //RoleManager<IdentityRole> roleManager =
            //        new RoleManager<IdentityRole>(
            //            new RoleStore<IdentityRole>(
            //                new ApplicationDbContext()));

            //roleManager.Create(new IdentityRole { Name = "Admin" });
            //roleManager.Create(new IdentityRole { Name = "Client" });

            //ApplicationUserManager userManager = new ApplicationUserManager(
            //    new UserStore<ApplicationUser>(
            //        new ApplicationDbContext()));

            //ApplicationUser admin = userManager.FindByEmail("admin@gmail.com");
            //ApplicationUser client = userManager.FindByEmail("client@gmail.com");

            //userManager.AddToRole(admin.Id, "Admin");
            //userManager.AddToRole(client.Id, "Client");

            return View();
        }
    }
}

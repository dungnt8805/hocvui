using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SocialWebApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Register",
                "dang-ki",
                new { controller = "Auth", action = "Create" }
                );
            routes.MapRoute(
                "Login",
                "dang-nhap",
                new { controller = "Auth", action = "Login" }
                );
            routes.MapRoute(
                "ForgotPassword",
                "quen-mat-khau",
                new { controller = "Auth", action = "ForgotPassword" }
                );
            routes.MapRoute(
                "ActiveAccount",
                "kich-hoat-tai-khoan",
                new { controller = "Auth", action = "Active" }
                );
            routes.MapRoute(
                "ForgotPasswordConfirm",
                "tao-mat-khau",
                new { controller = "Auth", action = "ForgotPasswordConfirm" }
                );
            routes.MapRoute(
                "Account",
                "tai-khoan",
                new { controller = "Account", action = "Index" }
                );
            routes.MapRoute(
                "ChangePassword",
                "doi-mat-khau.html",
                new { controller = "Account", action = "ChangePassword" }
                );
            routes.MapRoute(
                "Categories",
                "{categoryName}-p{categoryId}.html",
                new { controller = "Categories", action = "Details" },
                new { categoryName = @"^.+$", categoryId = @"\d+" },
                new[] { "SocialWebApp.Controllers" }
                );
            routes.MapRoute(
                "subCategorires",
                "{categoryName}-c{categoryId}.html",
                new { controller = "Categories", action = "SubDetails" },
                new { categoryName = @"^.+$", categoryId = @"\d+" },
                new[] { "SocialWebApp.Controllers" }
                );
            routes.MapRoute(
                "Entries",
                "{entryName}-entry{entryId}.html",
                new { controller = "Entries", action = "Details" },
                new { entryName = @"^.+$", entryId = @"\d+" },
                new[] { "SocialWebApp.Controllers" }
                );
            routes.MapRoute(
                "UserDetails",
                "{userName}-u{userId}.html",
                new { controller = "Users", action = "Details" },
                new { userName = @"^.+$", userId = @"\d+" },
                new[] { "SocialWebApp.Controllers" }
                );
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );



        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
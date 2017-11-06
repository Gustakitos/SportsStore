using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Infrastructure.Binders;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI{
    public class MvcApplication : System.Web.HttpApplication{
        protected void Application_Start(){
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());

            EFDbContext db = new EFDbContext();
            db.Database.CreateIfNotExists();

            Database.SetInitializer(new DropCreateDatabaseAlways<EFDbContext>());

        }
    }
}

using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.Areas.Order
{
    public class OrderAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Order";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "Order_Area_Detail",
                url: "OrderDetail/{id}",
                defaults: new { area = "Order", controller = "Default", action = "Detail", id = UrlParameter.Optional },
                constraints: new { area = "Order", controller = "Default", action = "Detail" }
            );

            context.MapRoute(
                name: "Order_Area_List",
                url: "Order/List/{page}",
                defaults: new { area = "Order", controller = "Default", action = "List", page = UrlParameter.Optional },
                constraints: new { area = "Order", controller = "Default" }
            );

            context.MapRoute(
                "Order_default",
                "Order/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
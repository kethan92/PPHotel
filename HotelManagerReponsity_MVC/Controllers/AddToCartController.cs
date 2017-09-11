using HotelManagerReponsity_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagerReponsity_MVC.Controllers
{
    public class AddToCartController : Controller
    {
        // GET: AddToCart
        public ActionResult Add(RoomOfStatusAndType roo)
        {
            if (Session["cart"] == null)
            {
                List<RoomOfStatusAndType> li = new List<RoomOfStatusAndType>();

                li.Add(roo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();


                Session["count"] = 1;


            }
            else
            {
               
                List<RoomOfStatusAndType> li = (List<RoomOfStatusAndType>)Session["cart"];
                foreach (var item in li)
                {
                    if(item.RoomNumber==roo.RoomNumber)
                    {
                        ViewBag.Javascript = "<script language='javascript' type='text/javascript'>alert('Data Already Exists');</script>";
                        return RedirectToAction("Index", "Home");
                    }
                }
                li.Add(roo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Index", "Home");
            
        }
        [HttpGet]
        public ActionResult Myorder()
        {
            ViewBag.getRooms = (List<RoomOfStatusAndType>)Session["cart"];

            return View();

        }
        [HttpGet]
        public ActionResult Remove(RoomOfStatusAndType roo)
        { 
            List<RoomOfStatusAndType> li = (List<RoomOfStatusAndType>)Session["cart"];
            li.RemoveAll(x => x.RoomNumber == roo.RoomNumber);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("Myorder", "AddToCart");

        }
    }
}
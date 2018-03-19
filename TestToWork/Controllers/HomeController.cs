using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestToWork.BLL.DTO;
using TestToWork.BLL.Interfaces;
using TestToWork.Models;

namespace TestToWork.Controllers
{
    public class HomeController : Controller
    {
        IServices service;

        public HomeController(IServices serv)
        {
            service = serv;
        }
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult GetShops()
        {
            var shopsDTO = service.GetShops();
            var shopsVM = Mapper.Map<IEnumerable<ShopAllInfDTO>, List<ShopAllInfViewModel>>(shopsDTO);
            return PartialView(shopsVM);
        }
        public ActionResult GetProducts(int? id)
        {
            try
            {
                var productsDTO = service.GetProducts(id);
                var productsVM = Mapper.Map<IEnumerable<ProductsDTO>, List<ProductsViewModel>>(productsDTO);
                return PartialView(productsVM);
            }
            catch
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Input error!');</script>");
            }
            
        }

    }
}
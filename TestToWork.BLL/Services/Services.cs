using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToWork.BLL.DTO;
using TestToWork.BLL.Interfaces;
using TestToWork.DAL;
using TestToWork.DAL.Interfaces;

namespace TestToWork.BLL.Services
{
    public class Services : IServices
    {
        IUnitOfWork UnitOfWork { get; set; }
        public Services(IUnitOfWork uow)
        {
            UnitOfWork = uow;
        }
        public IEnumerable<ShopAllInfDTO> GetShops()
        {
            List<ShopAllInfDTO> shopsList = new List<ShopAllInfDTO>();
            
            
            var test = UnitOfWork.ShopsUOW.GetAll();
            foreach(var a in test)
            {
                ShopAllInfDTO shop = new ShopAllInfDTO();
                shop.DaysOfWeek = new Dictionary<string, string[]>();
                shop.ShopsId = a.ShopsId;
                shop.Name = a.Name;
                shop.Address = a.Address;
                shop.DaysOfWeek.Add("Monday", new string[] { a.ModeOfOperation1.BeginAndEndWork.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Tuesday", new string[] { a.ModeOfOperation1.BeginAndEndWork1.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork1.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Wednesday", new string[] { a.ModeOfOperation1.BeginAndEndWork2.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork2.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Thursday", new string[] { a.ModeOfOperation1.BeginAndEndWork3.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork3.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Friday", new string[] { a.ModeOfOperation1.BeginAndEndWork4.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork4.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Saturday", new string[] { a.ModeOfOperation1.BeginAndEndWork5.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork5.Times1.Time.ToString() });
                shop.DaysOfWeek.Add("Sunday", new string[] { a.ModeOfOperation1.BeginAndEndWork6.Times.Time.ToString(), a.ModeOfOperation1.BeginAndEndWork6.Times1.Time.ToString() });
                shopsList.Add(shop);

            }
            return shopsList;
        }

        public IEnumerable<ProductsDTO> GetProducts(int? id)
        {
            if(id != null)
            {
                int idNotNull = (int)id;
                var productsList = UnitOfWork.ShopsUOW.Get(idNotNull).Products;
                var allLang = Mapper.Map<IEnumerable<Products>, List<ProductsDTO>>(productsList);
                return allLang;
            }
            return null;
        }
    }
}

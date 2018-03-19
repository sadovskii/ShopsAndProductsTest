using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToWork.BLL.DTO;

namespace TestToWork.BLL.Interfaces
{
    public interface IServices
    {
        IEnumerable<ShopAllInfDTO> GetShops();
        IEnumerable<ProductsDTO> GetProducts(int? id);

    }
}

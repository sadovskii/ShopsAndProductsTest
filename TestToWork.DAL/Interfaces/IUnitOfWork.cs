using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToWork.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<BeginAndEndWork> BeginAndEndWorkUOW { get; }
        IGenericRepository<ModeOfOperation> ModeOfOperationUOW { get; }
        IGenericRepository<Products> ProductsUOW { get; }
        IGenericRepository<Shops> ShopsUOW { get; }
        IGenericRepository<Times> TimesUOW { get; }
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestToWork.DAL.Interfaces;

namespace TestToWork.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ShopsAndProductsContext db = new ShopsAndProductsContext();
        private EFGenericRepository<BeginAndEndWork> beginAndEndWorkRepository;
        private EFGenericRepository<ModeOfOperation> modeOfOperationRepository;
        private EFGenericRepository<Products> productsRepository;
        private EFGenericRepository<Shops> shopsRepository;
        private EFGenericRepository<Times> timesRepository;
        public void Save()
        {
            db.SaveChanges();
        }
        public IGenericRepository<BeginAndEndWork> BeginAndEndWorkUOW
        {
            get
            {
                if (beginAndEndWorkRepository == null)
                    beginAndEndWorkRepository = new EFGenericRepository<BeginAndEndWork>(db);
                return beginAndEndWorkRepository;
            }
        }
        public IGenericRepository<ModeOfOperation> ModeOfOperationUOW
        {
            get
            {
                if (modeOfOperationRepository == null)
                    modeOfOperationRepository = new EFGenericRepository<ModeOfOperation>(db);
                return modeOfOperationRepository;
            }
        }
        public IGenericRepository<Products> ProductsUOW
        {
            get
            {
                if (productsRepository == null)
                    productsRepository = new EFGenericRepository<Products>(db);
                return productsRepository;
            }
        }
        public IGenericRepository<Shops> ShopsUOW
        {
            get
            {
                if (shopsRepository == null)
                    shopsRepository = new EFGenericRepository<Shops>(db);
                return shopsRepository;
            }
        }
        public IGenericRepository<Times> TimesUOW
        {
            get
            {
                if (timesRepository == null)
                    timesRepository = new EFGenericRepository<Times>(db);
                return timesRepository;
            }
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

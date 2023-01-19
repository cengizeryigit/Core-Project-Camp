using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;

		public WriterManager(IWriterDal writerdal)
		{
			_writerdal = writerdal;
		}

        public void AddT(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void DeleteT(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterByID(int id)
        {
            return _writerdal.GetListAll(x=>x.WriterID== id);
        }

        public Writer TGetByID(int id)
        {
            return _writerdal.GetByID(id);
        }

        public void UpdateT(Writer t)
        {
            _writerdal.Update(t);
        }
    }
}

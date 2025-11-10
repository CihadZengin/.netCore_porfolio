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
    public  class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _WriterUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _WriterUserDal = writerUserDal;
        }

        public WriterUser GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _WriterUserDal.GetList();
        }

        public List<WriterUser> TGetListbyFliter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}

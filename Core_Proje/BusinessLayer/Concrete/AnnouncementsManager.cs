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
    public class AnnouncementsManager : IAnnouncementService
    {
        IAnnouncementDal _AnnouncementDal;

        public AnnouncementsManager(IAnnouncementDal announcementDal)
        {
            _AnnouncementDal = announcementDal;
        }

        public Announcement GetByID(int id)
        {
            return _AnnouncementDal.GetByID(id);
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetList()
        {
            return _AnnouncementDal.GetList();
        }

        public List<Announcement> TGetListbyFliter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}

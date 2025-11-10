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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDall;

        public SkillManager(ISkillDal skillDall)
        {
            _skillDall = skillDall;
        }

        public Skill GetByID(int id)
        {
            return _skillDall.GetByID(id); 
        }

        public void TAdd(Skill t)
        {
            _skillDall.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDall.Delete(t);
        }

        public List<Skill> TGetList()
        {
            return _skillDall.GetList();
        }

        public List<Skill> TGetListbyFliter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
           _skillDall.Update(t);
        }
    }
}

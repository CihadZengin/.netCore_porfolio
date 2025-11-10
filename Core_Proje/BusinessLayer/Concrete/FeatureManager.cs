using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featuredal;

        public FeatureManager(IFeatureDal featuredal)
        {
            _featuredal = featuredal;
        }

        public Feature GetByID(int id)
        {
            return _featuredal.GetByID(id);
        
        }

        public void TAdd(Feature t)
        {
            _featuredal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featuredal.Delete(t);
        }

        public List<Feature> TGetList()
        {
            return _featuredal.GetList();
        }

        public List<Feature> TGetListbyFliter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            _featuredal.Update(t);
        }
    }
}

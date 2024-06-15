using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManeger : IColorService
    {
        IColorDal _colorDal;

        public ColorManeger(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();  
        }

        public Color GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}


using Core.Utulities_Araçlar_.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        
         IDataResult<List<Car>> GetAll();

         IDataResult<List<Car>> GetCarsByBrandId(int id);

       IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        //1-ilk yazdığımız
        //void AddCar(Car car);

        //2-ikinci yazdığımız
        IResult AddCar(Car car);

         
    }
}

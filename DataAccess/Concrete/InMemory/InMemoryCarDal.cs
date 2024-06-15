using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        List<Brand> _brands;

        List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {new Car{ Id=1,BrandId=1 ,ColorId=1,Model="Renault Megane",ModelYear="2015",DailyPrice=1500,Description="günlük 1500 tl"},
             new Car{ Id=2,BrandId=2,ColorId=1,Model="Fiat Egea", ModelYear="2017",DailyPrice=2000,Description="günlük:2000tl"},
             new Car{ Id=3,BrandId=3,ColorId=2,Model="Hyundai İ30", ModelYear="2018",DailyPrice=2500,Description="günlük 2500tl"},
             new Car{ Id=4,BrandId=1,ColorId=2,Model="Renault Clio", ModelYear="2019",DailyPrice=2500,Description="günlük 2500tl"},
             new Car{ Id=5,BrandId=3,ColorId=3,Model="Hyundai İ20", ModelYear="2016",DailyPrice=1500,Description="günlük 1500tl"},
             new Car{ Id=6,BrandId=4,ColorId=3,Model="Ford mondeo", ModelYear="2021",DailyPrice=3500,Description="günlük 3500tl"},
             new Car{ Id=7,BrandId=1 ,ColorId=1,Model="Renault sembol",ModelYear="2015",DailyPrice=1500,Description="günlük 1500 tl"},
             new Car{ Id=8,BrandId=2,ColorId=1,Model="Fiat doblo", ModelYear="2017",DailyPrice=2000,Description="günlük:2000tl"},
             new Car{ Id=9,BrandId=3,ColorId=2,Model="Hyundai İ10", ModelYear="2018",DailyPrice=2500,Description="günlük 2500tl"},
             new Car{ Id=10,BrandId=1,ColorId=2,Model="Renault Clio", ModelYear="2019",DailyPrice=2500,Description="günlük 2500tl"},
             new Car{ Id=11,BrandId=3,ColorId=3,Model="Hyundai İ20", ModelYear="2020",DailyPrice=1500,Description="günlük 1500tl"},
             new Car{ Id=12,BrandId=4,ColorId=3,Model="Ford focus", ModelYear="2021",DailyPrice=3500,Description="günlük 3500tl"},
            };

            //********************************************************************

            _brands = new List<Brand>
            {
                new Brand{ BrandId=1,BrandName="Renault"},
                new Brand{ BrandId=2,BrandName="Fiat"},
                new Brand{ BrandId=3,BrandName="Hyundai"},
                new Brand{ BrandId=4,BrandName="Ford"},
            };

            _colors = new List<Color>
            {
                new Color { ColorId=1,ColorName="beyaz"},
                new Color { ColorId=2,ColorName="siyah"},
                new Color { ColorId=3,ColorName="füme"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = null;
            //foreach (var c in _cars)
            //{
            //    if(c.Id == car.Id)
            //    {
            //        deleteCar = c;
            //    }
            //}
            //_cars.Remove(deleteCar);
           
            deleteCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteCar);
            CarList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            updateToCar.Id = car.Id;
            updateToCar.Model = car.Model;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.Description = car.Description;
            CarList();
        }
        public void CarList()
        {
            foreach (var c in _cars)
            {
                Console.WriteLine(c.Id + " " + c.Model + " " + c.ModelYear+" "+c.Description);
            }
        }

        public List<Car> GetAllByCategoryId(int brandId)
        {
           return  _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}

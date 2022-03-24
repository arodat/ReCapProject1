using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Color> _colors;
        private List<Brand> _brands;

        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId = 1, ColorId = 1, ModelYear = 2005, DailyPrice = 150, Description = "Beyaz Fiat Punto"},
                new Car{CarId=2, BrandId = 1, ColorId = 3, ModelYear = 2015, DailyPrice = 300, Description = "Kırmızı Fiat Egea"},
                new Car{CarId=3, BrandId = 2, ColorId = 3, ModelYear = 2016, DailyPrice = 320, Description = "Kırmızı VW Polo"},
                new Car{CarId=4, BrandId = 2, ColorId = 2, ModelYear = 2018, DailyPrice = 420, Description = "Siyah VW Passat"},
                new Car{CarId=5, BrandId = 3, ColorId = 2, ModelYear = 2012, DailyPrice = 250, Description = "Siyah Renault Megane"},
                new Car{CarId=6, BrandId = 3, ColorId = 1, ModelYear = 2017, DailyPrice = 350, Description = "Beyaz Renault Clio"},
                new Car{CarId=7, BrandId = 2, ColorId = 4, ModelYear = 2019, DailyPrice = 500, Description = "Gri VW Jetta"}

            };
            _colors = new List<Color>
            {
                new Color{ColorId=1, ColorName = "Beyaz"},
                new Color{ColorId=2, ColorName = "Siyah"},
                new Color{ColorId=3, ColorName = "Kırmızı"},
                new Color{ColorId=4, ColorName = "Gri"}

            };
            _brands = new List<Brand>
            {
                new Brand{BrandId=1, BrandName = "Fiat"},
                new Brand{BrandId=2, BrandName = "VW"},
                new Brand{BrandId=3, BrandName = "Renault"}
            };
        }

       

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            if (car == null)
            {
                throw new NullReferenceException("Aradığınız kayıt bulunamadı");
            }

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return _cars.Where(c => c.ColorId == ColorId).ToList();
        }

        public List<Car> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetList(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}

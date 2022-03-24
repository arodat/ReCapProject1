using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from a in context.Cars
                    join b in context.Brands on a.BrandId equals b.BrandId
                    join c in context.Colors on a.ColorId equals c.ColorId
                    select new CarDetailDto {CarId = a.CarId, ModelName = a.ModelName, BrandName = b.BrandName, ModelYear = a.ModelYear, ColorName = c.ColorName, DailyPrice= a.DailyPrice };
                return result.ToList();
            }
        }
    }
}

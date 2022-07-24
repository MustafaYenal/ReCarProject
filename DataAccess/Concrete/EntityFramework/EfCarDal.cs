using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, Re_CapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (Re_CapDbContext context=new Re_CapDbContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}

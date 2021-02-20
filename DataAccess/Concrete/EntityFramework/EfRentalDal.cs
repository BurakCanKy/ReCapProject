using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentaCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {

            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.ID
                             join cus in context.Customers
                             on re.CustomerId equals cus.CustomerId
                             join us in context.Users
                             on cus.UserId equals us.UserId
                             select new RentalDetailDto
                             {
                                 CarId = re.CarId,
                                 CarName = ca.CarName,
                                 CustomerName = cus.CustomerName,
                                 RentalId = ca.ID,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();

            }
        }
    }
}


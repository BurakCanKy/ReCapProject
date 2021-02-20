using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.UserId).NotEmpty().Must(CheckUserExist).WithMessage("User is not exist!");

        }

        private bool CheckUserExist(int id)
        {
            RentaCarContext _context = new RentaCarContext();
            var user = _context.Users.Where(u => u.UserId == id).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(rnt => rnt.CarId).NotEmpty();
            RuleFor(rnt => rnt.CustomerId).NotEmpty();
            RuleFor(rnt => rnt.RentDate).NotEmpty();
            RuleFor(rnt => rnt.RentDate).GreaterThan(DateTime.Now).WithMessage("Lütfen doğru tarih girdiğinizden emin olun!!!");
            RuleFor(rnt => rnt.ReturnDate).NotEmpty();
            RuleFor(rnt => rnt.ReturnDate).GreaterThanOrEqualTo(rnt => rnt.ReturnDate).WithMessage("Aracın teslimat tarihi kiralama tarihinden önce olamaz!!!");

        }
    }
}

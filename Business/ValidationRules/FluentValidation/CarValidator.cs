using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.ModelName).MinimumLength(1);
            RuleFor(p => p.ModelName).NotEmpty();
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(300).When(p => p.BrandId == 6);
            //RuleFor(p => p.ModelName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }


        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

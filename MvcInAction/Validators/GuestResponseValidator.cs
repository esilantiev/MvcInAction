using MvcInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Mvc;

namespace MvcInAction.Validators
{
    public class GuestResponseValidator : AbstractValidator<GuestResponseModel>
    {
        public GuestResponseValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Enter your name please");
            RuleFor(x => x.Phone).NotNull().WithMessage("Enter your phone please");
            RuleFor(x => x.Email).NotNull().Matches(".+\\@.+\\..+");
            RuleFor(x => x.WillAttend).NotNull().WithMessage("Select some case");
        }
    }
}
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInAction.Interfaces
{
    public interface IValidatorFactory
    {
        IValidator<T> GetValidator<T>();
        IValidator GetValidator(Type type);
    }
}
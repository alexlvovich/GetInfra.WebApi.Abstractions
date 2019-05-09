using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions.Validation
{
    public interface IValidator<T>
    {
        GeneralResponse Validate(T entity);
    }
}

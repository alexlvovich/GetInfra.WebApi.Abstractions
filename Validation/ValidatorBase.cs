using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions.Validation
{
    public abstract class ValidatorBase<T> : IValidator<T>
    {


        protected ValidatorBase(IRegularExpressions expressions)
        {
            Expressions = expressions;
        }

        protected IRegularExpressions Expressions { get; private set; }

        #region IValidator<T> Members

        public abstract GeneralResponse Validate(T entity);

        #endregion

        protected ValidationErrorItem CreateValidationError(object attemtedValue, string validationKey, string validationMessage, params object[] validationMessageParameters)
        {
            if (validationMessageParameters != null && validationMessageParameters.Length > 0)
            {
                validationMessage = string.Format(validationMessage, validationMessageParameters);
            }

            return new ValidationErrorItem(
                validationKey,
                attemtedValue,
                new InvalidOperationException(validationMessage)
                );
        }

    }
}

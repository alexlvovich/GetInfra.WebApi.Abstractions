using GetInfra.WebApi.Abstractions.Models.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GetInfra.WebApi.Abstractions.Models.Validation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseResultResponseValidator<T> : IBaseResultResponseValidator<T>
    {
        protected BaseResultResponseValidator(IRegularExpressions expressions)
        {
            Expressions = expressions;
        }

        protected IRegularExpressions Expressions { get; private set; }

        #region IValidator<T> Members

        public abstract Task<BaseResultResponse> ValidateAsync(T entity, CancellationToken cancellation = default);

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
                validationMessage
                );
        }

    }
}

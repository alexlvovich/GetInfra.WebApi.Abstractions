using GetInfra.WebApi.Abstractions.Models;
using GetInfra.WebApi.Abstractions.Models.Responses;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    /// <summary>
    /// converting from one responce to another
    /// </summary>
    public static class BaseResultResponseExtentions
    {
      
        public static GenericResultResponse<T> ToGenericResultResponse<T>(this BaseResultResponse res)
       where T : notnull
        {
            var result = new GenericResultResponse<T>();

            result.Errors = res.Errors;
            result.ValidationErrors = res.ValidationErrors;
            return result;
        }
    }
}

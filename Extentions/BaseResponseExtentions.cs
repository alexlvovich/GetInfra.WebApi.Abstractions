using GetInfra.WebApi.Abstractions.Models.Responses;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    /// <summary>
    /// converting from one responce to another
    /// </summary>
    public static class BaseResponseExtensions
    {
        public static GenericValResponse<T> ToGenericValResponse<T>(this BaseResponse res)
          where T : struct
        {
            var result = new GenericValResponse<T>();

            result.Errors = res.Errors;
            result.ValiationErrors = res.ValiationErrors;
            return result;
        }

        public static GenericRefResponse<T> ToGenericRefResponse<T>(this BaseResponse res)
         where T : class
        {
            var result = new GenericRefResponse<T>();

            result.Errors = res.Errors;
            result.ValiationErrors = res.ValiationErrors;
            return result;
        }

        public static GenericResponse<T> ToGenericResponse<T>(this BaseResponse res)
       where T : notnull
        {
            var result = new GenericResponse<T>();

            result.Errors = res.Errors;
            result.ValiationErrors = res.ValiationErrors;
            return result;
        }
    }
}

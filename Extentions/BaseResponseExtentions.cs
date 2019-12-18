using GetInfra.WebApi.Abstractions.Models.Responses;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    public static class BaseResponseExtentions
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
    }
}

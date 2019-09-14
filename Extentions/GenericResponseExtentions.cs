using System;

namespace GetInfra.WebApi.Abstractions.Extentions
{
    public static class GenericResponseExtentions
    {
        public static GeneralResponse ToGeneralResponse<T>(this GenericResponse<T> res)
           where T : struct
        {
            var result = new GeneralResponse();

            result.Errors = res.Errors;
            result.ValiationErrors = res.ValiationErrors;
            result.NewId = (long)Convert.ChangeType(res.NewId, typeof(long));

            return result;
        }
    }
}

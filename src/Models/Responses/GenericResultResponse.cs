namespace GetInfra.WebApi.Abstractions.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericResultResponse<T> : BaseResultResponse where T : notnull
    {
        public T Result { get; set; }
    }
}

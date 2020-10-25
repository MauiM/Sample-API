namespace Sample.API.Models
{
    public class ApiResult<T>
    {
        public T Data { get; set; }

        public bool IsSuccess
        {
            get
            {
                return string.IsNullOrWhiteSpace(Error);
            }

        }

        public string Error { get; set; } = string.Empty;

        public ApiResult() { }

        public ApiResult(T data)
        {
            Data = data;
        }
    }
}
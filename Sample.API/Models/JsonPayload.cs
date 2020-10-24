namespace Sample.API.Models
{
    public class JsonResult<T>
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

        public JsonResult(T data)
        {
            Data = data;
        }
    }
}
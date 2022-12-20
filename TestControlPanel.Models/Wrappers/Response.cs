using TestControlPanel.Models.Enums;

namespace TestControlPanel.Models.Wrappers
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }
        public ResponseCode ResponseCode { get; set; }

        public Response()
        {
        }
        public Response(ResponseCode responseCode, T data, string? message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
            ResponseCode = responseCode;
        }

        public Response(T? data, string? message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string? message)
        {
            Succeeded = true;
            Message = message;
        }

        public static Response<T> GetSuccess()
        {
            return new Response<T>(ResponseCode.Success, default, default);
        }

        public static Response<T> GetSuccess(T data, string? message = null)
        {
            return new Response<T>(ResponseCode.Success, data, message);
        }

        public static Response<T> Get(ResponseCode responseCode, T data, string? message = null)
        {
            return new Response<T>(responseCode, data, message);
        }

        public static Response<T> GetFailure()
        {
            return new Response<T>(ResponseCode.Failed, default, default);
        }

        public static Response<T> GetFailure(T data, string? message = null)
        {
            return new Response<T>(ResponseCode.Failed, data, message);
        }


    }
}
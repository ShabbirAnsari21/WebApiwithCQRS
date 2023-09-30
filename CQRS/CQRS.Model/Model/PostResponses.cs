namespace CQRS.Api.Model
{
    public class PostResponses
    {
        public int Id { get; set; }
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; }
        private PostResponses(int id, bool isSuccess, string message)
        {
            Id = id;
            IsSuccess = isSuccess;
            Message = message;
        }
        public static PostResponses ResponseMessages(int id, bool isSuccess, string message)
        {
            return new(id, isSuccess, message);
        }
    }
}

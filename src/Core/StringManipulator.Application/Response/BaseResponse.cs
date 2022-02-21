namespace StringManipulator.Application
{
    public abstract class BaseResponse
    {
        public BaseResponse()
        {
            IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}

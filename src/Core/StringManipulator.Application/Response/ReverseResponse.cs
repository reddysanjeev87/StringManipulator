namespace StringManipulator.Application
{
    public class ReverseResponse:BaseResponse
    {
        /// <summary>
        /// Reverse string
        /// </summary>
        public string OriginalText { get; set; }
        public string ReverseText { get; set; }
    }
}

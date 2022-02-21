using StringManipulator.Application;
using System.Text;

namespace StringManipulator.Service
{
    public class ReverseService : IReverseService
    {
        private readonly IFileWriter fileWriter;
        private readonly IFileReader fileReader;
       
        public ReverseService(IFileWriter fileWriter, IFileReader fileReader)
        { 
            this.fileWriter = fileWriter;
            this.fileReader = fileReader;
        }
        ReverseResponse IReverseService.Reverse()
        {
            var content = this.fileReader.Read();
            var response=new ReverseResponse();

            if (string.IsNullOrWhiteSpace(content))
            {
                response.IsSuccess = false;
                response.ErrorMessage = "File does not have any content";
                return response;
            }
            response.OriginalText = content.Trim();
            var stringBuilder = new StringBuilder();
            for(var i=content.Length-1; i>=0; i--)
            {
                stringBuilder.Append(content[i]);
            }
            response.ReverseText = stringBuilder.ToString().Trim();
            this.fileWriter.Write(response.ReverseText);
            return response;
        }
    }
}

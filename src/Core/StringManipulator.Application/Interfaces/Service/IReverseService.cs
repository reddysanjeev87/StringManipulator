namespace StringManipulator.Application
{
    public interface IReverseService
    {
        /// <summary>
        /// this will read data to file system
        /// revearse the string 
        /// and write reverse string to file system
        /// </summary>
        /// <returns></returns>
        ReverseResponse Reverse();
    }
}

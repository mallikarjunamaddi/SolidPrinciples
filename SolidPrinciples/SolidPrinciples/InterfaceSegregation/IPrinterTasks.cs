namespace SolidPrinciples.InterfaceSegregation
{
    /// <summary>
    /// Big Fat Interface with all possbile Printer features
    /// </summary>
    public interface IPrinterTasks
    {

        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
        bool FaxContent(string content);

        /// <summary>
        /// New Feature, if we add it in this interface, all the 
        /// clients need to implement this method, irrespective of 
        /// whether they can perform PrintDuplex Or not (2nd Problem)
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        //bool PrintDuplexContent(string content); // New feature
    }
}

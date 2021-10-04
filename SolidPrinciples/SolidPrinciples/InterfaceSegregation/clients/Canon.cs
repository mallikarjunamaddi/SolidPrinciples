using System;

namespace SolidPrinciples.InterfaceSegregation.clients
{
    /// <summary>
    /// Canon can perform Print, Scan and PhotoCopy.
    /// it can't perform Fax operation but still Canon
    /// need to handle FaxContent (1st Problem)
    /// </summary>
    public class Canon : IPrinterTasks
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Content");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Content");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Content");
            return true;
        }
    }
}

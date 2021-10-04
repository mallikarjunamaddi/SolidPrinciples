using System;

namespace SolidPrinciples.InterfaceSegregation.clients
{
    /// <summary>
    /// HP Printer have Print, Fax, Scan and PhotoCopy features
    /// </summary>
    class HPLaserJet : IPrinterTasks
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Content");
            return true;
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

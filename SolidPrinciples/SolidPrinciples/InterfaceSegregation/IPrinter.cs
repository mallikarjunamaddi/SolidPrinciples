namespace SolidPrinciples.InterfaceSegregation
{
    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    public interface IFaxContent
    {
        bool FaxContent(string content);
    }

    public interface IPrintDuplexContent
    {
        bool PrintDuplexContent(string content);
    }
}

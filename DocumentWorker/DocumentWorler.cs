namespace DocumentWorker;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is open");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Document editing available in Pro version");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Saving a document is available in the Pro version");
    }
}
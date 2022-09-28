namespace DocumentWorker;

public class ExpertDocumentWorker :ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in new format");
    }
}
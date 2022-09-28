namespace number3;
using DocumentWorker;

class Program
{
    static void Main()
    {
        DocumentWorker worker = new DocumentWorker();
        Console.WriteLine("do you have a key? ");
        string? ans = Console.ReadLine();
        if (ans == "yes")
        {
            Console.Write("write key: ");
            int key = int.Parse(Console.ReadLine());
            if (key == 1234)
            {
                worker = new ProDocumentWorker();
            }
            else if (key == 4321)
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                Console.WriteLine("incorrect key");
            }
        }
        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}
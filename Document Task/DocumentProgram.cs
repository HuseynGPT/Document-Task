namespace DocumentTask;

internal class DocumentProgram
{
    static public void OpenDocument()
    {
        Console.WriteLine("Document Opened");
    }

    virtual public void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert version");
    }

    virtual public void SaveDocument()
    {
        Console.WriteLine("Can save in Pro And Expert mode versions");
    }


}

using DocumentTask;

namespace Document_Task;

internal class ProDocuemntProgram:DocumentProgram
{
    public override sealed void EditDocument()
    {
        Console.WriteLine("Document edited!!");
    }


    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in doc format, for pdf format buy experty packet");
    }



}

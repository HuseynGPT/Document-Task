using Document_Task;
using DocumentTask;
using System.Net;

dynamic key;

int row = 0;



while (true)
{
    basliq:

    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Clear();
    Functions.ShowLogo();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("\t\t\t\t\t\t\t\t");
    Console.Write("Enter your lisence key: ");
    string inpt = Console.ReadLine();
    if (inpt == "basic")
    {
        basic:
        Console.Clear();

        DocumentProgram dc = new DocumentProgram();
        Console.WriteLine("Your dont have request to edit and save docs");

        Console.WriteLine("Press any key to go back");
        Console.ReadKey();
        goto basliq;
    }

    else if (inpt.ToLower() == "pro")
    {

    pro:
        Console.Clear();
        DocumentProgram documentProgram = new ProDocuemntProgram();

        Console.WriteLine("1.Edit\n2.Save\nMake a Choice: ");
        int inpttt = int.Parse(Console.ReadLine());

        if (inpttt == 1)
        {
            documentProgram.EditDocument();
            Console.WriteLine("Press any key to go back");
            Console.ReadKey();
            goto pro;


        }
        else if(inpttt == 2) { documentProgram.SaveDocument(); Console.WriteLine("Press any key to go back");
            Console.ReadKey();
            goto pro;
        }
        

    }


    else if (inpt.ToLower() == "expert")
    {
        expert:
        Console.Clear();

        DocumentProgram documentProgram = new ExpertDocument();

        Console.WriteLine("1.Edit\n2.Save\nMake a Choice: ");
        int inpttt = int.Parse(Console.ReadLine());

        if (inpttt == 1)
        {
            documentProgram.EditDocument();
            Console.WriteLine("Press any key to go back");
            Console.ReadKey();
            goto expert;

        }
        else if (inpttt == 2)
        {
            documentProgram.SaveDocument(); Console.WriteLine("Press any key to go back");
            Console.ReadKey();
            goto expert;
        }
    }


}
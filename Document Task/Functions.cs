using System.Globalization;

namespace Document_Task;

static class Functions
{
   static public  void menu_show(string[][] arr, int a)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (i == a)
                    Console.BackgroundColor = ConsoleColor.Red;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\t\t\t\t\t\t\t");
                Console.WriteLine(arr[i][j]);
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }
    }

    static public void check_rotate(string[][] arr, ref int row, dynamic input)
    {
        if (input.Key == ConsoleKey.UpArrow)
        {
            if (row == 0)
            {
                row = arr.Length - 1;
            }
            else
            {
                row--;
            }
        }
        else if (input.Key == ConsoleKey.DownArrow)
        {
            if (row == arr.Length - 1)
            {
                row = 0;
            }
            else
            {
                row++;
            }
        }
    }


    static public void ShowLogo()
    {
        Console.WriteLine(@"⠀⠀⠀

                    .*/%%                                                                           
      ,/(#&&&&&&&&&&&&&&%..  ...  ..  ..                                                            
&&&&&&&&&&&&&&&&&&&&&&&&%. ..   ..  .. .&(                                                          
&&&&&&&&&&&&&&&&&&&&&&&&%,,..,,,..,,.  .&#                                                          
&&&&&&&&&&&&&&&&&&&&&&&&&//**///**//,  .&#                                                          
&&&&%#%&&&&/*/&&&&*.*&&&%        .      &#            ..       ..       .                         .(
&&&&#  &&&*  .&&&#  %&&&&###########/  .&#            (&(     #&&/    *&%                         .&
&&&&&* #&( .( /&&. .&&&&%               &#             #&/   #&,#&.  .&&.  (&&&&(.   /#,&&#  #&&&#,&
&&&&&% *&  (&, %#  /&&&&&(/////////(*  .&#              %&, /&*  &#  %&, (&.    ,&%. /&    #&,    *&
&&&&&&/ . *&&/ ,. ,&&&&&%               &#               %&,&/   .&.#&,  %/      %&, (%   ,&%     .&
&&&&&&%   %&&%   .%&&&&&&/*********/,  .&#               .%&#     /&&/   *&%.   %&,  /%    *&(   /&&
&&&&&&&&&&&&&&&&&&&&&&&&%               &#                 .       .        ...               ,.    
&&&&&&&&&&&&&&&&&&&&&&&&&///////////*   &#                                                          
&&&&&&&&&&&&&&&&&&&&&&&&%.             .&#                                                          
&&&&&&&&&&&&&&&&&&&&&&&&%. ........... .&#                                                          
      ,/(#&&&&&&&&&&&&&&%.. ");
    }
}

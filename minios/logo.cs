using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace minios
{
    class logo
    {
        internal static void Logo(string version)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ------------------------------------------------------------------------------ ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("      _	     $$$$$$\\  $$$$$$\\ $$$$$$$$\\  $$$$$$\\     $$$$$$\\   $$$$$$\\ ");       
            Console.WriteLine("     (_)	    \\_$$  _|$$  __$$\\ \\_$$  __|$$  __$$\\   $$  __$$\\ $$  __$$\\");            
            Console.WriteLine("      _		   $$ |  $$ /  $$ |  $$ |   $$ /  $$ |  $$ /  $$ |$$ /  \\__|");
            Console.WriteLine(" *   | |   *	  $$ |  $$ |  $$ |  $$ |   $$$$$$$$ |  $$ |  $$ |\\$$$$$$\\");
            Console.WriteLine("*    | |    *     $$ |  $$ |  $$ |  $$ |   $$  __$$ |  $$ |  $$ | \\____$$\\ ");
            Console.WriteLine("*    |_|    *     $$ |  $$ |  $$ |  $$ |   $$ |  $$ |  $$ |  $$ |$$\\   $$ |");
            Console.WriteLine(" *         *    $$$$$$\\  $$$$$$  |  $$ |   $$ |  $$ |   $$$$$$  |\\$$$$$$  |");
            Console.WriteLine("    *   *       \\______| \\______/   \\__|   \\__|  \\__|   \\______/  \\______/ ");
            Console.WriteLine(" ------------------------------------------------------------------------------ ");
        }
    }
}

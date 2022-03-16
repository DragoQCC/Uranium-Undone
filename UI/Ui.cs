using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastel;
using System.Drawing;

namespace Uranium_Undone.UI
{
    internal class Ui
    {
        public static void Banner()
        {
            Console.WriteLine
                (
               " ██╗   ██╗██████╗  █████╗ ███╗   ██╗██╗██╗   ██╗███╗   ███╗    ██╗   ██╗███╗   ██╗██████╗  ██████╗ ███╗   ██╗███████╗\n".Pastel(Color.LimeGreen) +
               " ██║   ██║██╔══██╗██╔══██╗████╗  ██║██║██║   ██║████╗ ████║    ██║   ██║████╗  ██║██╔══██╗██╔═══██╗████╗  ██║██╔════╝\n".Pastel(Color.LimeGreen) +
               " ██║   ██║██████╔╝███████║██╔██╗ ██║██║██║   ██║██╔████╔██║    ██║   ██║██╔██╗ ██║██║  ██║██║   ██║██╔██╗ ██║█████╗  \n".Pastel(Color.LimeGreen) +
               " ██║   ██║██╔══██╗██╔══██║██║╚██╗██║██║██║   ██║██║╚██╔╝██║    ██║   ██║██║╚██╗██║██║  ██║██║   ██║██║╚██╗██║██╔══╝  \n".Pastel(Color.LimeGreen) +
               " ╚██████╔╝██║  ██║██║  ██║██║ ╚████║██║╚██████╔╝██║ ╚═╝ ██║    ╚██████╔╝██║ ╚████║██████╔╝╚██████╔╝██║ ╚████║███████╗\n".Pastel(Color.LimeGreen) +
               "  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝ ╚═════╝ ╚═╝     ╚═╝     ╚═════╝ ╚═╝  ╚═══╝╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚══════╝\n".Pastel(Color.LimeGreen) +
                "\n" +
               "Author: Jon @QueenCityCyber \n".Pastel(Color.DeepSkyBlue) +
               "https://github.com/Queen-City-Cyber \n".Pastel(Color.LimeGreen)
                );
        }
    }
}

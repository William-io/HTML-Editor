using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Editor.Views
{
    public class DrawPlus : Entity
    {
        public void Plus()
        {
            Console.Write("+");
            for (Sum = 0; Sum <= 30; Sum++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}

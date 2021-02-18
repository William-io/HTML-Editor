using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Editor.Views
{
    public class DrawLines : Entity
    {
        public void Line()
        {
            for (Lines = 0; Lines <= 10; Lines++)
            {
                Console.Write("|");
                for (Sum = 0; Sum <= 30; Sum++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}

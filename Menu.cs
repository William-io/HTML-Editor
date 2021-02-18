using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Editor
{
    public class Menu : TestInstance
    {

        public void Show()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawPlus.Plus();
            DrawLines.Line();
            DrawFinal.Draw();
            WriteOptions.Write(); //Falta montar o método

            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);

        }
        public void HandleMenuOptions(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}

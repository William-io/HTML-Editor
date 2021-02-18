using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Editor
{
    public class Editor : Save
    {

        public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("---------------");
            Start();

        }

        public void Start()
        {

            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("---------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            SavePath(file.ToString());


        }
    }
}

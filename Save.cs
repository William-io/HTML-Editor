using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HTML_Editor
{
    public class Save : Entity
    {
        public void SavePath(string Text)
        {
            Console.Clear();
            Console.Write("Qual o caminho há ser salvo:\n:\\>");
            Path = Console.ReadLine();

            using (var file = new StreamWriter(Path))
            {
                file.Write(Text);
            }

            Console.WriteLine($"Arquivo {Path} salvo com sucesso!\n");


        }
    }
}

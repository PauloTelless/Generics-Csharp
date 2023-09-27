using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05StackUdo
{
    internal class EditorTexto
    {
        private Stack<char> undoStack = new Stack<char>();
        private string texto = "";

        public void DigitarChar(char ch)
        {
            texto += ch;
            undoStack.Push(ch);
            Console.WriteLine($"Texto => {texto}");
        }

        public void UndoChar()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("Não existe nenhuma letra");
            }

            else
            {
                undoStack.Pop();
                texto = texto.Substring(0, texto.Length - 1);
                Console.WriteLine($"Texto => {texto}");
            }
        }
    }
}

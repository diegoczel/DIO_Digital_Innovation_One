using System;
using EstruturaPrograma.Exemplos;

namespace EstruturaPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = new Exemplos.Pilha();
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            //s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            // Gera exception
            try
            {
                Console.WriteLine(s.Desempilha());
            }
            catch //(InvalidOperationException e)
            {
                Console.WriteLine("Exception !! A pilha esta vazia!");
                //Console.WriteLine(e);
            }

            Console.WriteLine();
            var pilha = new Stack();
            pilha.Push(1);
            pilha.Push(10);
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());

            // null, pois stack len = 0
            if (pilha.Len == 0)
            {
                Console.WriteLine("Pilha vazia");
            }
            else
            {
                Console.WriteLine(pilha.Pop());
            }
            
            Console.WriteLine(pilha.Len);
            
        }
    }
}

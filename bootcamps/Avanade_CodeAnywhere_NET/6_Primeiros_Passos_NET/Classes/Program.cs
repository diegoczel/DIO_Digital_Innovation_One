using System;
using Classes.heranca;
using Classes.metodos;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Ponto(10,20);
            
            var p2 = new Ponto3d(10, 20, 30);

            Ponto p3 = new Ponto3d(10, 20, 30);
            
            // acessar membro static da class
            //Ponto3d.Calcular();

        }
    }
}

namespace Classes.metodos
{
    public class OutArg
    {
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {
            // out na passagem de arg em method permite a inicialização de var
            // ou inicializa fora var
            // alternativa para return multiplo de values em methods

            //Dividir(int x, int y, out int resultado, out int resto) 
            // inicializa e retorna values de var resultado e resto
            int resto;
            Dividir(10, 3, out int resultado, out resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}
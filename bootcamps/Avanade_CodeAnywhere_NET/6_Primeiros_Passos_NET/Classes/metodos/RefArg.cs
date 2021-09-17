namespace Classes.metodos
{
    public class RefArg
    {
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        // sobrecarga de method
        // mesmo method MAS com assinatura de args !=
        public static void Inverter()
        {
            // ref necessita que var estejam inicializadas
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}
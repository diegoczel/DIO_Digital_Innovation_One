namespace Classes.heranca
{
    public class Ponto3d : Ponto
    {
        public int z;
        public Ponto3d(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            // acessar
            // Ponto3d.Calcular()
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}
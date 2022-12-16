namespace triangulo_1043 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();
            double[] lados = Array.ConvertAll(valores, double.Parse);

            Array.Sort(lados);

            if (lados[0] + lados[1] > lados[2]) {

                double perimetro = lados[0] + lados[1] + lados[2];
                Console.WriteLine("Perimetro = {0}", perimetro.ToString("F1"));

            } else {

                double area = ((double.Parse(valores[0]) + double.Parse(valores[1])) * double.Parse(valores[2])) / 2.0;
                Console.WriteLine("Area = {0}", area.ToString("F1"));
            }
         

        }

    }

}

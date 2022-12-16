namespace areaDoCirculo {

    public class Program {
        public static void Main(string[] args) {

            double n = 3.14159;
            double raio = Double.Parse(Console.ReadLine());

            double area = (raio * raio) * n;

            Console.WriteLine($"A={area:F4}");

        }
    }
}

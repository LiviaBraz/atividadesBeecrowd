namespace produtoSimples_1004 {
    public class Program {
        public static void Main(string[] args) {

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            int PROD = valor1 * valor2;

            Console.WriteLine($"PROD = {PROD}");

        }
    }
}
namespace notasEMoedas_1021 {
    public class Program {
        public static void Main(string[] args) {

            double valor = double.Parse(Console.ReadLine());

            double valorIns = valor;

            int nota100 = (int)(valor / 100.00);
            valor -= 100.00 * nota100;

            int nota50 = (int)(valor / 50.00);
            valor -= 50.00 * nota50;

            int nota20 = (int)(valor / 20.00);
            valor -= 20.00 * nota20;

            int nota10 = (int)(valor / 10.00);
            valor -= 10.00 * nota10;

            int nota5 = (int)(valor / 5.00);
            valor -= 5.00 * nota5;

            int nota2 = (int)(valor / 2.00);
            valor -= 2.00 * nota2;

            int moeda1 = (int)(valor / 1.00);
            valor -= 1.00 * moeda1;

            int moeda50 = (int)(valor / 0.50);
            valor -= 0.50 * moeda50;

            int moeda25 = (int)(valor / 0.25);
            valor -= 0.25 * moeda25;

            int moeda10 = (int)(valor / 0.10);
            valor -= 0.10 * moeda10;

            int moeda5 = (int)(valor / 0.05);
            valor -= 0.05 * moeda5;

            int moeda1c = (int)(valor / 0.01);
            valor -= 0.01 * moeda1c;


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda1c} moeda(s) de R$ 0.01");

        }

    }

}
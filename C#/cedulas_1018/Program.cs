namespace cedulas_1018 {
    public class Program {
        public static void Main(string[] args) {

            int valor = int.Parse(Console.ReadLine());

            int valorIns = valor;

            int nota100 = (int)(valor / 100);
            valor -= 100 * nota100;

            int nota50 = (int)(valor / 50);
            valor -= 50 * nota50;

            int nota20 = (int)(valor / 20);
            valor -= 20 * nota20;

            int nota10 = (int)(valor / 10);
            valor -= 10 * nota10;

            int nota5 = (int)(valor / 5);
            valor -= 5 * nota5;

            int nota2 = (int)(valor / 2);
            valor -= 2 * nota2;

            int nota1 = (int)(valor / 1);

            Console.WriteLine(valorIns);
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
        
        }

    }

}
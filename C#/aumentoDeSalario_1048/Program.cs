namespace aumentoDeSalario_1048 {
    public class Program {
        public static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine());
            double salarioAtual, dif, reajuste;

            if (salario > 0.00 && salario <= 400.00) {

                reajuste = 15;
                salarioAtual = salario + salario * (reajuste / 100.00);
                dif = salarioAtual - salario;

                Console.WriteLine($"Novo salario: {salarioAtual:F2}");
                Console.WriteLine($"Reajuste ganho: {dif:F2}");
                Console.WriteLine($"Em percentual: {reajuste} %");

            } else if (salario > 400.00 && salario <= 800.00) {

                reajuste = 12;
                salarioAtual = salario + salario * (reajuste / 100.00);
                dif = salarioAtual - salario;

                Console.WriteLine($"Novo salario: {salarioAtual:F2}");
                Console.WriteLine($"Reajuste ganho: {dif:F2}");
                Console.WriteLine($"Em percentual: {reajuste} %");

            } else if (salario > 800.00 && salario <= 1200.00) {

                reajuste = 10;
                salarioAtual = salario + salario * (reajuste / 100.00);
                dif = salarioAtual - salario;

                Console.WriteLine($"Novo salario: {salarioAtual:F2}");
                Console.WriteLine($"Reajuste ganho: {dif:F2}");
                Console.WriteLine($"Em percentual: {reajuste} %");

            } else if (salario > 1200.00 && salario <= 2000.00) {

                reajuste = 7;
                salarioAtual = salario + salario * (reajuste / 100.00);
                dif = salarioAtual - salario;

                Console.WriteLine($"Novo salario: {salarioAtual:F2}");
                Console.WriteLine($"Reajuste ganho: {dif:F2}");
                Console.WriteLine($"Em percentual: {reajuste} %");

            } else {

                reajuste = 4;
                salarioAtual = salario + salario * (reajuste / 100.00);
                dif = salarioAtual - salario;

                Console.WriteLine($"Novo salario: {salarioAtual:F2}");
                Console.WriteLine($"Reajuste ganho: {dif:F2}");
                Console.WriteLine($"Em percentual: {reajuste} %");

            }

        }
    }
}
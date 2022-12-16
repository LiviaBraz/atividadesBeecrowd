namespace salarioComBonus_1009 {
    public class Program {
        public static void Main(string[] args) {

            string nomeDoVendedor = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendasEmDinheiro = double.Parse(Console.ReadLine());

            double total = salario + (vendasEmDinheiro * 0.15);

            Console.WriteLine($"TOTAL = R$ {total:F2}");

        }

    }

}

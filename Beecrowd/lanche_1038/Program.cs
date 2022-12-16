namespace lanche_1038 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();

            int codigo = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);

            switch (codigo) {

                case 1:
                    double preco1 = 4.0;
                    Console.WriteLine($"TOTAL: R$ {preco1*quant:F2}");
                break;
                case 2:
                    double preco2 = 4.5;
                    Console.WriteLine($"TOTAL: R$ {preco2 * quant:F2}");
                break;
                case 3:
                    double preco3 = 5.0;
                    Console.WriteLine($"TOTAL: R$ {preco3 * quant:F2}");
                break;
                case 4:
                    double preco4 = 2.0;
                    Console.WriteLine($"TOTAL: R$ {preco4 * quant:F2}");
                break;
                case 5:
                    double preco5 = 1.5;
                    Console.WriteLine($"TOTAL: R$ {preco5 * quant:F2}");
                break;
            }
        }

    }
}
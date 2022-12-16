using System.Drawing;

namespace calculoSimples_1010 {
    public class Program {
        public static void Main(string[] args) {

            string[] peca1 = Console.ReadLine().Split();
            string[] peca2 = Console.ReadLine().Split();

            int codPeca1 = int.Parse(peca1[0]);
            int numPeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2]);

            int codPeca2 = int.Parse(peca2[0]);
            int numPeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2]);

            double valorTotal = numPeca1 * valorPeca1 + numPeca2 * valorPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");

        }

    }

}
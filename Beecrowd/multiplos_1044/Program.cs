namespace multiplos_1044 {
    public class Program {
        public static void Main(string[] args) {

            string[] entrada = Console.ReadLine().Split();

            int[] valores = Array.ConvertAll(entrada, int.Parse);
            Array.Sort(valores);

            if (valores[1] % valores[0] == 0) {

                Console.WriteLine("Sao multiplos");

            } else {

                Console.WriteLine("Nao sao multiplos");

            }

        }

    }

}
namespace oMaior_1013 {
    public class Program { 
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();

            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);

            int maior = (valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2;

            maior = (maior + valor3 + Math.Abs(maior - valor3)) / 2;

            Console.WriteLine($"{maior} eh o maior");
        }

    }

}
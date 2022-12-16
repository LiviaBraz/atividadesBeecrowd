namespace gastoDeCombustivel_1017 {
    public class Program {
        public static void Main(string[] args) {

            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            int distancia = tempo * velocidade;

            double litros = distancia / 12.0;

            Console.WriteLine($"{litros:F3}");

        }

    }

}

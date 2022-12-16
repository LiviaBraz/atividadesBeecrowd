namespace conversaoDeTempo_1019 {
    public class Program {
        public static void Main(string[] args) {

            int segundos = int.Parse(Console.ReadLine());

            int minutos = (int)(segundos / 60);
            segundos -= minutos * 60;

            int horas = (int)(minutos / 60);
            minutos -= horas * 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }

    }

}

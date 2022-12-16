namespace media2_1006 { 
    public class Program {
        public static void Main(string[] args) {

            double notaA = double.Parse(Console.ReadLine());
            double notaB = double.Parse(Console.ReadLine());
            double notaC = double.Parse(Console.ReadLine());

            double media = (notaA * 0.2)  + (notaB * 0.3) + (notaC * 0.5);

            Console.WriteLine($"MEDIA = {media:F1}");

        }

    }

}

namespace idadeEmDias {
    public class Program { 
        public static void Main(string[] args) {

            int dias = int.Parse(Console.ReadLine());

            int anos = (int)(dias / 365);
            dias -= anos * 365;

            int meses = (int)(dias / 30);
            dias -= meses * 30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(s)");
            Console.WriteLine($"{dias} dia(s)");

        }

    }

}

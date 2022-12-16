namespace salario_1008 {
    public class Program {
        public static void Main(string[] args) {

            int numeroFunc = int.Parse(Console.ReadLine());
            int horasTrab = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double salario = horasTrab * valor;

            Console.WriteLine($"NUMBER = {numeroFunc}\r\nSALARY = U$ {salario:F2}");

        } 

    }

}

namespace sortSimples_1042 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();

            int valor = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);
            int valor3 = int.Parse(valores[2]);

            int val1 = valor;
            int val2 = valor2; 
            int val3 = valor3; 

            if (val1 > val2 && val1 > val3) {

                int aux = val1;
                val1 = val3;
                val3 = aux;

            } else if (val2 > val1 && val2 > val3) {

                int aux = val2;
                val2 = val3;
                val3 = aux;

            }

            if (val1 > val2) {

                int aux = val1;
                val1 = val2;
                val2 = aux;

            }

            Console.WriteLine($"{val1}\n{val2}\n{val3}\n\n{valor}\n{valor2}\n{valor3}");

        }

    }

}

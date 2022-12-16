namespace tiposDeTriangulos_1045 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();
            Array.Sort(valores);

            double valor1 = double.Parse(valores[0]);
            double valor2 = double.Parse(valores[1]);
            double valor3 = double.Parse(valores[2]);

            if (valor3 > valor2 && valor3 > valor1) {

                double aux = valor3;
                valor3 = valor1;
                valor1 = aux;

            } else if (valor2 > valor1 && valor2 > valor3) {

                double aux = valor2;
                valor2 = valor1;
                valor1 = aux;

            }

            if (valor3 > valor2) {

                double aux = valor3;
                valor3 = valor2;
                valor2 = aux;

            }


            if (valor1 >= valor2 + valor3) {

                Console.WriteLine("NAO FORMA TRIANGULO");

            }

            if (valor1 * valor1 == valor2 * valor2 + valor3 * valor3) {

                Console.WriteLine("TRIANGULO RETANGULO");

            } else if (valor1 * valor1 > valor2 * valor2 + valor3 * valor3) {

                Console.WriteLine("TRIANGULO OBTUSANGULO");

            } else {

                Console.WriteLine("TRIANGULO ACUTANGULO");

            }

            if (valor1 == valor2 && valor2 == valor3) {

                Console.WriteLine("TRIANGULO EQUILATERO");

            } else if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3) {

                Console.WriteLine("TRIANGULO ISOSCELES");

            }


        }
    }
}
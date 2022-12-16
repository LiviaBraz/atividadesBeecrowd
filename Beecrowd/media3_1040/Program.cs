namespace media3_1040 {
    public class Program {
        public static void Main(string[] args) {

                string[] notas = Console.ReadLine().Split();

                double n1 = double.Parse(notas[0]);
                double n2 = double.Parse(notas[1]);
                double n3 = double.Parse(notas[2]);
                double n4 = double.Parse(notas[3]);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10.0;

                Console.WriteLine($"Media: {Math.Truncate(media * 10) / 10:F1}");

                if (media >= 7.0) {

                    Console.WriteLine("Aluno aprovado.");

                } else if (media < 5.0) {

                    Console.WriteLine("Aluno reprovado.");

                } else if (media >= 5.0 && media <= 6.9) {

                    Console.WriteLine("Aluno em exame.");

                    double exame = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Nota do exame: {exame:F1}");

                    double mediaFinal = (media + exame) / 2;

                    if (mediaFinal >= 5.0) {

                        Console.WriteLine("Aluno aprovado.");
                        Console.WriteLine($"Media final: {mediaFinal:F1}");

                    } else {

                        Console.WriteLine("Aluno reprovado.");
                        Console.WriteLine($"Media final: {mediaFinal:F1}");

                    }


                }


            }

        }

    }
namespace tempoDeJogo_1046 {
    public class Program {
        public static void Main(string[] args) {

            String[] horario = Console.ReadLine().Split();
            Array.Sort(horario);

            int horInic = int.Parse(horario[0]);
            int horFinal = int.Parse(horario[1]);

            int duracao;

            if (horInic < horFinal) {

                duracao = horFinal - horInic;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            } else if (horInic > horFinal) {

                duracao = (horFinal - horInic) + 24;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            } else {

                duracao = 24;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            }

        }

    }

}
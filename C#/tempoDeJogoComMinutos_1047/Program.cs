namespace tempoDeJogoComMinutos_1047 {
    public class Program {
        public static void Main(string[] args) {

            string[] horarios = Console.ReadLine().Split();

            int horaInic = int.Parse(horarios[0]);
            int minInic = int.Parse(horarios[1]);
            int horaFinal = int.Parse(horarios[2]);
            int minFinal = int.Parse(horarios[3]);

            int totalHoraInic = (horaInic * 60) + minInic;
            int totalHoraFinal = (horaFinal * 60) + minFinal;

            if (totalHoraFinal <= totalHoraInic) {

                totalHoraFinal += 1440;

            }

            int total = totalHoraFinal - totalHoraInic;

            int totalHoras = total / 60;
            int totalMinutos = total % 60;

            Console.WriteLine($"O JOGO DUROU {totalHoras} HORA(S) E {totalMinutos} MINUTO(S)" );

        }
    }
}
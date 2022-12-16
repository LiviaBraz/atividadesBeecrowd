namespace area_1012 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();
            
            double pi = 3.14159;

            double valorA = double.Parse(valores[0]);
            double valorB = double.Parse(valores[1]);
            double valorC = double.Parse(valores[2]);

            double areaTriRet = (valorA * valorC) / 2;
            double areaCirc = pi * (valorC * valorC);
            double areaTrap = ((valorA + valorB) * valorC) / 2;
            double areaQuad = Math.Pow(valorB, 2);
            double areaRet = valorA * valorB;

            Console.WriteLine($"TRIANGULO: {areaTriRet:F3}");
            Console.WriteLine($"CIRCULO: {areaCirc:F3}");
            Console.WriteLine($"TRAPEZIO: {areaTrap:F3}");
            Console.WriteLine($"QUADRADO: {areaQuad:F3}");
            Console.WriteLine($"RETANGULO: {areaRet:F3}");


        }

    }

}
using System;

namespace BMI_2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o peso: Kg");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso da pessoa: " + peso + "Kg");
            Console.WriteLine($"Altura da pessoa: {altura}m");

            float result = peso / (altura * altura);

            Console.WriteLine("O resultado é: " + result);

            if (result < 18.5) {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (result >= 18.6 && result < 25) {
                Console.WriteLine("Peso Normal");
            }
            else if (result > 25 && result < 40) {
                Console.WriteLine("Sobrepeso");
            }
        }
    }
}

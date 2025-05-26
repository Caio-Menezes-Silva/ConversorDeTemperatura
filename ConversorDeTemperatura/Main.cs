using System;
using System.Globalization;
namespace ConversorDeTemperatura
{
    internal class MenuPrincipal
    {
        static void Main(string[] args)
        {
            ConversorDeTemperatura conversor = new ConversorDeTemperatura();
            int option = -1;

            do
            {
                Console.WriteLine("Bem-vindo ao Conversor de Temperatura!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Celsius para Fahrenheit" + "\n2 - Fahrenheit para Celsius" + "\n3 - Sair do programa");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius:");
                        conversor.TemperaturaCelsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conversor.CelsiusParaFahrenheit(conversor.TemperaturaCelsius);
                        Console.WriteLine($"Temperatura em Fahrenheit: {conversor.TemperaturaFahrenheit}F° ");
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit:");
                        double temperaturaFahrenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        double resultadoCelsius = conversor.FahrenheitParaCelsius(temperaturaFahrenheit);
                        Console.WriteLine($"Temperatura em Celsius: {resultadoCelsius.ToString("F2", CultureInfo.InvariantCulture)}°C");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa. Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                

                if (option == 3)
                {
                    Console.WriteLine("Saindo do programa. Até logo!");
                }

            } while (option != 3);

        }
    }
}

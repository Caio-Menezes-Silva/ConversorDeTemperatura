using System.Globalization;
namespace ConversorDeTemperatura
{
    internal class MenuPrincipal
    {
        static void Main(string[] args)
        {
            double input;
            int option = -1;

            do
            {
                Console.WriteLine("Bem-vindo ao Conversor de Temperatura!");
                Console.WriteLine("=========================================");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Celsius para Fahrenheit" + "\n2 - Fahrenheit para Celsius" + "\n3 - Sair do programa");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================================");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius:");
                        input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        ConversorDeTemperatura.CelsiusParaFahrenheit(ConversorDeTemperatura.CelsiusParaFahrenheit(input));
                        Console.WriteLine($"Temperatura em Fahrenheit: {input = ConversorDeTemperatura.CelsiusParaFahrenheit(input)}°F ");
                        Console.WriteLine("=========================================");
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit:");
                        input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.WriteLine($"Temperatura em Celsius: {input = ConversorDeTemperatura.FahrenheitParaCelsius(input)}°C");
                        Console.WriteLine("=========================================");
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa. Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (option != 3);

        }
    }
}

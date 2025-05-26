using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ConversorDeTemperatura
{
    internal class ConversorDeTemperatura
    {
        public double TemperaturaCelsius { get; set; }
        public double TemperaturaFahrenheit { get; set; }


        public static double CelsiusParaFahrenheit(double input)
        {
            double fahrenheit = (input * 9.0 / 5.0) + 32;
            return fahrenheit;
        }

        public static double FahrenheitParaCelsius(double input)
        {
            double celsius = (input - 32) * 5.0 / 9.0;

            return celsius; 
        }
    }
}

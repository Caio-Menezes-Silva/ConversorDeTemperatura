using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ConversorDeTemperatura
{
    internal class ConversorDeTemperatura
    {
        private double _temperaturaCelsius;
        private double _temperaturaFahrenheit;
        public double TemperaturaCelsius { get { return _temperaturaCelsius; } set { _temperaturaCelsius = value; } }
        public double TemperaturaFahrenheit { get { return _temperaturaFahrenheit; } set { _temperaturaFahrenheit = value; } }

        public ConversorDeTemperatura(double TemperaturaCelsius, double TemperaturaFahrenheit)
        {
             _temperaturaCelsius = TemperaturaCelsius ;
             _temperaturaFahrenheit = TemperaturaFahrenheit;
        }

        public ConversorDeTemperatura()
        {
        }

        public double CelsiusParaFahrenheit(double temperaturaCelsius)
        {   TemperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            return TemperaturaFahrenheit;
        }

        public double FahrenheitParaCelsius(double temperaturaFahrenheit)
        {
            return TemperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
        }


    }
}

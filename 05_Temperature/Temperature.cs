using System;

namespace _05_Temperature
{
    enum Unit {None, Fahrenheit, Celcius};
    internal class Temperature
    {
        public int Celcius { get; internal set; }
        public int Fahrenheit { get; internal set; }
        public Unit Unit { get; internal set; }
        public Temperature(Unit unit = Unit.None, int value = 0)
        {
            Unit Unit = unit;
            Celcius = value;
            Fahrenheit = value;
        }

        internal static double FahrenheitToCelcius(double v)
        {
            return (v - 32) * 5 / 9;
        }

        internal static double CelciusToFahrenheit(double v)
        {
            return (v * 1.8) + 32;
        }
    }
}
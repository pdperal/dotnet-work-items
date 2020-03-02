using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            ValuePerHour = valueperhour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"Data: {Date}\nValor por Hora: {ValuePerHour}\nHoras: {Hours}";
        }
    }
}

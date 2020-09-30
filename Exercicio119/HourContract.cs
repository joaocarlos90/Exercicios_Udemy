using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio119
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double TotalValue(int hours, double ValuePerHour, double BaseSalary)
        {
            int hoursforcalc = hours;
            double ValuePerHourcalc = ValuePerHour;
            double baseSalaryTotal = BaseSalary;

            var calculo1 = hoursforcalc * ValuePerHourcalc;
            var calculo2 = calculo1 + baseSalaryTotal;

            return calculo2;
        }
    }
}

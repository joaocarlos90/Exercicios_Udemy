using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace Exercicio119
{
    class Program
    {
        //projeto
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Department departament = new Department();
            HourContract hourContract = new HourContract();

            Console.WriteLine("Enter department´s name: ");
            departament.Name = Console.ReadLine().ToString();
            var departmentName = departament.Name;

            Console.WriteLine("Enter Worker data: ");
            Console.WriteLine("Name: ");
            worker.Name = Console.ReadLine().ToString();
            var workerName = worker.Name;

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            try
            {
                worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine().ToString());
            }
            catch (Exception e)
            {
                throw;
                return;
            }

            Console.WriteLine("Base salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine().ToString());

            Console.WriteLine("How many contracts to this worker? ");
            int numberOfContract = int.Parse(Console.ReadLine().ToString());

            var listaContrato = new List<HourContract>();

            for (int i = 1; i <= numberOfContract; i++)
            {
                Console.WriteLine("Enter" + i + "#" + "contract data: ");
                Console.WriteLine("Date (dd/mm/yyyy ");

                hourContract.Date = DateTime.Parse(Console.ReadLine().ToString());

                Console.WriteLine("Value per hour: ");
                hourContract.ValuePerHour = double.Parse(Console.ReadLine().ToString());

                Console.WriteLine("Duration (hours): ");
                hourContract.Hours = int.Parse(Console.ReadLine().ToString());

                listaContrato.Add(new HourContract()
                {
                    Date = hourContract.Date,
                    ValuePerHour = hourContract.ValuePerHour,
                    Hours = hourContract.Hours
                });

            }



            Console.WriteLine("Enter month and year to calcule income (MM/YYYY): ");

            var dateGetMonth = Console.ReadLine().ToString();

            SimpleDateFormat format = new SimpleDateFormat("MM/YYYY");

            format.Parse(dateGetMonth);



            foreach (var date in listaContrato)
            {
                var dateList = date.Date.ToString();
                string convert = dateList.Substring(3, 7);
                format.Parse(convert);
                if (dateGetMonth == convert)
                {
                    Console.WriteLine("Name: " + workerName);
                    Console.WriteLine("Department: " + departmentName);
                    var totalvalue = hourContract.TotalValue(date.Hours, date.ValuePerHour, worker.BaseSalary);
                    Console.WriteLine("Incom for " + dateGetMonth + ":  " + totalvalue);
                }
            }

        }
    }
}


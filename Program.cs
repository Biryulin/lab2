﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        public class prodac : rab
        {
            public decimal Obemprod { get; set; }
            public prodac (string fio, decimal salary, decimal obemprod) : base(fio, salary)
            {
                Obemprod = obemprod;
            }
            public override void Show()
            {
                Console.WriteLine($"Продавец: ФИО = {Fio}, зарплата = {getsalary()}руб.");
            }
            public override decimal getsalary()
            {
                decimal com = 0.1m * Obemprod;
                return oklad + com;
            }
        }

        static void Main(string[] args)
        {
            rab ivan = new rab("Иванов Н.С.", 50000);
            engi eng = new engi("Петров А.В.", 60000, "Инженер");
            prodac sale = new prodac("Сидоров Н.С.", 40000, 200);
            ivan.Show();
            eng.Show();
            sale.Show();
            Console.ReadKey();
        }
    }
}

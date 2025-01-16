using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class prodac : rab
    {
        public decimal Obemprod { get; set; }
        public prodac(string fio, decimal salary, decimal obemprod) : base(fio, salary)
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
}

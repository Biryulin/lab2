using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class rab
    {
        public string Fio { get; set; }
        public decimal oklad { get; set; }
        public rab(string fio, decimal salary)
        {
            Fio = fio;
            oklad = salary;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Работник: ФИО = {Fio}, зарплата =  {oklad}руб.");
        }
        public virtual decimal getsalary()
        {
            return oklad;
        }
    }
}

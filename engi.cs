using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class engi : rab
    {
        public string Specialty { get; set; }
        public engi(string fio, decimal salary, string specialty) : base(fio, salary)
        {
            Specialty = specialty;
        }
        public override void Show()
        {
            Console.WriteLine($"Инженер: ФИО = {Fio}, зарплата = {getsalary()}руб.");
        }
    }
}

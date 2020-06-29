using System;
using System.Text;
using Tugas9.ClassInduk;

namespace Tugas9.ClassAnak
{
    public class Sales : Karyawan
    {
        public double Sales_amount { get; set; }
        public double Bonus { get; set; }
        public override double Pendapatan()
        {
            return Sales_amount * Bonus;
        }
    }
}
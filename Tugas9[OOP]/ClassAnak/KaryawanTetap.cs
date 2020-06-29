using System;
using System.Text;
using Tugas9.ClassInduk;

namespace Tugas9.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double Income { get; set; }
        public override double Pendapatan()
        {
            return Income;
        }
    }
}
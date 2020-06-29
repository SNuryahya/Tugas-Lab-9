﻿using System;
using System.Text;
using Tugas9.ClassInduk;

namespace Tugas9.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double Number_of_hours_worked { get; set; }
        public double Hourly_Wages { get; set; }
        public override double Pendapatan()
        {
            return Number_of_hours_worked * Hourly_Wages;
        }
    }
}
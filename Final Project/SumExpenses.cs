using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumExpenses 
    {
        public string date;
        public string list;
        public int amountEx;
        private double sum = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenses"></param>
        public void addSumEx(double expenses)
        {
            this.sum += expenses;

        }
        public double getSumEx() { return sum; }
        public void deleteSumEx(double expenses)
        {
            this.sum -= expenses;   
        }
        public double getDeleteSumEx() { return sum; }

    }
}


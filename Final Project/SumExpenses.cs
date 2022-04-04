using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumExpenses 
    {
        private double sum = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenses"></param>
        public void addSumEx(double expenses)
        {
            this.sum += expenses;

        }
        public double getSumEx()
        {
            return sum;
        }
    }
}


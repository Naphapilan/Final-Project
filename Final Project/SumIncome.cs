using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumIncome 
    {
        private double sum = 0;
        //private double income = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        public void addSumIn(double income)
        {
            this.sum += income;

        }
        public double getSumIn()
        {
            return sum;
        }
    }
}

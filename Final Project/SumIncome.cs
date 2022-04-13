using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumIncome : DataIncome
    {
        public string date;
        public string list;
        public int amountIn;
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
        public double getSumIn() { return sum; }      
        public void deleteSumIn(double income)
        {
            this.sum -= income;
        }
        public double getDeleteSumIn() { return sum; }
    }
}

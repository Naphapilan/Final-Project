using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumIncome 
    {
        private string date;
        private string listmin = string.Empty;
        private string listmax = string.Empty;
        private int amountin;
        private double max = 0 ;
        private double min = 10000 ;
        private double sum = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        /// <param name="list"></param>
        public void addSumIn(double income,string list)
        {
            this.sum += income;
            if (this.min > income)
            {
                this.min = income;
                this.listmin = list;
            }
            if (this.max < income)
            {
                this.max = income;
                this.listmax = list;
            }
        }

        public double getSumIn() { return sum; }    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="income"></param>
        /// <param name="list"></param>
        public void deleteSumIn(double income,string list)
        {
            this.sum -= income;
            if (this.min > income)
            {
                this.min = income;
                this.listmin = list;
            }
            if (this.max < income)
            {
                this.max = income;
                this.listmax = list;
            }
        }
        public double getDeleteSumIn() { return sum; }
        public double getMin() { return min; }
        public double getMax() { return max; }
        public string getListMin() { return listmin; }
        public string getListMax() { return listmax; } 
    }
}

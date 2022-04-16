using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumExpenses : SumIncome
    {
        private string date;
        private string listmin = string.Empty;
        private string listmax = string.Empty;
        private int amountEx;
        private double max = 0;
        private double min = 10000;
        private double sum = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenses"></param>
        /// <param name="list"></param>
        public void addSumEx(double expenses,string list)
        {
            this.sum += expenses;

            if(this.min >= expenses)
            {
                this.min = expenses;
                this.listmin = list;
            }
            if(this.max <= expenses)
            {
                this.max = expenses;
                this.listmax = list;
            }
        }
        public double getSumEx() { return sum; }
        public void deleteSumEx(double expenses,string list)
        {
            this.sum -= expenses;   
        }
        public double getDeleteSumEx() { return sum; }
        public double getMin() { return min; }
        public double getMax() { return max; }
        public string getListMin() { return listmin; }
        public string getListMax() { return listmax; }
    }
}
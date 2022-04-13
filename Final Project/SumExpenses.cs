using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class SumExpenses 
    {
        private string date;
        private string list = string.Empty;
        private int amountEx;
        private double max = 0;
        private double min = 0;
        private double sum = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expenses"></param>
        /// <param name="list"></param>
        public void addSumEx(double expenses,string list)
        {
            this.sum += expenses;

            if(this.min < expenses)
            {
                this.min = expenses;
                this.list = list;
            }
            if(this.max < expenses)
            {
                this.max = expenses;
                this.list = list;
            }

        }
        public double getSumEx() { return sum; }
        public void deleteSumEx(double expenses)
        {
            this.sum -= expenses;   
        }
        public double getDeleteSumEx() { return sum; }

        public double getMax() { return max; }
        public double getMin() { return min; }
        public string getListMin() { return list; }
        public string getListMax() { return list; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400055
{
    internal class Transfer
    {
        public double threshold
        {
            get; set; 
        }

        public double low_fee
        {
            get; set; 
        }

        public double high_fee
        {
            get; set; 
        }

        public Transfer()
        {

        }

        public Transfer(double threshold, double low_fee, double high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}

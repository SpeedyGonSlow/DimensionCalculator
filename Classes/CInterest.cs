using System;

namespace DimensionCalculator.Classes {
    class CInterest {

        public decimal startAmount;
        public decimal endAmount;
        public double interestRate;
        public int timesCompounded;
        public int period;

        public CInterest() {

        }

        public void SetstartAmount(decimal startAmount) {
            this.startAmount = startAmount;
        }

        public decimal GetstartAmount() {
            return startAmount;
        }

        public void SetendAmount(decimal endAmount) {
            this.endAmount = endAmount;
        }

        public decimal GetendAmount() {
            return startAmount;
        }

        public void SetinterestRate(double interestRate) {
            this.interestRate = interestRate;
        }

        public double GetinterestRate() {
            return interestRate;
        }

        public void SettimesCompounded(int timesCompounded) {
            this.timesCompounded = timesCompounded;
        }

        public int GettimesCompounded() {
            return timesCompounded;
        }

        public void Setperiod(int period) {
            this.period = period;
        }

        public int Getperiod() {
            return period;
        }

        public decimal CalculateInterest(decimal startAmount, double interestRate, int timesCompounded, int period) {
            this.startAmount = startAmount;
            this.interestRate = interestRate;
            this.timesCompounded = timesCompounded;
            this.period = period;

            double tmp1 = 1 + (this.interestRate / (100 * this.timesCompounded));
            double tmp2 = this.timesCompounded * this.period;
            double tmp3 = Math.Pow(tmp1, tmp2);

            endAmount = this.startAmount * (decimal)tmp3;

            return endAmount;
        }

        public decimal CalculateInterest(decimal startAmount, double interestRate, int timesCompounded) {
            this.startAmount = startAmount;
            this.interestRate = interestRate;
            this.timesCompounded = timesCompounded;

            double tmp1 = 1 + (this.interestRate / (100 * this.timesCompounded));
            double tmp2 = this.timesCompounded;
            double tmp3 = Math.Pow(tmp1, tmp2);

            endAmount = this.startAmount * (decimal)tmp3;

            return endAmount;
        }
    }
}

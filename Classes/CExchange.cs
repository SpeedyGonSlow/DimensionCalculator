namespace DimensionCalculator.Classes {
    class CExchange {

        public string upTxtblck = "";
        public string downTxtblck = "";

        public CExchange() {

        }

        public string GetUpTxtblckValue() {
            return upTxtblck;
        }

        public string GetDownTxtblckValue() {
            return downTxtblck;
        }

        // Method for corvertion of currencies
        public decimal CurrencyConversion(double amount, int indexOfCmboxUp, int indexOfCmboxDown) {
            double convertedAmount = 0;

            switch (indexOfCmboxDown) {  // All possible options tested
                case 0:
                    downTxtblck = "CNY";
                    switch (indexOfCmboxUp) {
                        case 0:
                            upTxtblck = "CNY";
                            convertedAmount = amount;
                            break;
                        case 1:
                            upTxtblck = "EUR";
                            convertedAmount = amount * 7.85;
                            break;
                        case 2:
                            upTxtblck = "ZAR";
                            convertedAmount = amount * 0.53;
                            break;
                        case 3:
                            upTxtblck = "USD";
                            convertedAmount = amount * 6.32;
                            break;
                    }
                    break;
                case 1:
                    downTxtblck = "EUR";
                    switch (indexOfCmboxUp) {
                        case 0:
                            upTxtblck = "CNY";
                            convertedAmount = amount * 0.13;
                            break;
                        case 1:
                            upTxtblck = "EUR";
                            convertedAmount = amount;
                            break;
                        case 2:
                            upTxtblck = "ZAR";
                            convertedAmount = amount * 0.068;
                            break;
                        case 3:
                            upTxtblck = "USD";
                            convertedAmount = amount * 0.81;
                            break;
                    }
                    break;
                case 2:
                    downTxtblck = "ZAR";
                    switch (indexOfCmboxUp) {
                        case 0:
                            upTxtblck = "CNY";
                            convertedAmount = amount * 1.88;
                            break;
                        case 1:
                            upTxtblck = "EUR";
                            convertedAmount = amount * 14.74;
                            break;
                        case 2:
                            upTxtblck = "ZAR";
                            convertedAmount = amount;
                            break;
                        case 3:
                            upTxtblck = "USD";
                            convertedAmount = amount * 11.87;
                            break;
                    }
                    break;
                case 3:
                    downTxtblck = "USD";
                    switch (indexOfCmboxUp) {
                        case 0:
                            upTxtblck = "CNY";
                            convertedAmount = amount * 0.16;
                            break;
                        case 1:
                            upTxtblck = "EUR";
                            convertedAmount = amount * 1.24;
                            break;
                        case 2:
                            upTxtblck = "ZAR";
                            convertedAmount = amount * 0.084;
                            break;
                        case 3:
                            upTxtblck = "USD";
                            convertedAmount = amount;
                            break;
                    }
                    break;
            }
            // return value
            return (decimal)convertedAmount;
        }
    }
}

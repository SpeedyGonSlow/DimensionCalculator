using DimensionCalculator.Classes;
using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class InterestGUI : Page {
        public InterestGUI() {
            this.InitializeComponent();
        }

        // My Viarables
        private string sstartAmount = "";
        private string sinterestRate = "";
        private string speriod = "";
        private string lastActive = "Top";

        // My class object
        CInterest cInterestClass = new CInterest();

        private async void BtnCalculateInterest_Click(object sender, RoutedEventArgs e) {
            string tmp = TxtBxPeriod.Text;
            int period = 1;
            if ((tmp.Equals("")) || (tmp.Equals(null))) {  // if period was filled in
                period = 1;
            } else {
                period = int.Parse(speriod);
            }
            try {
                decimal startAmount = decimal.Parse(sstartAmount);
                double interestRate = double.Parse(sinterestRate);
                int cmboxIndex = CmbBxTimesCompounded.SelectedIndex;
                int timesCompounded = 0;

                switch (cmboxIndex) {  // combobox selection
                    case 0:
                        ContentDialog errorNumberDialog = new ContentDialog {
                            Title = "Error Input!",
                            Content = "Please select Compound Rate!",
                            Foreground = new SolidColorBrush(Colors.Red),
                            CloseButtonText = "OK"
                        };
                        await errorNumberDialog.ShowAsync();
                        break;
                    case 1:
                        timesCompounded = 365;
                        break;
                    case 2:
                        timesCompounded = 52;
                        break;
                    case 3:
                        timesCompounded = 12;
                        break;
                    case 4:
                        timesCompounded = 4;
                        break;
                    case 5:
                        timesCompounded = 2;
                        break;
                    case 6:
                        timesCompounded = 1;
                        break;
                }

                if (cmboxIndex != 0) { // error checking
                    if (period == 1) {
                        TxtBxEndAmount.Text = "R " + Math.Round(cInterestClass.CalculateInterest(startAmount, interestRate, timesCompounded), 2);
                    } else {
                        TxtBxEndAmount.Text = "R " + Math.Round(cInterestClass.CalculateInterest(startAmount, interestRate, timesCompounded, period), 2);
                    }
                }

            } catch (FormatException) { // Number input Exception
                ContentDialog errorNumberDialog = new ContentDialog {
                    Title = "Error Input!",
                    Content = "Please input numbers!",
                    Foreground = new SolidColorBrush(Colors.Red),
                    CloseButtonText = "OK"
                };
                await errorNumberDialog.ShowAsync();
            }
        }

        private void KeypressedReturn(string tmpressed) {
            if (lastActive.Equals("Top")) {
                sstartAmount += tmpressed;
                TxtBxStartAmout.Text = "R " + sstartAmount;
            } else if (lastActive.Equals("Middle")) {
                sinterestRate += tmpressed;
                TxtBxInterestRate.Text = sinterestRate + " %";
            } else if (lastActive.Equals("Bottom")) {
                speriod += tmpressed;
                TxtBxPeriod.Text = speriod + " years";
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn(",");
        }

        private void AllClear_Click(object sender, RoutedEventArgs e) {
            TxtBxStartAmout.Text = "";
            TxtBxPeriod.Text = "";
            TxtBxInterestRate.Text = "";
            TxtBxEndAmount.Text = "";
            CmbBxTimesCompounded.SelectedIndex = 0;
            sstartAmount = "";
            sinterestRate = "";
            speriod = "";
        }

        private void Backspace_Click(object sender, RoutedEventArgs e) {
            if (lastActive.Equals("Top")) {
                if (sstartAmount.Length != 0) {
                    sstartAmount = sstartAmount.Remove(sstartAmount.Length - 1);
                    TxtBxStartAmout.Text = "R " + sstartAmount;
                }
            } else if (lastActive.Equals("Middle")) {
                if (sinterestRate.Length != 0) {
                    sinterestRate = sinterestRate.Remove(sinterestRate.Length - 1);
                    TxtBxInterestRate.Text = sinterestRate + " %";
                }
            } else if (lastActive.Equals("Bottom")) {
                if (speriod.Length != 0) {
                    speriod = speriod.Remove(speriod.Length - 1);
                    TxtBxPeriod.Text = speriod + " years";
                }
            }
        }

        private void NumTrZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("000");
        }

        private void NumSeven_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("7");
        }

        private void NumEight_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("8");
        }

        private void NumNine_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("9");
        }

        private void NumDuZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("00");
        }

        private void NumFour_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("4");
        }

        private void NumFive_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("5");
        }

        private void NumSix_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("6");
        }

        private void NumZero_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("0");
        }

        private void NumOne_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("1");
        }

        private void NumTwo_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("2");
        }

        private void NumThree_Click(object sender, RoutedEventArgs e) {
            KeypressedReturn("3");
        }

        private void TxtBxStartAmout_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Top";
        }

        private void TxtBxInterestRate_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Middle";
        }

        private void TxtBxPeriod_PointerEntered(object sender, PointerRoutedEventArgs e) {
            lastActive = "Bottom";
        }
    }
}

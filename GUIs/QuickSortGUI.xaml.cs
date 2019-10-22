using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class QuickSortGUI : Page {
        public QuickSortGUI() {
            this.InitializeComponent();
        }

        // My Viarables
        double[] mynumberarray = new double[40];

        // Displays all values in textboxes
        private void DisplayNumbers() {
            TxtBx1.Text = mynumberarray[0] + "";
            TxtBx2.Text = mynumberarray[1] + "";
            TxtBx3.Text = mynumberarray[2] + "";
            TxtBx4.Text = mynumberarray[3] + "";
            TxtBx5.Text = mynumberarray[4] + "";
            TxtBx6.Text = mynumberarray[5] + "";
            TxtBx7.Text = mynumberarray[6] + "";
            TxtBx8.Text = mynumberarray[7] + "";
            TxtBx9.Text = mynumberarray[8] + "";
            TxtBx10.Text = mynumberarray[9] + "";
            TxtBx11.Text = mynumberarray[10] + "";
            TxtBx12.Text = mynumberarray[11] + "";
            TxtBx13.Text = mynumberarray[12] + "";
            TxtBx14.Text = mynumberarray[13] + "";
            TxtBx15.Text = mynumberarray[14] + "";
            TxtBx16.Text = mynumberarray[15] + "";
            TxtBx17.Text = mynumberarray[16] + "";
            TxtBx18.Text = mynumberarray[17] + "";
            TxtBx19.Text = mynumberarray[18] + "";
            TxtBx20.Text = mynumberarray[19] + "";
            TxtBx21.Text = mynumberarray[20] + "";
            TxtBx22.Text = mynumberarray[21] + "";
            TxtBx23.Text = mynumberarray[22] + "";
            TxtBx24.Text = mynumberarray[23] + "";
            TxtBx25.Text = mynumberarray[24] + "";
            TxtBx26.Text = mynumberarray[25] + "";
            TxtBx27.Text = mynumberarray[26] + "";
            TxtBx28.Text = mynumberarray[27] + "";
            TxtBx29.Text = mynumberarray[28] + "";
            TxtBx30.Text = mynumberarray[29] + "";
            TxtBx31.Text = mynumberarray[30] + "";
            TxtBx32.Text = mynumberarray[31] + "";
            TxtBx33.Text = mynumberarray[32] + "";
            TxtBx34.Text = mynumberarray[33] + "";
            TxtBx35.Text = mynumberarray[34] + "";
            TxtBx36.Text = mynumberarray[35] + "";
            TxtBx37.Text = mynumberarray[36] + "";
            TxtBx38.Text = mynumberarray[37] + "";
            TxtBx39.Text = mynumberarray[38] + "";
            TxtBx40.Text = mynumberarray[39] + "";
        }

        // Quick sort method
        public void Quicksort(int left, int right) {
            int i = left, j = right;
            double pivot = mynumberarray[(left + right) / 2];

            while (i <= j) {
                while (mynumberarray[i].CompareTo(pivot) < 0) {
                    i++;
                }

                while (mynumberarray[j].CompareTo(pivot) > 0) {
                    j--;
                }

                if (i <= j) {
                    // Swap
                    double tmp = mynumberarray[i];
                    mynumberarray[i] = mynumberarray[j];
                    mynumberarray[j] = tmp;
                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j) {
                Quicksort(left, j);
            }
            if (i < right) {
                Quicksort(i, right);
            }
        }

        // Generate random numbers and fill array
        private async void BtnGenerate_Click(object sender, RoutedEventArgs e) {
            try {
                int beginnumber = int.Parse(TxtBxBegin.Text);
                int endnumber = int.Parse(TxtBxEnd.Text);

                Random rnd = new Random();
                for (int i = 0; i < mynumberarray.Length; i++) {
                    mynumberarray[i] = rnd.Next(beginnumber, endnumber);
                }
                DisplayNumbers();
            } catch (FormatException) {     // Number input Exception
                ContentDialog errorNumberDialog = new ContentDialog {
                    Title = "Error Input!",
                    Content = "Please input Numbers!",
                    Foreground = new SolidColorBrush(Colors.Red),
                    CloseButtonText = "OK"
                };
                await errorNumberDialog.ShowAsync();
            }
        }

        // User decides between ascending and descending
        private void BtnSort_Click(object sender, RoutedEventArgs e) {
            Quicksort(0, mynumberarray.Length - 1);
            DisplayNumbers();
        }

        // Clear all textboxes
        private void BtnClear_Click(object sender, RoutedEventArgs e) {
            TxtBx1.Text = "";
            TxtBx2.Text = "";
            TxtBx3.Text = "";
            TxtBx4.Text = "";
            TxtBx5.Text = "";
            TxtBx6.Text = "";
            TxtBx7.Text = "";
            TxtBx8.Text = "";
            TxtBx9.Text = "";
            TxtBx10.Text = "";
            TxtBx11.Text = "";
            TxtBx12.Text = "";
            TxtBx13.Text = "";
            TxtBx14.Text = "";
            TxtBx15.Text = "";
            TxtBx16.Text = "";
            TxtBx17.Text = "";
            TxtBx18.Text = "";
            TxtBx19.Text = "";
            TxtBx20.Text = "";
            TxtBx21.Text = "";
            TxtBx22.Text = "";
            TxtBx23.Text = "";
            TxtBx24.Text = "";
            TxtBx25.Text = "";
            TxtBx26.Text = "";
            TxtBx27.Text = "";
            TxtBx28.Text = "";
            TxtBx29.Text = "";
            TxtBx30.Text = "";
            TxtBx31.Text = "";
            TxtBx32.Text = "";
            TxtBx33.Text = "";
            TxtBx34.Text = "";
            TxtBx35.Text = "";
            TxtBx36.Text = "";
            TxtBx37.Text = "";
            TxtBx38.Text = "";
            TxtBx39.Text = "";
            TxtBx40.Text = "";
        }

        // Accepts user iput numbers into array
        private async void BtnProcessInput_Click(object sender, RoutedEventArgs e) {
            try {
                mynumberarray[0] = double.Parse(TxtBx1.Text);
                mynumberarray[1] = double.Parse(TxtBx2.Text);
                mynumberarray[2] = double.Parse(TxtBx3.Text);
                mynumberarray[3] = double.Parse(TxtBx4.Text);
                mynumberarray[4] = double.Parse(TxtBx5.Text);
                mynumberarray[5] = double.Parse(TxtBx6.Text);
                mynumberarray[6] = double.Parse(TxtBx7.Text);
                mynumberarray[7] = double.Parse(TxtBx8.Text);
                mynumberarray[8] = double.Parse(TxtBx9.Text);
                mynumberarray[9] = double.Parse(TxtBx10.Text);
                mynumberarray[10] = double.Parse(TxtBx11.Text);
                mynumberarray[11] = double.Parse(TxtBx12.Text);
                mynumberarray[12] = double.Parse(TxtBx13.Text);
                mynumberarray[13] = double.Parse(TxtBx14.Text);
                mynumberarray[14] = double.Parse(TxtBx15.Text);
                mynumberarray[15] = double.Parse(TxtBx16.Text);
                mynumberarray[16] = double.Parse(TxtBx17.Text);
                mynumberarray[17] = double.Parse(TxtBx18.Text);
                mynumberarray[18] = double.Parse(TxtBx19.Text);
                mynumberarray[19] = double.Parse(TxtBx20.Text);
                mynumberarray[20] = double.Parse(TxtBx21.Text);
                mynumberarray[21] = double.Parse(TxtBx22.Text);
                mynumberarray[22] = double.Parse(TxtBx23.Text);
                mynumberarray[23] = double.Parse(TxtBx24.Text);
                mynumberarray[24] = double.Parse(TxtBx25.Text);
                mynumberarray[25] = double.Parse(TxtBx26.Text);
                mynumberarray[26] = double.Parse(TxtBx27.Text);
                mynumberarray[27] = double.Parse(TxtBx28.Text);
                mynumberarray[28] = double.Parse(TxtBx29.Text);
                mynumberarray[29] = double.Parse(TxtBx30.Text);
                mynumberarray[30] = double.Parse(TxtBx31.Text);
                mynumberarray[31] = double.Parse(TxtBx32.Text);
                mynumberarray[32] = double.Parse(TxtBx33.Text);
                mynumberarray[33] = double.Parse(TxtBx34.Text);
                mynumberarray[34] = double.Parse(TxtBx35.Text);
                mynumberarray[35] = double.Parse(TxtBx36.Text);
                mynumberarray[36] = double.Parse(TxtBx37.Text);
                mynumberarray[37] = double.Parse(TxtBx38.Text);
                mynumberarray[38] = double.Parse(TxtBx39.Text);
                mynumberarray[39] = double.Parse(TxtBx40.Text);

                ContentDialog ProcessDialog = new ContentDialog {
                    Title = "Process Completed",
                    Content = "All numbers were successfully added to the list",
                    CloseButtonText = "OK"
                };
                await ProcessDialog.ShowAsync();
            } catch (FormatException) {      // Number input Exception
                ContentDialog errorNumberDialog = new ContentDialog {
                    Title = "Error Input!",
                    Content = "Please input Numbers!",
                    Foreground = new SolidColorBrush(Colors.Red),
                    CloseButtonText = "OK"
                };
                await errorNumberDialog.ShowAsync();
            }
        }
    }
}

using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator.GUIs {
    public sealed partial class BubbleSortGUI : Page {
        public BubbleSortGUI() {
            this.InitializeComponent();
        }

        // My Viarables
        double[] mynumberarray = new double[20];

        // Display all number currently in array
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
        }

        // Sort the array -> ascending
        private void SortArray(string indicator) {
            if (indicator.Equals("ascending")) {
                for (int i = 0; i < mynumberarray.Length; i++) {
                    for (int j = 0; j < mynumberarray.Length - 1; j++) {
                        if (mynumberarray[j] > mynumberarray[j + 1]) {
                            double tmp = mynumberarray[j];
                            mynumberarray[j] = mynumberarray[j + 1];
                            mynumberarray[j + 1] = tmp;
                        }
                    }
                }
            // Sort the array -> descending
            } else if (indicator.Equals("descending")) {
                for (int i = 0; i < mynumberarray.Length; i++) {
                    for (int j = 0; j < mynumberarray.Length - 1; j++) {
                        if (mynumberarray[j] < mynumberarray[j + 1]) {
                            double tmp = mynumberarray[j];
                            mynumberarray[j] = mynumberarray[j + 1];
                            mynumberarray[j + 1] = tmp;
                        }
                    }
                }
            }
        }

        // Generate random number in array
        private async void BtnGenerate_Click(object sender, RoutedEventArgs e) {
            try {
                int beginnumber = int.Parse(TxtBxBegin.Text);
                int endnumber = int.Parse(TxtBxEnd.Text);

                Random rnd = new Random();
                for (int i = 0; i < mynumberarray.Length; i++) {
                    mynumberarray[i] = rnd.Next(beginnumber, endnumber);
                }
                DisplayNumbers();
            } catch (FormatException) { // Exception of just number as input
                ContentDialog errorNumberDialog = new ContentDialog {
                    Title = "Error Input!",
                    Content = "Please input Numbers!",
                    Foreground = new SolidColorBrush(Colors.Red),
                    CloseButtonText = "OK"
                };
                await errorNumberDialog.ShowAsync();
            }
        }

        private async void BtnSort_Click(object sender, RoutedEventArgs e) {
            ContentDialog sortdialog = new ContentDialog {
                Title = "How do you want to Sort the List?",
                Content = "Please select the option you want the List to be Sorted by.",
                PrimaryButtonText = "Ascending",
                CloseButtonText = "Descending"
            };

            ContentDialogResult result = await sortdialog.ShowAsync();

            // User decides how to sort the array
            if (result == ContentDialogResult.Primary) {
                string indicator = "ascending";
                SortArray(indicator);
                DisplayNumbers();
            } else {
                string indicator = "descending";
                SortArray(indicator);
                DisplayNumbers();
            }
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
        }

        // User entered values are used to fill array
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

                // when done with process.. display dialog to inform
                ContentDialog ProcessDialog = new ContentDialog {
                    Title = "Process Completed",
                    Content = "All numbers were successfully added to the list",
                    CloseButtonText = "OK"
                };
                await ProcessDialog.ShowAsync();
            } catch (FormatException) {  // Exception of just number as input
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

using Syncfusion.Maui.Buttons;

namespace RadioButtonPaymentOption
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PaymentOption_Selected(object sender, StateChangedEventArgs e)
        {
            if (upi_Grid == null || !(sender as SfRadioButton).IsChecked)
                return;

            string text = (sender as SfRadioButton).Text;

            switch (text)
            {
                case "UPI":
                    upi_Grid.IsVisible = true;
                    cards_Grid.IsVisible = false;
                    banking_Grid.IsVisible = false;
                    cash_Grid.IsVisible = false;
                    break;

                case "Credit/Debit/ATM Card":
                    cards_Grid.IsVisible = true;
                    upi_Grid.IsVisible = false;
                    banking_Grid.IsVisible = false;
                    cash_Grid.IsVisible = false;
                    break;

                case "Net Banking":
                    banking_Grid.IsVisible = true;
                    upi_Grid.IsVisible = false;
                    cards_Grid.IsVisible = false;
                    cash_Grid.IsVisible = false;
                    break;

                case "Cash on Delivery":
                    cash_Grid.IsVisible = true;
                    upi_Grid.IsVisible = false;
                    cards_Grid.IsVisible = false;
                    banking_Grid.IsVisible = false;
                    break;

            }
        }
    }

}

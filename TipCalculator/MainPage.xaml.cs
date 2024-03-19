using TipCalculator;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }

        private void OnButton15Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 15;
        }

        private void OnButton20Clicked(object sender, EventArgs e)
        {
            SliderTipPercent.Value = 20;
        }

        private void ButtonRoundDownClicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Floor(result);
            double amount = double.Parse(ValueEntry.Text);
            double valueTotal = roundedResult + amount;

            LabelTipValue.Text = result.ToString();
            LabelTotalValue.Text = valueTotal.ToString();
        }

        private void ButtonRoundUpClicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundedResult = Math.Ceiling(result);
            double amount = double.Parse(ValueEntry.Text);
            double valueTotal = roundedResult + amount;


            LabelTipValue.Text = result.ToString();
            LabelTotalValue.Text = valueTotal.ToString();
        }
        private double CalculateTip()
        {
            double amount = double.Parse(ValueEntry.Text);
            //double amount = Convert.ToDouble(ValueEntry.Text.ToString());
            double percent = SliderTipPercent.Value;

            double result = amount * (percent / 100); //calculo da gorjeta
            return result;




            //Programar uma funcção que calcula
            //preciso recebe o valor do pedido digitado pelo usuario
            //receber o valor da porcentagem para calcular a gorjeta
            //realaizar o calculo da gorjeta considerando o tipo do up or down
        }

        private void SliderTipPercent_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            LabelPercentValue.Text = Math.Round(SliderTipPercent.Value).ToString();
            LabelPercentValue.Text += "%";
        }
    }
}

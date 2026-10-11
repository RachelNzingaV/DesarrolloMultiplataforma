
namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out double peso) ||
                !double.TryParse(txtAltura.Text, out double altura) ||
                peso <= 0 || altura <= 0)
            {
                await DisplayAlert(
                    "Error",
                    "Introduce un peso y una altura validos mayores que cero.",
                    "Aceptar");
                return;
            }

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Delgado)";
                imgEstado.Source = "bajopeso.png";
            }
            else if (imc < 25)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Normal)";
                imgEstado.Source = "pesosaludable.png";
            }
            else if (imc < 30)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Sobrepeso)";
                imgEstado.Source = "sobrepeso.png";
            }
            else
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Obesidad)";
                imgEstado.Source = "obesidadsevera.png";
            }
        }
    }
}


namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {

            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);


            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Delgado)";
                imgEstado.Source = "BajoPeso.png";
            }
            else if (imc <= 24.9)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Normal)";
                imgEstado.Source = "PesoSaludable.png";
            }
            else if (imc <= 29.9)
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Sobrepeso)";
                imgEstado.Source = "sobrePeso.png";
            }
            else
            {
                lblResultado.Text = "Tu IMC es " + imc.ToString("F2") + " (Obesidad)";
                imgEstado.Source = "ObesidadSevera.png";
            }
        }
    }
}
namespace ControlAreaVolumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Captando los valores
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);
            //Realizando los c·lculos
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) *altura;

            //Mostarndp resultado
            txtResultado.Text = "** Resumen de Volumen y ¡reas **";
            txtResultado.Text += "\r\nValor de la altura =" + altura.ToString("0.0");
            txtResultado.Text += "\r\nValor del diametro =" + diametro.ToString("0.0");
            txtResultado.Text += "\r\n------------------------";
            txtResultado.Text += "\r\nRadio=" + radio.ToString("0.0");
            txtResultado.Text += "\r\n¡rea=" + area.ToString("0.0");
            txtResultado.Text += "\r\nVolumen=" + volumen.ToString("0.0");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtResultado.Clear();
            txtAltura.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Seguro que desea sali?" ,  "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
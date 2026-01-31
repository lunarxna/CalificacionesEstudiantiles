namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            txtPromedio.Text = promedio.ToString();
            txtPromedioIni.Text = promedio.ToString();

            if (promedio >= 70)
            {
                txtEstado.Text = "Aprobado";
                txtEstado.ForeColor = Color.Green;
                txtComple.Enabled = false;
                txtExtra.Enabled = false;
                return;
            }
            else
            {
                txtComple.Enabled = true;
            }

            if (txtComple.Text == "")
                return;

            double notaComple = Convert.ToDouble(txtComple.Text);

            double notaFinalComple = (promedio * 0.50) + (notaComple * 0.50);
            txtPromedioComple.Text = notaFinalComple.ToString();


            if (notaFinalComple >= 70)
            {

                txtEstado.Text = "Aprobado por completivo";
                txtEstado.ForeColor = Color.Green;
                txtExtra.Enabled = false;
                return;
            }
            else
            {
                txtExtra.Enabled = true;
            }

            if (txtExtra.Text == "")
                return;

            double notaExtra = Convert.ToDouble(txtExtra.Text);
            double FinalExtra = (promedio * 0.30) + (notaExtra * 0.70);
            txtPromedioExtra.Text = FinalExtra.ToString();

            if (FinalExtra > 70)
            {
                txtEstado.Text = "Aprobado por extraordinario";
                txtEstado.ForeColor = Color.Green;
            }
            else
            {
                txtEstado.Text = "Reprobado";
                txtEstado.ForeColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

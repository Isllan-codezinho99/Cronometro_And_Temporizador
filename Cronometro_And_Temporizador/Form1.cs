namespace Cronometro_And_Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Cronometro_Click(object sender, EventArgs e)
        {
            Cronometro cronometro = new Cronometro();

            cronometro.Show();
            cronometro.MaximizeBox = false;
            cronometro.MinimizeBox = false;
            cronometro.ShowInTaskbar = false;
        }

        private void Temporizador_Click(object sender, EventArgs e)
        {
            Temporizador temporizador = new Temporizador();

            temporizador.Show();
            temporizador.MaximizeBox = false;
            temporizador.MinimizeBox = false;
            temporizador.ShowInTaskbar = false;
        }
    }
}

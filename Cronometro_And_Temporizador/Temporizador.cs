using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro_And_Temporizador
{
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        int tempo = 0;
        int botao = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            botao++;

            if (botao == 1)
            {               
                Temporizador_Time.Start();
                tempo = int.Parse(Temporizador_Text.Text);
            } else if (botao == 2)
            {
                Temporizador_Time.Stop();
            } else
            {
                Temporizador_Time.Start();
            }
            
        }

        private void Temporizador_Time_Tick(object sender, EventArgs e)
        {
            if (tempo > 0)
            {
                Temporizador_Text.Text = $"Faltam {tempo} segundos";
                tempo--;
            } else
            {
                Temporizador_Text.Text = "Terminado!";
                Temporizador_Time.Stop();
            }
        }
    }
}

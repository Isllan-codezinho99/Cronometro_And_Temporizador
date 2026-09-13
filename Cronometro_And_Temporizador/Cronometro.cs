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
    public partial class Cronometro : Form
    {
        public Cronometro()
        {
            InitializeComponent();
        }

        int time = 0;

        int time_escolhido = 0;

        private void Acionar_Click(object sender, EventArgs e)
        {
            time++;

            if (time == 1)
            {
                time_escolhido = int.Parse(Cronometro_text.Text);
                Timer_Cronometro.Start();

                
            }
            else if (time == 2)
            {
                Timer_Cronometro.Stop();
            } else
            {
                Timer_Cronometro.Start();
            }
        }

        int time_pa = 0;

        private void Timer_Cronometro_Tick(object sender, EventArgs e)
        {
            if (time_pa < time_escolhido)
            {
                Cronometro_text.Text = $"{time_pa} segundos";
                time_pa++;
            } else
            {
                Cronometro_text.Text = "Terminado!";
                Timer_Cronometro.Stop();
            }
        }
    }
}

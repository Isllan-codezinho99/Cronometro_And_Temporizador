namespace Cronometro_And_Temporizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Setup = new Label();
            Cronometro = new Button();
            Temporizador = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Setup
            // 
            Setup.Font = new Font("Magneto", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Setup.Location = new Point(65, 32);
            Setup.Name = "Setup";
            Setup.Size = new Size(106, 37);
            Setup.TabIndex = 0;
            Setup.Text = "Setup";
            // 
            // Cronometro
            // 
            Cronometro.Location = new Point(65, 100);
            Cronometro.Name = "Cronometro";
            Cronometro.Size = new Size(145, 66);
            Cronometro.TabIndex = 1;
            Cronometro.Text = "Cronometro";
            Cronometro.UseVisualStyleBackColor = true;
            Cronometro.Click += Cronometro_Click;
            // 
            // Temporizador
            // 
            Temporizador.Location = new Point(65, 233);
            Temporizador.Name = "Temporizador";
            Temporizador.Size = new Size(145, 66);
            Temporizador.TabIndex = 2;
            Temporizador.Text = "Temporizador";
            Temporizador.UseVisualStyleBackColor = true;
            Temporizador.Click += Temporizador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 326);
            label1.Name = "label1";
            label1.Size = new Size(109, 14);
            label1.TabIndex = 3;
            label1.Text = "Criado por Isllan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(272, 349);
            Controls.Add(label1);
            Controls.Add(Temporizador);
            Controls.Add(Cronometro);
            Controls.Add(Setup);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "SetUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Setup;
        private Button Cronometro;
        private Button Temporizador;
        private Label label1;
    }
}

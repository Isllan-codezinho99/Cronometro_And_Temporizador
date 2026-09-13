namespace Cronometro_And_Temporizador
{
    partial class Cronometro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Cronometro_text = new TextBox();
            Acionar = new Button();
            Timer_Cronometro = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Cronometro_text
            // 
            Cronometro_text.BackColor = Color.Chocolate;
            Cronometro_text.Location = new Point(12, 60);
            Cronometro_text.Multiline = true;
            Cronometro_text.Name = "Cronometro_text";
            Cronometro_text.Size = new Size(238, 37);
            Cronometro_text.TabIndex = 0;
            Cronometro_text.Text = "Digite um numero para começar o cronometro > ";
            // 
            // Acionar
            // 
            Acionar.Location = new Point(71, 190);
            Acionar.Name = "Acionar";
            Acionar.Size = new Size(119, 51);
            Acionar.TabIndex = 1;
            Acionar.Text = "Acionar";
            Acionar.UseVisualStyleBackColor = true;
            Acionar.Click += Acionar_Click;
            // 
            // Timer_Cronometro
            // 
            Timer_Cronometro.Interval = 1000;
            Timer_Cronometro.Tick += Timer_Cronometro_Tick;
            // 
            // Cronometro
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(268, 330);
            Controls.Add(Acionar);
            Controls.Add(Cronometro_text);
            Name = "Cronometro";
            Text = "Cronometro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Cronometro_text;
        private Button Acionar;
        private System.Windows.Forms.Timer Timer_Cronometro;
    }
}
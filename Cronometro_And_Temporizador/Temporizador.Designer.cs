namespace Cronometro_And_Temporizador
{
    partial class Temporizador
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
            Temporizador_Text = new TextBox();
            button1 = new Button();
            Temporizador_Time = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Temporizador_Text
            // 
            Temporizador_Text.BackColor = SystemColors.ControlDark;
            Temporizador_Text.Location = new Point(38, 50);
            Temporizador_Text.Name = "Temporizador_Text";
            Temporizador_Text.Size = new Size(177, 23);
            Temporizador_Text.TabIndex = 0;
            Temporizador_Text.Text = "Temporizador: Tempo";
            // 
            // button1
            // 
            button1.Location = new Point(54, 157);
            button1.Name = "button1";
            button1.Size = new Size(146, 62);
            button1.TabIndex = 1;
            button1.Text = "Acionar Temporizador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Temporizador_Time
            // 
            Temporizador_Time.Interval = 1000;
            Temporizador_Time.Tick += Temporizador_Time_Tick;
            // 
            // Temporizador
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(279, 361);
            Controls.Add(button1);
            Controls.Add(Temporizador_Text);
            Name = "Temporizador";
            Text = "Temporizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Temporizador_Text;
        private Button button1;
        private System.Windows.Forms.Timer Temporizador_Time;
    }
}
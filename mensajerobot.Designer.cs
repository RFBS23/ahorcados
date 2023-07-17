namespace Ahorcados
{
    partial class mensajerobot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensajerobot));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnok = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnok).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoMensaje;
            pictureBox1.Location = new Point(235, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 314);
            label1.Name = "label1";
            label1.Size = new Size(711, 20);
            label1.TabIndex = 1;
            label1.Text = "¡hola Chamo, debes elegir entre si y no, si eliges si pasaras al segundo nivel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 335);
            label2.Name = "label2";
            label2.Size = new Size(684, 20);
            label2.TabIndex = 2;
            label2.Text = "y en caso eligas que no asi como te dijo tu que no quiere regresar contigo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 355);
            label3.Name = "label3";
            label3.Size = new Size(657, 20);
            label3.TabIndex = 3;
            label3.Text = "regresaras no con ella si no a la parte donde se encuentran los niveles!";
            // 
            // btnok
            // 
            btnok.Cursor = Cursors.Hand;
            btnok.Image = Properties.Resources.ok;
            btnok.Location = new Point(325, 389);
            btnok.Name = "btnok";
            btnok.Size = new Size(142, 103);
            btnok.SizeMode = PictureBoxSizeMode.StretchImage;
            btnok.TabIndex = 4;
            btnok.TabStop = false;
            btnok.Click += btnok_Click;
            // 
            // mensajerobot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(btnok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mensajerobot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox btnok;
    }
}
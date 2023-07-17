namespace Ahorcados
{
    partial class PrimerNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerNivel));
            btnRegresar = new PictureBox();
            flFichasDeJuego = new FlowLayoutPanel();
            picAhorcados = new PictureBox();
            pictureBox2 = new PictureBox();
            flPalabra = new FlowLayoutPanel();
            lblMensaje = new Label();
            btnIniciarJuego = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAhorcados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnIniciarJuego).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Image = Properties.Resources.regresar;
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(51, 44);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 3;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // flFichasDeJuego
            // 
            flFichasDeJuego.Location = new Point(66, 147);
            flFichasDeJuego.Name = "flFichasDeJuego";
            flFichasDeJuego.Size = new Size(441, 354);
            flFichasDeJuego.TabIndex = 4;
            // 
            // picAhorcados
            // 
            picAhorcados.BackgroundImage = Properties.Resources.fondo;
            picAhorcados.BackgroundImageLayout = ImageLayout.Stretch;
            picAhorcados.Location = new Point(597, 148);
            picAhorcados.Name = "picAhorcados";
            picAhorcados.Size = new Size(382, 353);
            picAhorcados.SizeMode = PictureBoxSizeMode.StretchImage;
            picAhorcados.TabIndex = 5;
            picAhorcados.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.reintentar;
            pictureBox2.Location = new Point(81, 534);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // flPalabra
            // 
            flPalabra.Location = new Point(255, 534);
            flPalabra.Name = "flPalabra";
            flPalabra.Size = new Size(702, 134);
            flPalabra.TabIndex = 7;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.FromArgb(255, 192, 128);
            lblMensaje.Location = new Point(634, 97);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(299, 34);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "¡Asesino Lo Mataste! 😭";
            // 
            // btnIniciarJuego
            // 
            btnIniciarJuego.Cursor = Cursors.Hand;
            btnIniciarJuego.Image = Properties.Resources.iniciar;
            btnIniciarJuego.Location = new Point(93, 12);
            btnIniciarJuego.Name = "btnIniciarJuego";
            btnIniciarJuego.Size = new Size(137, 44);
            btnIniciarJuego.SizeMode = PictureBoxSizeMode.Zoom;
            btnIniciarJuego.TabIndex = 9;
            btnIniciarJuego.TabStop = false;
            btnIniciarJuego.Click += btnIniciarJuego_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(81, 97);
            label1.Name = "label1";
            label1.Size = new Size(411, 42);
            label1.TabIndex = 10;
            label1.Text = "Adivina las palabras chamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(378, 20);
            label2.Name = "label2";
            label2.Size = new Size(335, 36);
            label2.TabIndex = 12;
            label2.Text = "Personajes de Batman";
            // 
            // PrimerNivel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1040, 693);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciarJuego);
            Controls.Add(lblMensaje);
            Controls.Add(flPalabra);
            Controls.Add(pictureBox2);
            Controls.Add(picAhorcados);
            Controls.Add(flFichasDeJuego);
            Controls.Add(btnRegresar);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrimerNivel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimerNivel";
            Load += PrimerNivel_Load;
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAhorcados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnIniciarJuego).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnRegresar;
        private FlowLayoutPanel flFichasDeJuego;
        private PictureBox picAhorcados;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flPalabra;
        private Label lblMensaje;
        private PictureBox btnIniciarJuego;
        private Label label1;
        private Label label2;
    }
}
namespace Ahorcados
{
    partial class gano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gano));
            picGano = new PictureBox();
            picSi = new PictureBox();
            picNo = new PictureBox();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // picGano
            // 
            picGano.Cursor = Cursors.Hand;
            picGano.Image = Properties.Resources.gano;
            picGano.Location = new Point(95, 19);
            picGano.Name = "picGano";
            picGano.Size = new Size(476, 465);
            picGano.SizeMode = PictureBoxSizeMode.StretchImage;
            picGano.TabIndex = 0;
            picGano.TabStop = false;
            picGano.Click += picGano_Click;
            // 
            // picSi
            // 
            picSi.Cursor = Cursors.Hand;
            picSi.Image = Properties.Resources.si;
            picSi.Location = new Point(95, 517);
            picSi.Name = "picSi";
            picSi.Size = new Size(125, 78);
            picSi.SizeMode = PictureBoxSizeMode.StretchImage;
            picSi.TabIndex = 1;
            picSi.TabStop = false;
            picSi.Click += picSi_Click;
            // 
            // picNo
            // 
            picNo.Cursor = Cursors.Hand;
            picNo.Image = Properties.Resources.no;
            picNo.Location = new Point(446, 517);
            picNo.Name = "picNo";
            picNo.Size = new Size(125, 78);
            picNo.SizeMode = PictureBoxSizeMode.StretchImage;
            picNo.TabIndex = 2;
            picNo.TabStop = false;
            picNo.Click += picNo_Click;
            // 
            // logo
            // 
            logo.Cursor = Cursors.Hand;
            logo.Image = Properties.Resources.logo1;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(136, 44);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // gano
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(649, 677);
            Controls.Add(logo);
            Controls.Add(picNo);
            Controls.Add(picSi);
            Controls.Add(picGano);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "gano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ganaste";
            ((System.ComponentModel.ISupportInitialize)picGano).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picGano;
        private PictureBox picSi;
        private PictureBox picNo;
        private PictureBox logo;
    }
}
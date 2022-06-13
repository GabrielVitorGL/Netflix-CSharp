namespace Netflix
{
    partial class Load1
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
            this.lblCriandoConta = new System.Windows.Forms.Label();
            this.pctBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriandoConta
            // 
            this.lblCriandoConta.AutoSize = true;
            this.lblCriandoConta.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriandoConta.Location = new System.Drawing.Point(372, 209);
            this.lblCriandoConta.Name = "lblCriandoConta";
            this.lblCriandoConta.Size = new System.Drawing.Size(202, 39);
            this.lblCriandoConta.TabIndex = 1;
            this.lblCriandoConta.Text = "Criando Conta";
            this.lblCriandoConta.Click += new System.EventHandler(this.lblCriandoConta_Click);
            // 
            // pctBox
            // 
            this.pctBox.Image = global::Netflix.Properties.Resources.carregando;
            this.pctBox.Location = new System.Drawing.Point(410, 268);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(126, 124);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.WaitOnLoad = true;
            // 
            // Load1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 661);
            this.Controls.Add(this.lblCriandoConta);
            this.Controls.Add(this.pctBox);
            this.MaximizeBox = false;
            this.Name = "Load1";
            this.Text = "Criando Conta";
            this.Load += new System.EventHandler(this.Load1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Label lblCriandoConta;
    }
}
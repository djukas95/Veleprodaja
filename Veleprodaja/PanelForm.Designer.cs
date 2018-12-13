namespace Veleprodaja
{
    partial class PanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelForm));
            this.btnRobniPromet = new System.Windows.Forms.Button();
            this.btnDobavljaci = new System.Windows.Forms.Button();
            this.btnKupci = new System.Windows.Forms.Button();
            this.btnFinansije = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.btnMagacin = new System.Windows.Forms.Button();
            this.btnNalog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRobniPromet
            // 
            this.btnRobniPromet.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobniPromet.Location = new System.Drawing.Point(423, 138);
            this.btnRobniPromet.Name = "btnRobniPromet";
            this.btnRobniPromet.Size = new System.Drawing.Size(140, 61);
            this.btnRobniPromet.TabIndex = 0;
            this.btnRobniPromet.Text = "Robni promet";
            this.btnRobniPromet.UseVisualStyleBackColor = true;
            this.btnRobniPromet.Click += new System.EventHandler(this.btnRobniPromet_Click);
            // 
            // btnDobavljaci
            // 
            this.btnDobavljaci.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobavljaci.Location = new System.Drawing.Point(423, 253);
            this.btnDobavljaci.Name = "btnDobavljaci";
            this.btnDobavljaci.Size = new System.Drawing.Size(140, 61);
            this.btnDobavljaci.TabIndex = 1;
            this.btnDobavljaci.Text = "Dobavljači";
            this.btnDobavljaci.UseVisualStyleBackColor = true;
            // 
            // btnKupci
            // 
            this.btnKupci.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupci.Location = new System.Drawing.Point(630, 253);
            this.btnKupci.Name = "btnKupci";
            this.btnKupci.Size = new System.Drawing.Size(140, 61);
            this.btnKupci.TabIndex = 2;
            this.btnKupci.Text = "Kupci";
            this.btnKupci.UseVisualStyleBackColor = true;
            // 
            // btnFinansije
            // 
            this.btnFinansije.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinansije.Location = new System.Drawing.Point(630, 138);
            this.btnFinansije.Name = "btnFinansije";
            this.btnFinansije.Size = new System.Drawing.Size(140, 61);
            this.btnFinansije.TabIndex = 3;
            this.btnFinansije.Text = "Finansije";
            this.btnFinansije.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 508);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Veleprodaja.Properties.Resources.web_logo_BOA_1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.Location = new System.Drawing.Point(630, 410);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(139, 51);
            this.btnOdjaviSe.TabIndex = 8;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            this.btnOdjaviSe.Click += new System.EventHandler(this.btnOdjaviSe_Click);
            // 
            // btnMagacin
            // 
            this.btnMagacin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagacin.Location = new System.Drawing.Point(829, 138);
            this.btnMagacin.Name = "btnMagacin";
            this.btnMagacin.Size = new System.Drawing.Size(140, 61);
            this.btnMagacin.TabIndex = 9;
            this.btnMagacin.Text = "Magacin";
            this.btnMagacin.UseVisualStyleBackColor = true;
            // 
            // btnNalog
            // 
            this.btnNalog.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNalog.Location = new System.Drawing.Point(829, 253);
            this.btnNalog.Name = "btnNalog";
            this.btnNalog.Size = new System.Drawing.Size(140, 61);
            this.btnNalog.TabIndex = 17;
            this.btnNalog.Text = "Nalog";
            this.btnNalog.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Veleprodaja.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(977, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 36);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Veleprodaja.Properties.Resources.mini;
            this.btnMinimize.Location = new System.Drawing.Point(937, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 36);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 508);
            this.Controls.Add(this.btnNalog);
            this.Controls.Add(this.btnMagacin);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinansije);
            this.Controls.Add(this.btnKupci);
            this.Controls.Add(this.btnDobavljaci);
            this.Controls.Add(this.btnRobniPromet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRobniPromet;
        private System.Windows.Forms.Button btnDobavljaci;
        private System.Windows.Forms.Button btnKupci;
        private System.Windows.Forms.Button btnFinansije;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Button btnMagacin;
        private System.Windows.Forms.Button btnNalog;
    }
}
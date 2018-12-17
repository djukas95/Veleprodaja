namespace Veleprodaja
{
    partial class MagacinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagacinForm));
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPregledLagerListe = new System.Windows.Forms.Button();
            this.btnIzradaOtpremnica = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPregledMagacinskeKartice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Veleprodaja.Properties.Resources.mini;
            this.btnMinimize.Location = new System.Drawing.Point(1016, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 36);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Veleprodaja.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(1056, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 36);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(871, 439);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(149, 59);
            this.btnZatvori.TabIndex = 12;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // btnPregledLagerListe
            // 
            this.btnPregledLagerListe.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledLagerListe.Location = new System.Drawing.Point(333, 439);
            this.btnPregledLagerListe.Name = "btnPregledLagerListe";
            this.btnPregledLagerListe.Size = new System.Drawing.Size(149, 59);
            this.btnPregledLagerListe.TabIndex = 13;
            this.btnPregledLagerListe.Text = "Pregled lager liste";
            this.btnPregledLagerListe.UseVisualStyleBackColor = true;
            // 
            // btnIzradaOtpremnica
            // 
            this.btnIzradaOtpremnica.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzradaOtpremnica.Location = new System.Drawing.Point(65, 439);
            this.btnIzradaOtpremnica.Name = "btnIzradaOtpremnica";
            this.btnIzradaOtpremnica.Size = new System.Drawing.Size(149, 59);
            this.btnIzradaOtpremnica.TabIndex = 14;
            this.btnIzradaOtpremnica.Text = "Izrada otpremnica";
            this.btnIzradaOtpremnica.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 311);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnPregledMagacinskeKartice
            // 
            this.btnPregledMagacinskeKartice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledMagacinskeKartice.Location = new System.Drawing.Point(601, 439);
            this.btnPregledMagacinskeKartice.Name = "btnPregledMagacinskeKartice";
            this.btnPregledMagacinskeKartice.Size = new System.Drawing.Size(149, 59);
            this.btnPregledMagacinskeKartice.TabIndex = 16;
            this.btnPregledMagacinskeKartice.Text = "Pregled magacinske kartice";
            this.btnPregledMagacinskeKartice.UseVisualStyleBackColor = true;
            // 
            // MagacinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 540);
            this.Controls.Add(this.btnPregledMagacinskeKartice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzradaOtpremnica);
            this.Controls.Add(this.btnPregledLagerListe);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MagacinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagacinForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPregledLagerListe;
        private System.Windows.Forms.Button btnIzradaOtpremnica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPregledMagacinskeKartice;
    }
}
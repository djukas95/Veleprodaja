namespace Veleprodaja
{
    partial class FinansijeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinansijeForm));
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnPregledIzdatihRacuna = new System.Windows.Forms.Button();
            this.btnEvidentiranjeUplateKupca = new System.Windows.Forms.Button();
            this.btnEvidentiranjeUplateDobavljacu = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(65, 453);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(149, 59);
            this.btnIzdavanjeRacuna.TabIndex = 0;
            this.btnIzdavanjeRacuna.Text = "Izdavanje računa";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            // 
            // btnPregledIzdatihRacuna
            // 
            this.btnPregledIzdatihRacuna.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledIzdatihRacuna.Location = new System.Drawing.Point(272, 453);
            this.btnPregledIzdatihRacuna.Name = "btnPregledIzdatihRacuna";
            this.btnPregledIzdatihRacuna.Size = new System.Drawing.Size(149, 59);
            this.btnPregledIzdatihRacuna.TabIndex = 1;
            this.btnPregledIzdatihRacuna.Text = "Pregled izdatih računa";
            this.btnPregledIzdatihRacuna.UseVisualStyleBackColor = true;
            // 
            // btnEvidentiranjeUplateKupca
            // 
            this.btnEvidentiranjeUplateKupca.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvidentiranjeUplateKupca.Location = new System.Drawing.Point(479, 453);
            this.btnEvidentiranjeUplateKupca.Name = "btnEvidentiranjeUplateKupca";
            this.btnEvidentiranjeUplateKupca.Size = new System.Drawing.Size(149, 59);
            this.btnEvidentiranjeUplateKupca.TabIndex = 2;
            this.btnEvidentiranjeUplateKupca.Text = "Evidentiranje uplate kupca";
            this.btnEvidentiranjeUplateKupca.UseVisualStyleBackColor = true;
            // 
            // btnEvidentiranjeUplateDobavljacu
            // 
            this.btnEvidentiranjeUplateDobavljacu.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvidentiranjeUplateDobavljacu.Location = new System.Drawing.Point(686, 453);
            this.btnEvidentiranjeUplateDobavljacu.Name = "btnEvidentiranjeUplateDobavljacu";
            this.btnEvidentiranjeUplateDobavljacu.Size = new System.Drawing.Size(149, 59);
            this.btnEvidentiranjeUplateDobavljacu.TabIndex = 3;
            this.btnEvidentiranjeUplateDobavljacu.Text = "Evidentiranje uplate dobavljaču";
            this.btnEvidentiranjeUplateDobavljacu.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(893, 453);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(149, 59);
            this.btnZatvori.TabIndex = 6;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 311);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Veleprodaja.Properties.Resources.mini;
            this.btnMinimize.Location = new System.Drawing.Point(1016, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 36);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 9;
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
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FinansijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 540);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnEvidentiranjeUplateDobavljacu);
            this.Controls.Add(this.btnEvidentiranjeUplateKupca);
            this.Controls.Add(this.btnPregledIzdatihRacuna);
            this.Controls.Add(this.btnIzdavanjeRacuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FinansijeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinansijeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnPregledIzdatihRacuna;
        private System.Windows.Forms.Button btnEvidentiranjeUplateKupca;
        private System.Windows.Forms.Button btnEvidentiranjeUplateDobavljacu;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
    }
}
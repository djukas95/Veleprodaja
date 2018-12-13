namespace Veleprodaja
{
    partial class RobniPrometForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobniPrometForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodavanjeArtikla = new System.Windows.Forms.Button();
            this.btnNivelacijaCijena = new System.Windows.Forms.Button();
            this.btnArhivirajArtikal = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kalkulacija cijena";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDodavanjeArtikla
            // 
            this.btnDodavanjeArtikla.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodavanjeArtikla.Location = new System.Drawing.Point(259, 460);
            this.btnDodavanjeArtikla.Name = "btnDodavanjeArtikla";
            this.btnDodavanjeArtikla.Size = new System.Drawing.Size(127, 52);
            this.btnDodavanjeArtikla.TabIndex = 2;
            this.btnDodavanjeArtikla.Text = "Dodavanje artikla";
            this.btnDodavanjeArtikla.UseVisualStyleBackColor = true;
            // 
            // btnNivelacijaCijena
            // 
            this.btnNivelacijaCijena.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivelacijaCijena.Location = new System.Drawing.Point(482, 460);
            this.btnNivelacijaCijena.Name = "btnNivelacijaCijena";
            this.btnNivelacijaCijena.Size = new System.Drawing.Size(127, 52);
            this.btnNivelacijaCijena.TabIndex = 3;
            this.btnNivelacijaCijena.Text = "Nivelacija cijena";
            this.btnNivelacijaCijena.UseVisualStyleBackColor = true;
            // 
            // btnArhivirajArtikal
            // 
            this.btnArhivirajArtikal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArhivirajArtikal.Location = new System.Drawing.Point(705, 460);
            this.btnArhivirajArtikal.Name = "btnArhivirajArtikal";
            this.btnArhivirajArtikal.Size = new System.Drawing.Size(127, 52);
            this.btnArhivirajArtikal.TabIndex = 4;
            this.btnArhivirajArtikal.Text = "Arhiviraj artikal";
            this.btnArhivirajArtikal.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(928, 460);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(127, 52);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Veleprodaja.Properties.Resources.mini;
            this.btnMinimize.Location = new System.Drawing.Point(1017, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 36);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Veleprodaja.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(1057, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 36);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RobniPrometForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 540);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnArhivirajArtikal);
            this.Controls.Add(this.btnNivelacijaCijena);
            this.Controls.Add(this.btnDodavanjeArtikla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RobniPrometForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RobniPrometForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodavanjeArtikla;
        private System.Windows.Forms.Button btnNivelacijaCijena;
        private System.Windows.Forms.Button btnArhivirajArtikal;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
    }
}
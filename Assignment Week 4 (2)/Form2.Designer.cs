namespace Assignment_Week_4__2_
{
    partial class Form2
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
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtBoxTelp = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtBoxAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.btnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(241, 304);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(112, 34);
            this.btnPrevData.TabIndex = 15;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(56, 304);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(112, 34);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // txtBoxTelp
            // 
            this.txtBoxTelp.Location = new System.Drawing.Point(138, 176);
            this.txtBoxTelp.Name = "txtBoxTelp";
            this.txtBoxTelp.Size = new System.Drawing.Size(412, 31);
            this.txtBoxTelp.TabIndex = 13;
            this.txtBoxTelp.TextChanged += new System.EventHandler(this.txtBoxTelp_TextChanged);
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(46, 176);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(47, 25);
            this.lblTelp.TabIndex = 12;
            this.lblTelp.Text = "Telp:";
            // 
            // txtBoxAlamat
            // 
            this.txtBoxAlamat.Location = new System.Drawing.Point(138, 115);
            this.txtBoxAlamat.Name = "txtBoxAlamat";
            this.txtBoxAlamat.Size = new System.Drawing.Size(412, 31);
            this.txtBoxAlamat.TabIndex = 11;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(46, 115);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(72, 25);
            this.lblAlamat.TabIndex = 10;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(46, 57);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(63, 25);
            this.lblNama.TabIndex = 9;
            this.lblNama.Text = "Nama:";
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(138, 54);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(412, 31);
            this.txtBoxNama.TabIndex = 8;
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(425, 304);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(112, 34);
            this.btnNextData.TabIndex = 16;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtBoxTelp);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.txtBoxAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtBoxNama);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtBoxTelp;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.TextBox txtBoxAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.Button btnNextData;
    }
}
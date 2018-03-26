namespace aerodrom
{
    partial class AerodromForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKratenka = new System.Windows.Forms.TextBox();
            this.btnZacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProviderGrad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKratenka = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKratenka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додади аеродром";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Град";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Име:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кратенка";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(27, 52);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 20);
            this.txtGrad.TabIndex = 4;
            this.txtGrad.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrad_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(27, 105);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtKratenka
            // 
            this.txtKratenka.Location = new System.Drawing.Point(27, 156);
            this.txtKratenka.Name = "txtKratenka";
            this.txtKratenka.Size = new System.Drawing.Size(100, 20);
            this.txtKratenka.TabIndex = 6;
            this.txtKratenka.Validating += new System.ComponentModel.CancelEventHandler(this.txtKratenka_Validating);
            // 
            // btnZacuvaj
            // 
            this.btnZacuvaj.Location = new System.Drawing.Point(27, 197);
            this.btnZacuvaj.Name = "btnZacuvaj";
            this.btnZacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnZacuvaj.TabIndex = 7;
            this.btnZacuvaj.Text = "Зачувај";
            this.btnZacuvaj.UseVisualStyleBackColor = true;
            this.btnZacuvaj.Click += new System.EventHandler(this.btnZacuvaj_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(130, 196);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 8;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProviderGrad
            // 
            this.errorProviderGrad.ContainerControl = this;
            // 
            // errorProviderIme
            // 
            this.errorProviderIme.ContainerControl = this;
            // 
            // errorProviderKratenka
            // 
            this.errorProviderKratenka.ContainerControl = this;
            // 
            // AerodromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 243);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnZacuvaj);
            this.Controls.Add(this.txtKratenka);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AerodromForm";
            this.Text = "AerodromForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKratenka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKratenka;
        private System.Windows.Forms.Button btnZacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProviderGrad;
        private System.Windows.Forms.ErrorProvider errorProviderIme;
        private System.Windows.Forms.ErrorProvider errorProviderKratenka;
    }
}
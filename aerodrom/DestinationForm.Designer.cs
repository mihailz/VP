namespace aerodrom
{
    partial class DestinationForm
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
            this.txtCenaDestinacija = new System.Windows.Forms.Label();
            this.txtImeDestinacija = new System.Windows.Forms.TextBox();
            this.txtCenaDest = new System.Windows.Forms.NumericUpDown();
            this.txtDolzinaDest = new System.Windows.Forms.NumericUpDown();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProviderGrad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolzinaDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додади дестинација";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Град";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должина";
            // 
            // txtCenaDestinacija
            // 
            this.txtCenaDestinacija.AutoSize = true;
            this.txtCenaDestinacija.Location = new System.Drawing.Point(13, 148);
            this.txtCenaDestinacija.Name = "txtCenaDestinacija";
            this.txtCenaDestinacija.Size = new System.Drawing.Size(33, 13);
            this.txtCenaDestinacija.TabIndex = 3;
            this.txtCenaDestinacija.Text = "Цена";
            // 
            // txtImeDestinacija
            // 
            this.txtImeDestinacija.Location = new System.Drawing.Point(16, 51);
            this.txtImeDestinacija.Name = "txtImeDestinacija";
            this.txtImeDestinacija.Size = new System.Drawing.Size(100, 20);
            this.txtImeDestinacija.TabIndex = 4;
            this.txtImeDestinacija.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeDestinacija_Validating);
            // 
            // txtCenaDest
            // 
            this.txtCenaDest.DecimalPlaces = 2;
            this.txtCenaDest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtCenaDest.Location = new System.Drawing.Point(16, 164);
            this.txtCenaDest.Name = "txtCenaDest";
            this.txtCenaDest.Size = new System.Drawing.Size(120, 20);
            this.txtCenaDest.TabIndex = 6;
            // 
            // txtDolzinaDest
            // 
            this.txtDolzinaDest.DecimalPlaces = 2;
            this.txtDolzinaDest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtDolzinaDest.Location = new System.Drawing.Point(16, 114);
            this.txtDolzinaDest.Name = "txtDolzinaDest";
            this.txtDolzinaDest.Size = new System.Drawing.Size(120, 20);
            this.txtDolzinaDest.TabIndex = 7;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(16, 206);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 8;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(97, 206);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProviderGrad
            // 
            this.errorProviderGrad.ContainerControl = this;
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.txtDolzinaDest);
            this.Controls.Add(this.txtCenaDest);
            this.Controls.Add(this.txtImeDestinacija);
            this.Controls.Add(this.txtCenaDestinacija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtCenaDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolzinaDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCenaDestinacija;
        private System.Windows.Forms.TextBox txtImeDestinacija;
        private System.Windows.Forms.NumericUpDown txtCenaDest;
        private System.Windows.Forms.NumericUpDown txtDolzinaDest;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProviderGrad;
    }
}
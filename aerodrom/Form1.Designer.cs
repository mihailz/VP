namespace aerodrom
{
    partial class Form1
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
            this.lblAerodromi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaAerodromi = new System.Windows.Forms.ListBox();
            this.listaDestinacii = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodadiAerodrom = new System.Windows.Forms.Button();
            this.btnIzbrisiAerodrom = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNajskapa = new System.Windows.Forms.TextBox();
            this.txtProsecnaDolzina = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAerodromi
            // 
            this.lblAerodromi.AutoSize = true;
            this.lblAerodromi.Location = new System.Drawing.Point(13, 13);
            this.lblAerodromi.Name = "lblAerodromi";
            this.lblAerodromi.Size = new System.Drawing.Size(54, 13);
            this.lblAerodromi.TabIndex = 0;
            this.lblAerodromi.Text = "Aerodromi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дестинации";
            // 
            // listaAerodromi
            // 
            this.listaAerodromi.FormattingEnabled = true;
            this.listaAerodromi.Location = new System.Drawing.Point(12, 29);
            this.listaAerodromi.Name = "listaAerodromi";
            this.listaAerodromi.Size = new System.Drawing.Size(185, 225);
            this.listaAerodromi.TabIndex = 2;
            this.listaAerodromi.SelectedIndexChanged += new System.EventHandler(this.listaAerodromi_SelectedIndexChanged);
            // 
            // listaDestinacii
            // 
            this.listaDestinacii.FormattingEnabled = true;
            this.listaDestinacii.Location = new System.Drawing.Point(234, 29);
            this.listaDestinacii.Name = "listaDestinacii";
            this.listaDestinacii.Size = new System.Drawing.Size(190, 225);
            this.listaDestinacii.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDestination);
            this.groupBox1.Controls.Add(this.btnIzbrisiAerodrom);
            this.groupBox1.Controls.Add(this.btnDodadiAerodrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnDodadiAerodrom
            // 
            this.btnDodadiAerodrom.Location = new System.Drawing.Point(7, 10);
            this.btnDodadiAerodrom.Name = "btnDodadiAerodrom";
            this.btnDodadiAerodrom.Size = new System.Drawing.Size(172, 23);
            this.btnDodadiAerodrom.TabIndex = 0;
            this.btnDodadiAerodrom.Text = "Додади Аеродром";
            this.btnDodadiAerodrom.UseVisualStyleBackColor = true;
            this.btnDodadiAerodrom.Click += new System.EventHandler(this.btnDodadiAerodrom_Click);
            // 
            // btnIzbrisiAerodrom
            // 
            this.btnIzbrisiAerodrom.Location = new System.Drawing.Point(7, 40);
            this.btnIzbrisiAerodrom.Name = "btnIzbrisiAerodrom";
            this.btnIzbrisiAerodrom.Size = new System.Drawing.Size(172, 23);
            this.btnIzbrisiAerodrom.TabIndex = 1;
            this.btnIzbrisiAerodrom.Text = "Избриши аеродром";
            this.btnIzbrisiAerodrom.UseVisualStyleBackColor = true;
            this.btnIzbrisiAerodrom.Click += new System.EventHandler(this.btnIzbrisiAerodrom_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(7, 70);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(172, 23);
            this.btnAddDestination.TabIndex = 2;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProsecnaDolzina);
            this.groupBox2.Controls.Add(this.txtNajskapa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(234, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Најскапа Дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // txtNajskapa
            // 
            this.txtNajskapa.Location = new System.Drawing.Point(10, 47);
            this.txtNajskapa.Name = "txtNajskapa";
            this.txtNajskapa.Size = new System.Drawing.Size(180, 20);
            this.txtNajskapa.TabIndex = 3;
            // 
            // txtProsecnaDolzina
            // 
            this.txtProsecnaDolzina.Location = new System.Drawing.Point(10, 87);
            this.txtProsecnaDolzina.Name = "txtProsecnaDolzina";
            this.txtProsecnaDolzina.Size = new System.Drawing.Size(180, 20);
            this.txtProsecnaDolzina.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaDestinacii);
            this.Controls.Add(this.listaAerodromi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAerodromi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaAerodromi;
        private System.Windows.Forms.ListBox listaDestinacii;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Button btnIzbrisiAerodrom;
        private System.Windows.Forms.Button btnDodadiAerodrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProsecnaDolzina;
        private System.Windows.Forms.TextBox txtNajskapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}


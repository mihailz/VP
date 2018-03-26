using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace aerodrom
{
    public partial class AerodromForm : Form
    {
        public Aerodrom aerodrom { get; set; }
        public AerodromForm()
        {
            InitializeComponent();
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            aerodrom = new Aerodrom();
            aerodrom.Shourtcut = txtKratenka.Text;
            aerodrom.Name = txtIme.Text;
            aerodrom.City = txtGrad.Text;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (txtGrad.Text == "")
            {
                errorProviderGrad.SetError(txtGrad, "Внесете град!");
              
            }
           
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text == "")
            {
                errorProviderIme.SetError(txtIme, "Внесете име!");
                
            }
            
        }

        private void txtKratenka_Validating(object sender, CancelEventArgs e)
        {
            string kratenka = txtKratenka.Text;
            int counter = 0;


            counter = Regex.Matches(kratenka, @"[A-Z]").Count;

            if(counter != 3)
            {
                errorProviderKratenka.SetError(txtKratenka, "Мора да има 3 големи букви!");
               
            }
           

             
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerodrom
{
    public partial class DestinationForm : Form
    {
        public Destinations destinations { get; set; }
        public DestinationForm()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            destinations = new Destinations();
            destinations.DestinationName = txtImeDestinacija.Text;
            destinations.Distance = txtDolzinaDest.Value;
            destinations.Price = txtCenaDest.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtImeDestinacija_Validating(object sender, CancelEventArgs e)
        {
            if (txtImeDestinacija.Text == "")
            {
                errorProviderGrad.SetError(txtImeDestinacija, "Внесете име на дестинација!");
            }
        }

        public static implicit operator DestinationForm(Destinations v)
        {
            throw new NotImplementedException();
        }
    }
}

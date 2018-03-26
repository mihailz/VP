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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void loadDestination()
        {
            txtProsecnaDolzina.Clear();
            txtNajskapa.Clear();
            Aerodrom aerodrom = listaAerodromi.SelectedItem as Aerodrom;

            Destinations maxPrice = aerodrom.destinations[0];
            decimal totalDistance = 0;
            if (listaAerodromi.SelectedItems.Count > 0)
            {
               foreach(Destinations destination in aerodrom.destinations)
                {
     
                    listaDestinacii.Items.Add(destination);
                    if (destination.Price >((Destinations)maxPrice).Price)
                    {
                        maxPrice = destination;
                    }
                    totalDistance += destination.Distance;
                   
                }
                txtNajskapa.Text = maxPrice.ToString();
            }
        }

        private void btnDodadiAerodrom_Click(object sender, EventArgs e)
        {
            AerodromForm newForm = new AerodromForm();
            DialogResult rezult = newForm.ShowDialog();

            if(rezult == System.Windows.Forms.DialogResult.OK)
            {
                listaAerodromi.Items.Add(newForm.aerodrom);
            }
            
        }

        private void btnIzbrisiAerodrom_Click(object sender, EventArgs e)
        {
            YesNo yesnoForm = new YesNo();
            DialogResult rezult = yesnoForm.ShowDialog();

           
          if(rezult == System.Windows.Forms.DialogResult.OK)
            {
                if (listaAerodromi.SelectedIndex != -1)
                {
                    listaAerodromi.Items.Remove(listaAerodromi.SelectedItem);
                    
                }

            }
           
                 
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            DestinationForm newDestForm = new DestinationForm();
            DialogResult rezult = newDestForm.ShowDialog();

            if (rezult == System.Windows.Forms.DialogResult.OK)
            {
                if (listaAerodromi.SelectedItems.Count != -1)
                {
                    listaDestinacii.Items.Add(newDestForm.destinations);
                    listaAerodromi.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("Немате селектирано ставка!");
                }
            }
        }

        private void listaAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDestination();
        }
    }
}

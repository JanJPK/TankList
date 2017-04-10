using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanPajdakLab2ZadanieDomowe
{
    public partial class FormEditDescription : Form
    {
        private ArmoredVehicle vehicle;
        public FormEditDescription()
        {
            InitializeComponent();
        }

        public FormEditDescription(ArmoredVehicle sourceVehicle)
        {
            InitializeComponent();
            vehicle = sourceVehicle;
            textBoxDescription.Text = vehicle.Description;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            vehicle.Description = textBoxDescription.Text;
            SystemSounds.Asterisk.Play();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            this.Close();
        }
    }
}

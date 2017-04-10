using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanPajdakLab2ZadanieDomowe
{
    public partial class FormAddTank : Form
    {
        private List<Tank> listOfTanksAddForm;
        private Tank tank;
        private string imagePath = "";

        public FormAddTank()
        {
            InitializeComponent();
        }

        public FormAddTank(ref List<Tank> listOfTanks)
        {
            listOfTanksAddForm = listOfTanks;
            InitializeComponent();
            ComboBoxEngineTypeOptions();
            ComboBoxTankTypeOptions();
            radioButtonTracked.Checked = true;
        }

        // ComboBox contents.
        private void ComboBoxEngineTypeOptions()
        {
            comboBoxEngineType.Items.Add("Diesel");
            comboBoxEngineType.Items.Add("Benzyna");
            comboBoxEngineType.Items.Add("Turbina gazowa");
        }

        private void ComboBoxTankTypeOptions()
        {
            comboBoxTankType.Items.Add("MBT");
            comboBoxTankType.Items.Add("Light");
            comboBoxTankType.Items.Add("Heavy");
            comboBoxTankType.Items.Add("Medium");
        }


        // Are TextBoxes etc. empty?
        private bool CheckIfEmpty()
        {
            float num;
            int num2;
            if (!string.IsNullOrEmpty(textBoxDesignation.Text) && !string.IsNullOrEmpty(textBoxWeight.Text) &&
                !string.IsNullOrEmpty(textBoxHorsepower.Text) && comboBoxEngineType.SelectedItem != null &&
                !string.IsNullOrEmpty(textBoxCaliber.Text) && float.TryParse(textBoxWeight.Text, out num) && 
                int.TryParse(textBoxHorsepower.Text, out num2) && int.TryParse(textBoxCaliber.Text, out num2))
            {
                return false;
            }
            return true;

        }

        // Adding a new tank.
        private void buttonAddArmoredVehicle_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty() == false && imagePath != String.Empty)
            {
                string driveType = "Gąsienicowy";
                if (radioButtonWheeled.Checked)
                {
                    driveType = "Kołowy";
                }

                
                tank = new Tank(float.Parse(textBoxWeight.Text), driveType,
                    textBoxDesignation.Text, int.Parse(textBoxHorsepower.Text), comboBoxEngineType.Text, int.Parse(textBoxCaliber.Text), checkBoxCountermeasures.Checked, comboBoxTankType.Text);

                listOfTanksAddForm.Add(tank);
                
                moveImageToSaveFolder(imagePath);

                SystemSounds.Asterisk.Play();
                this.Close();
            }
            else
            {
                SystemSounds.Hand.Play();
            }
        }

        // Browsing for image.
        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            openFileDialogImage.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialogImage.FileName;
                pictureBoxImage.ImageLocation = openFileDialogImage.FileName;
                SystemSounds.Asterisk.Play();
            }
            else
            {
                SystemSounds.Hand.Play();
            }


        }

        // Copies chosen image to /SavedObjects/ also renames it depending on objects designation - [armoredVehicle.Designation].png
        private void moveImageToSaveFolder(string sourceFile)
        {
            string designatedPath = @"..\SavedObjects\" +
                                    tank.Designation + Path.GetExtension(imagePath);

            System.IO.File.Copy(sourceFile, designatedPath);
            tank.ImagePath = designatedPath;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            this.Close();
        }
    }
}

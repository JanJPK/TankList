using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JanPajdakLab2ZadanieDomowe
{
    public partial class FormAddArmoredVehicle : Form
    {
        private List<ArmoredVehicle> listOfArmoredVehiclesAddForm;
        private ArmoredVehicle armoredVehicle;
        private string imagePath = "";

        public FormAddArmoredVehicle()
        {
            InitializeComponent();
            ComboBoxEngineTypeOptions();
            radioButtonTracked.Checked = true;
        }

        public FormAddArmoredVehicle(ref List<ArmoredVehicle> listOfArmoredVehicles)
        {
            listOfArmoredVehiclesAddForm = listOfArmoredVehicles;
            InitializeComponent();
            ComboBoxEngineTypeOptions();
            radioButtonTracked.Checked = true;
        }

        // ComboBox contents.
        private void ComboBoxEngineTypeOptions()
        {
            comboBoxEngineType.Items.Add("Diesel");
            comboBoxEngineType.Items.Add("Benzyna");
            comboBoxEngineType.Items.Add("Turbina gazowa");
        }


        // Are TextBoxes etc. empty?
        private bool CheckIfEmpty()
        {
            float num;
            int num2;
            if (!string.IsNullOrEmpty(textBoxDesignation.Text) && !string.IsNullOrEmpty(textBoxWeight.Text) &&
                !string.IsNullOrEmpty(textBoxHorsepower.Text) && comboBoxEngineType.SelectedItem != null &&
                float.TryParse(textBoxWeight.Text, out num) && int.TryParse(textBoxHorsepower.Text, out num2))
            {
                return false;
            }
            return true;
            
        }

        // Adding a new armored vehicle.
        private void buttonAddArmoredVehicle_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty() == false && imagePath!=String.Empty)
            {
                string driveType = "Gąsienicowy";
                if (radioButtonWheeled.Checked)
                {
                    driveType = "Kołowy";
                }

                armoredVehicle = new ArmoredVehicle(float.Parse(textBoxWeight.Text), driveType,
                    textBoxDesignation.Text, int.Parse(textBoxHorsepower.Text), comboBoxEngineType.Text);

                listOfArmoredVehiclesAddForm.Add(armoredVehicle);
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
                                    armoredVehicle.Designation + Path.GetExtension(imagePath);

            System.IO.File.Copy(sourceFile, designatedPath);
            armoredVehicle.ImagePath = designatedPath;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanPajdakLab2ZadanieDomowe
{

    public partial class FormMain : Form
    {
        List<ArmoredVehicle> listOfArmoredVehicles ;
        List<Tank> listOfTanks;

        //private string SavePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\SavedObjects\";
        private string SavePath = @"..\SavedObjects";

        public FormMain()
        {
           InitializeComponent();
           listOfArmoredVehicles = new List<ArmoredVehicle>();
           listOfTanks = new List<Tank>();
           CreateFolder();
        }


        private void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(SavePath);
        }

        // ******************************** Opening object creation window ********
        private void buttonAddArmoredVehicle_Click(object sender, EventArgs e)
        {
           FormAddArmoredVehicle formAddArmoredVehicle = new FormAddArmoredVehicle(ref listOfArmoredVehicles);
           formAddArmoredVehicle.Show();

        }

        private void buttonAddTank_Click(object sender, EventArgs e)
        {
            FormAddTank formAddTank = new FormAddTank(ref listOfTanks);
            formAddTank.Show();

        }

        // ******************************** Displaying on DataGrid ********
        private void RefreshDataGridView()
        {
            dataGridViewList.DataSource = null;
        }

        private void buttonDataGridBindArmoredVehicles_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            dataGridViewList.DataSource = listOfArmoredVehicles;
            SystemSounds.Asterisk.Play();
        }

        private void buttonDataGridBindTank_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            dataGridViewList.DataSource = listOfTanks;
            SystemSounds.Asterisk.Play();
        }

        // ******************************** Saving listOfArmoredVehicles ********

        private void buttonSaveArmoredVehicle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz nadpisać plik binarny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (Stream stream = File.Open(Path.Combine(SavePath, "savedArmoredVehicles.bin"), FileMode.Create))
                {
                    var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    binFormatter.Serialize(stream, listOfArmoredVehicles);
                    SystemSounds.Asterisk.Play();
                }
            }

        }

        private void buttonLoadArmoredVehicle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wczytać plik binarny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (Stream stream = File.Open(Path.Combine(SavePath, "savedArmoredVehicles.bin"), FileMode.Open))
                {
                    var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    listOfArmoredVehicles = (List<ArmoredVehicle>)binFormatter.Deserialize(stream);
                    SystemSounds.Asterisk.Play();
                    dataGridViewList.DataSource = listOfArmoredVehicles;
                }
            }

        }

        private void buttonSaveTank_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz nadpisać plik binarny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (Stream stream = File.Open(Path.Combine(SavePath, "savedTanks.bin"), FileMode.Create))
                {
                    var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    binFormatter.Serialize(stream, listOfTanks);
                    SystemSounds.Asterisk.Play();
                }
            }

        }

        private void buttonLoadTank_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz wczytać plik binarny?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (Stream stream = File.Open(Path.Combine(SavePath, "savedTanks.bin"), FileMode.Open))
                {
                    var binFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    listOfTanks = (List<Tank>)binFormatter.Deserialize(stream);
                    SystemSounds.Asterisk.Play();
                    dataGridViewList.DataSource = listOfTanks;
                }
            }

        }

        // ******************************** Removing items from list ********
        private void buttonRemoveFromList_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć obiekt?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dataGridViewList.SelectedRows)
                {
                    if (item.Selected)
                    {
                        if (dataGridViewList.DataSource == listOfArmoredVehicles)
                        {
                            // Deleting image first.
                            System.IO.File.Delete(@"../SavedObjects/" + listOfArmoredVehicles[item.Index].ImagePath);
                            listOfArmoredVehicles.RemoveAt(item.Index);
                        }
                        else
                        {
                            System.IO.File.Delete(@"../SavedObjects/" + listOfTanks[item.Index].ImagePath);
                            listOfTanks.RemoveAt(item.Index);

                        }
                    }

                }
            }

        }

        // ******************************** Displaying image & description ********
        private void buttonShowDescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (dataGridViewList.DataSource == listOfArmoredVehicles)

                {
                    pictureBoxImage.ImageLocation =
                        listOfArmoredVehicles[dataGridViewList.SelectedRows[0].Index].ImagePath;
                    textBoxVehicleInformation.Text =
                        listOfArmoredVehicles[dataGridViewList.SelectedRows[0].Index]
                            .ArmoredVehicleInformation();
                    textBoxVehicleDescription.Text =
                        listOfArmoredVehicles[dataGridViewList.SelectedRows[0].Index].Description;

                }
                else
                {
                    pictureBoxImage.ImageLocation =
                        listOfTanks[dataGridViewList.SelectedRows[0].Index].ImagePath;
                    textBoxVehicleInformation.Text =
                        listOfTanks[dataGridViewList.SelectedRows[0].Index]
                            .TankInformation();
                    textBoxVehicleDescription.Text =
                        listOfTanks[dataGridViewList.SelectedRows[0].Index].Description;
                }
                SystemSounds.Asterisk.Play();
            }
            else
            {
                SystemSounds.Hand.Play();
            }

        }

        private void buttonEditDescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (dataGridViewList.DataSource == listOfArmoredVehicles)
                {
                    FormEditDescription editArmoredVehicle =
                        new FormEditDescription(listOfArmoredVehicles[dataGridViewList.SelectedRows[0].Index]);
                    editArmoredVehicle.Show();
                }
                else
                {
                    FormEditDescription editArmoredVehicle =
                        new FormEditDescription(listOfTanks[dataGridViewList.SelectedRows[0].Index]);
                    editArmoredVehicle.Show();
                }
                SystemSounds.Asterisk.Play();
            }
            else
            {
                SystemSounds.Hand.Play();
            }
        }


    }
}

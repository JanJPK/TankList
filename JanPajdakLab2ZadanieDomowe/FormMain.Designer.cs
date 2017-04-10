namespace JanPajdakLab2ZadanieDomowe
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonAddArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonAddTank = new System.Windows.Forms.Button();
            this.textBoxVehicleDescription = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxVehicleInformation = new System.Windows.Forms.TextBox();
            this.buttonEditDescription = new System.Windows.Forms.Button();
            this.buttonRemoveFromList = new System.Windows.Forms.Button();
            this.buttonSaveTank = new System.Windows.Forms.Button();
            this.buttonSaveArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonLoadArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonLoadTank = new System.Windows.Forms.Button();
            this.buttonShowDescription = new System.Windows.Forms.Button();
            this.buttonDataGridBindTank = new System.Windows.Forms.Button();
            this.buttonDataGridBindArmoredVehicles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(344, 12);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(428, 267);
            this.dataGridViewList.TabIndex = 0;
            // 
            // buttonAddArmoredVehicle
            // 
            this.buttonAddArmoredVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddArmoredVehicle.Location = new System.Drawing.Point(178, 12);
            this.buttonAddArmoredVehicle.Name = "buttonAddArmoredVehicle";
            this.buttonAddArmoredVehicle.Size = new System.Drawing.Size(160, 60);
            this.buttonAddArmoredVehicle.TabIndex = 1;
            this.buttonAddArmoredVehicle.Text = "Dodaj pojazd";
            this.buttonAddArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonAddArmoredVehicle.Click += new System.EventHandler(this.buttonAddArmoredVehicle_Click);
            // 
            // buttonAddTank
            // 
            this.buttonAddTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddTank.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTank.Name = "buttonAddTank";
            this.buttonAddTank.Size = new System.Drawing.Size(160, 60);
            this.buttonAddTank.TabIndex = 2;
            this.buttonAddTank.Text = "Dodaj czołg";
            this.buttonAddTank.UseVisualStyleBackColor = true;
            this.buttonAddTank.Click += new System.EventHandler(this.buttonAddTank_Click);
            // 
            // textBoxVehicleDescription
            // 
            this.textBoxVehicleDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxVehicleDescription.Location = new System.Drawing.Point(344, 285);
            this.textBoxVehicleDescription.Multiline = true;
            this.textBoxVehicleDescription.Name = "textBoxVehicleDescription";
            this.textBoxVehicleDescription.Size = new System.Drawing.Size(226, 265);
            this.textBoxVehicleDescription.TabIndex = 3;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.zielonyszum;
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Location = new System.Drawing.Point(576, 285);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(196, 138);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 4;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxVehicleInformation
            // 
            this.textBoxVehicleInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxVehicleInformation.Location = new System.Drawing.Point(576, 429);
            this.textBoxVehicleInformation.Multiline = true;
            this.textBoxVehicleInformation.Name = "textBoxVehicleInformation";
            this.textBoxVehicleInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxVehicleInformation.Size = new System.Drawing.Size(196, 121);
            this.textBoxVehicleInformation.TabIndex = 5;
            // 
            // buttonEditDescription
            // 
            this.buttonEditDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonEditDescription.Location = new System.Drawing.Point(12, 144);
            this.buttonEditDescription.Name = "buttonEditDescription";
            this.buttonEditDescription.Size = new System.Drawing.Size(160, 60);
            this.buttonEditDescription.TabIndex = 7;
            this.buttonEditDescription.Text = "Zmień opis";
            this.buttonEditDescription.UseVisualStyleBackColor = true;
            this.buttonEditDescription.Click += new System.EventHandler(this.buttonEditDescription_Click);
            // 
            // buttonRemoveFromList
            // 
            this.buttonRemoveFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRemoveFromList.Location = new System.Drawing.Point(12, 210);
            this.buttonRemoveFromList.Name = "buttonRemoveFromList";
            this.buttonRemoveFromList.Size = new System.Drawing.Size(160, 60);
            this.buttonRemoveFromList.TabIndex = 9;
            this.buttonRemoveFromList.Text = "Usuń";
            this.buttonRemoveFromList.UseVisualStyleBackColor = true;
            this.buttonRemoveFromList.Click += new System.EventHandler(this.buttonRemoveFromList_Click);
            // 
            // buttonSaveTank
            // 
            this.buttonSaveTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSaveTank.Location = new System.Drawing.Point(12, 424);
            this.buttonSaveTank.Name = "buttonSaveTank";
            this.buttonSaveTank.Size = new System.Drawing.Size(160, 60);
            this.buttonSaveTank.TabIndex = 11;
            this.buttonSaveTank.Text = "Zapisz czołgi";
            this.buttonSaveTank.UseVisualStyleBackColor = true;
            this.buttonSaveTank.Click += new System.EventHandler(this.buttonSaveTank_Click);
            // 
            // buttonSaveArmoredVehicle
            // 
            this.buttonSaveArmoredVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSaveArmoredVehicle.Location = new System.Drawing.Point(178, 424);
            this.buttonSaveArmoredVehicle.Name = "buttonSaveArmoredVehicle";
            this.buttonSaveArmoredVehicle.Size = new System.Drawing.Size(160, 60);
            this.buttonSaveArmoredVehicle.TabIndex = 10;
            this.buttonSaveArmoredVehicle.Text = "Zapisz pojazdy";
            this.buttonSaveArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonSaveArmoredVehicle.Click += new System.EventHandler(this.buttonSaveArmoredVehicle_Click);
            // 
            // buttonLoadArmoredVehicle
            // 
            this.buttonLoadArmoredVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLoadArmoredVehicle.Location = new System.Drawing.Point(178, 490);
            this.buttonLoadArmoredVehicle.Name = "buttonLoadArmoredVehicle";
            this.buttonLoadArmoredVehicle.Size = new System.Drawing.Size(160, 60);
            this.buttonLoadArmoredVehicle.TabIndex = 13;
            this.buttonLoadArmoredVehicle.Text = "Wczytaj pojazdy";
            this.buttonLoadArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonLoadArmoredVehicle.Click += new System.EventHandler(this.buttonLoadArmoredVehicle_Click);
            // 
            // buttonLoadTank
            // 
            this.buttonLoadTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLoadTank.Location = new System.Drawing.Point(12, 490);
            this.buttonLoadTank.Name = "buttonLoadTank";
            this.buttonLoadTank.Size = new System.Drawing.Size(160, 60);
            this.buttonLoadTank.TabIndex = 12;
            this.buttonLoadTank.Text = "Wczytaj czołgi";
            this.buttonLoadTank.UseVisualStyleBackColor = true;
            this.buttonLoadTank.Click += new System.EventHandler(this.buttonLoadTank_Click);
            // 
            // buttonShowDescription
            // 
            this.buttonShowDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonShowDescription.Location = new System.Drawing.Point(178, 144);
            this.buttonShowDescription.Name = "buttonShowDescription";
            this.buttonShowDescription.Size = new System.Drawing.Size(160, 60);
            this.buttonShowDescription.TabIndex = 14;
            this.buttonShowDescription.Text = "Pokaż opis";
            this.buttonShowDescription.UseVisualStyleBackColor = true;
            this.buttonShowDescription.Click += new System.EventHandler(this.buttonShowDescription_Click);
            // 
            // buttonDataGridBindTank
            // 
            this.buttonDataGridBindTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDataGridBindTank.Location = new System.Drawing.Point(12, 78);
            this.buttonDataGridBindTank.Name = "buttonDataGridBindTank";
            this.buttonDataGridBindTank.Size = new System.Drawing.Size(160, 60);
            this.buttonDataGridBindTank.TabIndex = 15;
            this.buttonDataGridBindTank.Text = "Pokaż czołgi";
            this.buttonDataGridBindTank.UseVisualStyleBackColor = true;
            this.buttonDataGridBindTank.Click += new System.EventHandler(this.buttonDataGridBindTank_Click);
            // 
            // buttonDataGridBindArmoredVehicles
            // 
            this.buttonDataGridBindArmoredVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDataGridBindArmoredVehicles.Location = new System.Drawing.Point(178, 78);
            this.buttonDataGridBindArmoredVehicles.Name = "buttonDataGridBindArmoredVehicles";
            this.buttonDataGridBindArmoredVehicles.Size = new System.Drawing.Size(160, 60);
            this.buttonDataGridBindArmoredVehicles.TabIndex = 16;
            this.buttonDataGridBindArmoredVehicles.Text = "Pokaż pojazdy";
            this.buttonDataGridBindArmoredVehicles.UseVisualStyleBackColor = true;
            this.buttonDataGridBindArmoredVehicles.Click += new System.EventHandler(this.buttonDataGridBindArmoredVehicles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.tanklistnew;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 131);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.camouflagev2;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDataGridBindArmoredVehicles);
            this.Controls.Add(this.buttonDataGridBindTank);
            this.Controls.Add(this.buttonShowDescription);
            this.Controls.Add(this.buttonLoadArmoredVehicle);
            this.Controls.Add(this.buttonLoadTank);
            this.Controls.Add(this.buttonSaveTank);
            this.Controls.Add(this.buttonSaveArmoredVehicle);
            this.Controls.Add(this.buttonRemoveFromList);
            this.Controls.Add(this.buttonEditDescription);
            this.Controls.Add(this.textBoxVehicleInformation);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxVehicleDescription);
            this.Controls.Add(this.buttonAddTank);
            this.Controls.Add(this.buttonAddArmoredVehicle);
            this.Controls.Add(this.dataGridViewList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Lista pojazdów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonAddArmoredVehicle;
        private System.Windows.Forms.Button buttonAddTank;
        private System.Windows.Forms.TextBox textBoxVehicleDescription;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxVehicleInformation;
        private System.Windows.Forms.Button buttonEditDescription;
        private System.Windows.Forms.Button buttonRemoveFromList;
        private System.Windows.Forms.Button buttonSaveTank;
        private System.Windows.Forms.Button buttonSaveArmoredVehicle;
        private System.Windows.Forms.Button buttonLoadArmoredVehicle;
        private System.Windows.Forms.Button buttonLoadTank;
        private System.Windows.Forms.Button buttonShowDescription;
        private System.Windows.Forms.Button buttonDataGridBindTank;
        private System.Windows.Forms.Button buttonDataGridBindArmoredVehicles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace JanPajdakLab2ZadanieDomowe
{
    partial class FormAddArmoredVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddArmoredVehicle));
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonAddArmoredVehicle = new System.Windows.Forms.Button();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHorsepower = new System.Windows.Forms.TextBox();
            this.comboBoxEngineType = new System.Windows.Forms.ComboBox();
            this.radioButtonTracked = new System.Windows.Forms.RadioButton();
            this.radioButtonWheeled = new System.Windows.Forms.RadioButton();
            this.labelTextBoxWeight = new System.Windows.Forms.Label();
            this.labelTextBoxDesignation = new System.Windows.Forms.Label();
            this.labelTextBoxDriveType = new System.Windows.Forms.Label();
            this.labelTextBoxEngineType = new System.Windows.Forms.Label();
            this.labelTextBoxHorsepower = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.zielonyszum;
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.InitialImage = null;
            this.pictureBoxImage.Location = new System.Drawing.Point(322, 39);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.buttonAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddImage.Location = new System.Drawing.Point(322, 2);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(124, 34);
            this.buttonAddImage.TabIndex = 1;
            this.buttonAddImage.Text = "Przeglądaj...";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonAddArmoredVehicle
            // 
            this.buttonAddArmoredVehicle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddArmoredVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddArmoredVehicle.Location = new System.Drawing.Point(322, 313);
            this.buttonAddArmoredVehicle.Name = "buttonAddArmoredVehicle";
            this.buttonAddArmoredVehicle.Size = new System.Drawing.Size(120, 40);
            this.buttonAddArmoredVehicle.TabIndex = 2;
            this.buttonAddArmoredVehicle.Text = "Dodaj";
            this.buttonAddArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonAddArmoredVehicle.Click += new System.EventHandler(this.buttonAddArmoredVehicle_Click);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxDesignation.Location = new System.Drawing.Point(7, 27);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(146, 29);
            this.textBoxDesignation.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxWeight.Location = new System.Drawing.Point(7, 86);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(146, 29);
            this.textBoxWeight.TabIndex = 4;
            // 
            // textBoxHorsepower
            // 
            this.textBoxHorsepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxHorsepower.Location = new System.Drawing.Point(7, 145);
            this.textBoxHorsepower.Name = "textBoxHorsepower";
            this.textBoxHorsepower.Size = new System.Drawing.Size(146, 29);
            this.textBoxHorsepower.TabIndex = 5;
            // 
            // comboBoxEngineType
            // 
            this.comboBoxEngineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEngineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxEngineType.FormattingEnabled = true;
            this.comboBoxEngineType.Location = new System.Drawing.Point(7, 206);
            this.comboBoxEngineType.Name = "comboBoxEngineType";
            this.comboBoxEngineType.Size = new System.Drawing.Size(146, 32);
            this.comboBoxEngineType.TabIndex = 6;
            // 
            // radioButtonTracked
            // 
            this.radioButtonTracked.AutoSize = true;
            this.radioButtonTracked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonTracked.Location = new System.Drawing.Point(7, 268);
            this.radioButtonTracked.Name = "radioButtonTracked";
            this.radioButtonTracked.Size = new System.Drawing.Size(135, 28);
            this.radioButtonTracked.TabIndex = 7;
            this.radioButtonTracked.TabStop = true;
            this.radioButtonTracked.Text = "Gąsienicowy";
            this.radioButtonTracked.UseVisualStyleBackColor = true;
            // 
            // radioButtonWheeled
            // 
            this.radioButtonWheeled.AutoSize = true;
            this.radioButtonWheeled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radioButtonWheeled.Location = new System.Drawing.Point(7, 298);
            this.radioButtonWheeled.Name = "radioButtonWheeled";
            this.radioButtonWheeled.Size = new System.Drawing.Size(93, 28);
            this.radioButtonWheeled.TabIndex = 8;
            this.radioButtonWheeled.TabStop = true;
            this.radioButtonWheeled.Text = "Kołowy";
            this.radioButtonWheeled.UseVisualStyleBackColor = true;
            // 
            // labelTextBoxWeight
            // 
            this.labelTextBoxWeight.AutoSize = true;
            this.labelTextBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTextBoxWeight.Location = new System.Drawing.Point(3, 59);
            this.labelTextBoxWeight.Name = "labelTextBoxWeight";
            this.labelTextBoxWeight.Size = new System.Drawing.Size(88, 24);
            this.labelTextBoxWeight.TabIndex = 9;
            this.labelTextBoxWeight.Text = "Waga [ t ]";
            // 
            // labelTextBoxDesignation
            // 
            this.labelTextBoxDesignation.AutoSize = true;
            this.labelTextBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTextBoxDesignation.Location = new System.Drawing.Point(3, 0);
            this.labelTextBoxDesignation.Name = "labelTextBoxDesignation";
            this.labelTextBoxDesignation.Size = new System.Drawing.Size(67, 24);
            this.labelTextBoxDesignation.TabIndex = 10;
            this.labelTextBoxDesignation.Text = "Nazwa";
            // 
            // labelTextBoxDriveType
            // 
            this.labelTextBoxDriveType.AutoSize = true;
            this.labelTextBoxDriveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTextBoxDriveType.Location = new System.Drawing.Point(4, 241);
            this.labelTextBoxDriveType.Name = "labelTextBoxDriveType";
            this.labelTextBoxDriveType.Size = new System.Drawing.Size(67, 24);
            this.labelTextBoxDriveType.TabIndex = 11;
            this.labelTextBoxDriveType.Text = "Napęd";
            // 
            // labelTextBoxEngineType
            // 
            this.labelTextBoxEngineType.AutoSize = true;
            this.labelTextBoxEngineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTextBoxEngineType.Location = new System.Drawing.Point(4, 177);
            this.labelTextBoxEngineType.Name = "labelTextBoxEngineType";
            this.labelTextBoxEngineType.Size = new System.Drawing.Size(98, 24);
            this.labelTextBoxEngineType.TabIndex = 12;
            this.labelTextBoxEngineType.Text = "Typ silnika";
            // 
            // labelTextBoxHorsepower
            // 
            this.labelTextBoxHorsepower.AutoSize = true;
            this.labelTextBoxHorsepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelTextBoxHorsepower.Location = new System.Drawing.Point(3, 118);
            this.labelTextBoxHorsepower.Name = "labelTextBoxHorsepower";
            this.labelTextBoxHorsepower.Size = new System.Drawing.Size(153, 24);
            this.labelTextBoxHorsepower.TabIndex = 13;
            this.labelTextBoxHorsepower.Text = "Moc silnika [ km ]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.labelTextBoxDesignation);
            this.panel1.Controls.Add(this.radioButtonWheeled);
            this.panel1.Controls.Add(this.labelTextBoxDriveType);
            this.panel1.Controls.Add(this.radioButtonTracked);
            this.panel1.Controls.Add(this.labelTextBoxEngineType);
            this.panel1.Controls.Add(this.labelTextBoxHorsepower);
            this.panel1.Controls.Add(this.textBoxDesignation);
            this.panel1.Controls.Add(this.comboBoxEngineType);
            this.panel1.Controls.Add(this.labelTextBoxWeight);
            this.panel1.Controls.Add(this.textBoxWeight);
            this.panel1.Controls.Add(this.textBoxHorsepower);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 329);
            this.panel1.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(452, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 40);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // FormAddArmoredVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.camouflagev2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.buttonAddArmoredVehicle);
            this.Controls.Add(this.pictureBoxImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddArmoredVehicle";
            this.Text = "Dodaj pojazd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonAddArmoredVehicle;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHorsepower;
        private System.Windows.Forms.ComboBox comboBoxEngineType;
        private System.Windows.Forms.RadioButton radioButtonTracked;
        private System.Windows.Forms.RadioButton radioButtonWheeled;
        private System.Windows.Forms.Label labelTextBoxWeight;
        private System.Windows.Forms.Label labelTextBoxDesignation;
        private System.Windows.Forms.Label labelTextBoxDriveType;
        private System.Windows.Forms.Label labelTextBoxEngineType;
        private System.Windows.Forms.Label labelTextBoxHorsepower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
    }
}
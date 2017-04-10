namespace JanPajdakLab2ZadanieDomowe
{
    partial class FormEditDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDescription));
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(260, 180);
            this.textBoxDescription.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonConfirm.Location = new System.Drawing.Point(12, 198);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(101, 52);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Zatwierdź";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(171, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 52);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEditDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JanPajdakLab2ZadanieDomowe.Properties.Resources.camouflagev2;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditDescription";
            this.Text = "Edytuj opis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}
namespace WindowsFormsBattleship
{
    partial class FormDocks
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
            this.groupBox_extract = new System.Windows.Forms.GroupBox();
            this.button_extract = new System.Windows.Forms.Button();
            this.maskedTextBox_place = new System.Windows.Forms.MaskedTextBox();
            this.label_place = new System.Windows.Forms.Label();
            this.button_parkBShip = new System.Windows.Forms.Button();
            this.button_parkShip = new System.Windows.Forms.Button();
            this.pictureBox_doc = new System.Windows.Forms.PictureBox();
            this.groupBox_whatPlaces = new System.Windows.Forms.GroupBox();
            this.label_numPlace = new System.Windows.Forms.Label();
            this.maskedTextBox_numPlace = new System.Windows.Forms.MaskedTextBox();
            this.button_checking = new System.Windows.Forms.Button();
            this.groupBox_extract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).BeginInit();
            this.groupBox_whatPlaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_extract
            // 
            this.groupBox_extract.Controls.Add(this.button_extract);
            this.groupBox_extract.Controls.Add(this.maskedTextBox_place);
            this.groupBox_extract.Controls.Add(this.label_place);
            this.groupBox_extract.Location = new System.Drawing.Point(654, 152);
            this.groupBox_extract.Name = "groupBox_extract";
            this.groupBox_extract.Size = new System.Drawing.Size(139, 110);
            this.groupBox_extract.TabIndex = 7;
            this.groupBox_extract.TabStop = false;
            this.groupBox_extract.Text = "Забрать корабль";
            // 
            // button_extract
            // 
            this.button_extract.Location = new System.Drawing.Point(22, 73);
            this.button_extract.Name = "button_extract";
            this.button_extract.Size = new System.Drawing.Size(104, 23);
            this.button_extract.TabIndex = 5;
            this.button_extract.Text = "Забрать";
            this.button_extract.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_place
            // 
            this.maskedTextBox_place.Location = new System.Drawing.Point(67, 30);
            this.maskedTextBox_place.Name = "maskedTextBox_place";
            this.maskedTextBox_place.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_place.TabIndex = 4;
            // 
            // label_place
            // 
            this.label_place.AutoSize = true;
            this.label_place.Location = new System.Drawing.Point(19, 33);
            this.label_place.Name = "label_place";
            this.label_place.Size = new System.Drawing.Size(42, 13);
            this.label_place.TabIndex = 0;
            this.label_place.Text = "Место:";
            // 
            // button_parkBShip
            // 
            this.button_parkBShip.Location = new System.Drawing.Point(654, 85);
            this.button_parkBShip.Name = "button_parkBShip";
            this.button_parkBShip.Size = new System.Drawing.Size(140, 48);
            this.button_parkBShip.TabIndex = 6;
            this.button_parkBShip.Text = "Припарковать линкор";
            this.button_parkBShip.UseVisualStyleBackColor = true;
            this.button_parkBShip.Click += new System.EventHandler(this.button_parkBShip_Click);
            // 
            // button_parkShip
            // 
            this.button_parkShip.Location = new System.Drawing.Point(654, 22);
            this.button_parkShip.Name = "button_parkShip";
            this.button_parkShip.Size = new System.Drawing.Size(140, 48);
            this.button_parkShip.TabIndex = 5;
            this.button_parkShip.Text = "Припарковать корабль";
            this.button_parkShip.UseVisualStyleBackColor = true;
            this.button_parkShip.Click += new System.EventHandler(this.button_parkShip_Click);
            // 
            // pictureBox_doc
            // 
            this.pictureBox_doc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_doc.Location = new System.Drawing.Point(6, 0);
            this.pictureBox_doc.Name = "pictureBox_doc";
            this.pictureBox_doc.Size = new System.Drawing.Size(642, 450);
            this.pictureBox_doc.TabIndex = 4;
            this.pictureBox_doc.TabStop = false;
            // 
            // groupBox_whatPlaces
            // 
            this.groupBox_whatPlaces.Controls.Add(this.button_checking);
            this.groupBox_whatPlaces.Controls.Add(this.maskedTextBox_numPlace);
            this.groupBox_whatPlaces.Controls.Add(this.label_numPlace);
            this.groupBox_whatPlaces.Location = new System.Drawing.Point(654, 268);
            this.groupBox_whatPlaces.Name = "groupBox_whatPlaces";
            this.groupBox_whatPlaces.Size = new System.Drawing.Size(139, 85);
            this.groupBox_whatPlaces.TabIndex = 8;
            this.groupBox_whatPlaces.TabStop = false;
            this.groupBox_whatPlaces.Text = "Статус мест";
            // 
            // label_numPlace
            // 
            this.label_numPlace.AutoSize = true;
            this.label_numPlace.Location = new System.Drawing.Point(19, 27);
            this.label_numPlace.Name = "label_numPlace";
            this.label_numPlace.Size = new System.Drawing.Size(42, 13);
            this.label_numPlace.TabIndex = 1;
            this.label_numPlace.Text = "Место:";
            // 
            // maskedTextBox_numPlace
            // 
            this.maskedTextBox_numPlace.Location = new System.Drawing.Point(67, 24);
            this.maskedTextBox_numPlace.Name = "maskedTextBox_numPlace";
            this.maskedTextBox_numPlace.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_numPlace.TabIndex = 5;
            // 
            // button_checking
            // 
            this.button_checking.Location = new System.Drawing.Point(22, 56);
            this.button_checking.Name = "button_checking";
            this.button_checking.Size = new System.Drawing.Size(104, 23);
            this.button_checking.TabIndex = 6;
            this.button_checking.Text = "Узнать";
            this.button_checking.UseVisualStyleBackColor = true;
            this.button_checking.Click += new System.EventHandler(this.button_checking_Click);
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_whatPlaces);
            this.Controls.Add(this.groupBox_extract);
            this.Controls.Add(this.button_parkBShip);
            this.Controls.Add(this.button_parkShip);
            this.Controls.Add(this.pictureBox_doc);
            this.Name = "FormDocks";
            this.Text = "Доки";
            this.groupBox_extract.ResumeLayout(false);
            this.groupBox_extract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).EndInit();
            this.groupBox_whatPlaces.ResumeLayout(false);
            this.groupBox_whatPlaces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_extract;
        private System.Windows.Forms.Button button_extract;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_place;
        private System.Windows.Forms.Label label_place;
        private System.Windows.Forms.Button button_parkBShip;
        private System.Windows.Forms.Button button_parkShip;
        private System.Windows.Forms.PictureBox pictureBox_doc;
        private System.Windows.Forms.GroupBox groupBox_whatPlaces;
        private System.Windows.Forms.Label label_numPlace;
        private System.Windows.Forms.Button button_checking;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numPlace;
    }
}
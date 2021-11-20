namespace WindowsFormsBattleship
{
	partial class FormBattleship
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.buttonShipCreate = new System.Windows.Forms.Button();
            this.comboBox_number = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_typeGun = new System.Windows.Forms.GroupBox();
            this.radioButton_automatic = new System.Windows.Forms.RadioButton();
            this.radioButton_modif = new System.Windows.Forms.RadioButton();
            this.radioButton_standart = new System.Windows.Forms.RadioButton();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_typeGun.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::WindowsFormsBattleship.Properties.Resources.arrowd;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(644, 438);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(63, 61);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::WindowsFormsBattleship.Properties.Resources.arrowL;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(575, 404);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(63, 61);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::WindowsFormsBattleship.Properties.Resources.arrow;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(713, 404);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(59, 61);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::WindowsFormsBattleship.Properties.Resources.arrowU;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(644, 371);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(63, 61);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 108);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(784, 403);
            this.pictureBoxShip.TabIndex = 5;
            this.pictureBoxShip.TabStop = false;
            // 
            // buttonShipCreate
            // 
            this.buttonShipCreate.Location = new System.Drawing.Point(437, 12);
            this.buttonShipCreate.Name = "buttonShipCreate";
            this.buttonShipCreate.Size = new System.Drawing.Size(165, 39);
            this.buttonShipCreate.TabIndex = 0;
            this.buttonShipCreate.Text = "Создать корабль";
            this.buttonShipCreate.UseVisualStyleBackColor = true;
            this.buttonShipCreate.Click += new System.EventHandler(this.buttonShipCreate_Click);
            // 
            // comboBox_number
            // 
            this.comboBox_number.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.comboBox_number.Location = new System.Drawing.Point(12, 12);
            this.comboBox_number.Name = "comboBox_number";
            this.comboBox_number.Size = new System.Drawing.Size(121, 21);
            this.comboBox_number.TabIndex = 6;
            this.comboBox_number.Text = "Количество орудий";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_typeGun);
            this.panel1.Controls.Add(this.comboBox_number);
            this.panel1.Controls.Add(this.buttonShipCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 112);
            this.panel1.TabIndex = 8;
            // 
            // groupBox_typeGun
            // 
            this.groupBox_typeGun.Controls.Add(this.radioButton_automatic);
            this.groupBox_typeGun.Controls.Add(this.radioButton_modif);
            this.groupBox_typeGun.Controls.Add(this.radioButton_standart);
            this.groupBox_typeGun.Controls.Add(this.buttonCreate);
            this.groupBox_typeGun.Location = new System.Drawing.Point(608, 3);
            this.groupBox_typeGun.Name = "groupBox_typeGun";
            this.groupBox_typeGun.Size = new System.Drawing.Size(173, 109);
            this.groupBox_typeGun.TabIndex = 8;
            this.groupBox_typeGun.TabStop = false;
            this.groupBox_typeGun.Text = "Выбор ракеты";
            // 
            // radioButton_automatic
            // 
            this.radioButton_automatic.AutoSize = true;
            this.radioButton_automatic.Location = new System.Drawing.Point(6, 53);
            this.radioButton_automatic.Name = "radioButton_automatic";
            this.radioButton_automatic.Size = new System.Drawing.Size(109, 17);
            this.radioButton_automatic.TabIndex = 10;
            this.radioButton_automatic.TabStop = true;
            this.radioButton_automatic.Text = "Автоматическая";
            this.radioButton_automatic.UseVisualStyleBackColor = true;
            // 
            // radioButton_modif
            // 
            this.radioButton_modif.AutoSize = true;
            this.radioButton_modif.Location = new System.Drawing.Point(6, 33);
            this.radioButton_modif.Name = "radioButton_modif";
            this.radioButton_modif.Size = new System.Drawing.Size(87, 17);
            this.radioButton_modif.TabIndex = 9;
            this.radioButton_modif.TabStop = true;
            this.radioButton_modif.Text = "Улучшенная";
            this.radioButton_modif.UseVisualStyleBackColor = true;
            // 
            // radioButton_standart
            // 
            this.radioButton_standart.AutoSize = true;
            this.radioButton_standart.Location = new System.Drawing.Point(6, 13);
            this.radioButton_standart.Name = "radioButton_standart";
            this.radioButton_standart.Size = new System.Drawing.Size(93, 17);
            this.radioButton_standart.TabIndex = 8;
            this.radioButton_standart.TabStop = true;
            this.radioButton_standart.Text = "Стандартная ";
            this.radioButton_standart.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(6, 71);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(165, 35);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Создать линкор";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // FormBattleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxShip);
            this.Name = "FormBattleship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Линкор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_typeGun.ResumeLayout(false);
            this.groupBox_typeGun.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.Button buttonShipCreate;
        private System.Windows.Forms.ComboBox comboBox_number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBox_typeGun;
        private System.Windows.Forms.RadioButton radioButton_standart;
        private System.Windows.Forms.RadioButton radioButton_automatic;
        private System.Windows.Forms.RadioButton radioButton_modif;
    }
}


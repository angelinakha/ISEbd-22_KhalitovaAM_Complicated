namespace WindowsFormsBattleship
{
    partial class FormShipConfig
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipConfig));
			this.groupBox_ = new System.Windows.Forms.GroupBox();
			this.labelBattSh = new System.Windows.Forms.Label();
			this.labelShip = new System.Windows.Forms.Label();
			this.groupB_setting = new System.Windows.Forms.GroupBox();
			this.checkBox_rocket = new System.Windows.Forms.CheckBox();
			this.checkBox_cannon = new System.Windows.Forms.CheckBox();
			this.numericUpDown_W = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_mS = new System.Windows.Forms.NumericUpDown();
			this.label_weight = new System.Windows.Forms.Label();
			this.label_maxSpeed = new System.Windows.Forms.Label();
			this.panel_ship = new System.Windows.Forms.Panel();
			this.pictureBox_ship = new System.Windows.Forms.PictureBox();
			this.groupBoxColor = new System.Windows.Forms.GroupBox();
			this.panelCol_fuchsia = new System.Windows.Forms.Panel();
			this.panelCol_red = new System.Windows.Forms.Panel();
			this.panelCol_orange = new System.Windows.Forms.Panel();
			this.panelCol_yellow = new System.Windows.Forms.Panel();
			this.panelCol_gray = new System.Windows.Forms.Panel();
			this.panelCol_green = new System.Windows.Forms.Panel();
			this.panelCol_blue = new System.Windows.Forms.Panel();
			this.panelCol_black = new System.Windows.Forms.Panel();
			this.labelDopCol = new System.Windows.Forms.Label();
			this.labelBasicCol = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxGuns = new System.Windows.Forms.GroupBox();
			this.label_rocAuto = new System.Windows.Forms.Label();
			this.label_rocMod = new System.Windows.Forms.Label();
			this.label_rockStand = new System.Windows.Forms.Label();
			this.label_can6 = new System.Windows.Forms.Label();
			this.label_can4 = new System.Windows.Forms.Label();
			this.label_can2 = new System.Windows.Forms.Label();
			this.label_typeRocket = new System.Windows.Forms.Label();
			this.label_numCan = new System.Windows.Forms.Label();
			this.groupBox_.SuspendLayout();
			this.groupB_setting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_W)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mS)).BeginInit();
			this.panel_ship.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ship)).BeginInit();
			this.groupBoxColor.SuspendLayout();
			this.groupBoxGuns.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_
			// 
			this.groupBox_.Controls.Add(this.labelBattSh);
			this.groupBox_.Controls.Add(this.labelShip);
			this.groupBox_.Location = new System.Drawing.Point(31, 45);
			this.groupBox_.Name = "groupBox_";
			this.groupBox_.Size = new System.Drawing.Size(175, 124);
			this.groupBox_.TabIndex = 0;
			this.groupBox_.TabStop = false;
			this.groupBox_.Text = "Выбор корпуса";
			// 
			// labelBattSh
			// 
			this.labelBattSh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBattSh.Location = new System.Drawing.Point(33, 71);
			this.labelBattSh.Name = "labelBattSh";
			this.labelBattSh.Size = new System.Drawing.Size(103, 30);
			this.labelBattSh.TabIndex = 1;
			this.labelBattSh.Text = "Линкор";
			this.labelBattSh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBattSh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBattSh_MouseDown);
			// 
			// labelShip
			// 
			this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelShip.Location = new System.Drawing.Point(33, 28);
			this.labelShip.Name = "labelShip";
			this.labelShip.Size = new System.Drawing.Size(103, 30);
			this.labelShip.TabIndex = 0;
			this.labelShip.Text = "Корабль";
			this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
			// 
			// groupB_setting
			// 
			this.groupB_setting.Controls.Add(this.checkBox_rocket);
			this.groupB_setting.Controls.Add(this.checkBox_cannon);
			this.groupB_setting.Controls.Add(this.numericUpDown_W);
			this.groupB_setting.Controls.Add(this.numericUpDown_mS);
			this.groupB_setting.Controls.Add(this.label_weight);
			this.groupB_setting.Controls.Add(this.label_maxSpeed);
			this.groupB_setting.Location = new System.Drawing.Point(12, 212);
			this.groupB_setting.Name = "groupB_setting";
			this.groupB_setting.Size = new System.Drawing.Size(271, 156);
			this.groupB_setting.TabIndex = 1;
			this.groupB_setting.TabStop = false;
			this.groupB_setting.Text = "Параметры";
			// 
			// checkBox_rocket
			// 
			this.checkBox_rocket.AutoSize = true;
			this.checkBox_rocket.Location = new System.Drawing.Point(166, 84);
			this.checkBox_rocket.Name = "checkBox_rocket";
			this.checkBox_rocket.Size = new System.Drawing.Size(64, 17);
			this.checkBox_rocket.TabIndex = 5;
			this.checkBox_rocket.Text = "Ракеты";
			this.checkBox_rocket.UseVisualStyleBackColor = true;
			// 
			// checkBox_cannon
			// 
			this.checkBox_cannon.AutoSize = true;
			this.checkBox_cannon.Location = new System.Drawing.Point(166, 46);
			this.checkBox_cannon.Name = "checkBox_cannon";
			this.checkBox_cannon.Size = new System.Drawing.Size(59, 17);
			this.checkBox_cannon.TabIndex = 4;
			this.checkBox_cannon.Text = "Пушки";
			this.checkBox_cannon.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_W
			// 
			this.numericUpDown_W.Location = new System.Drawing.Point(86, 100);
			this.numericUpDown_W.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_W.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown_W.Name = "numericUpDown_W";
			this.numericUpDown_W.Size = new System.Drawing.Size(42, 20);
			this.numericUpDown_W.TabIndex = 3;
			this.numericUpDown_W.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDown_mS
			// 
			this.numericUpDown_mS.Location = new System.Drawing.Point(86, 46);
			this.numericUpDown_mS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown_mS.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown_mS.Name = "numericUpDown_mS";
			this.numericUpDown_mS.Size = new System.Drawing.Size(42, 20);
			this.numericUpDown_mS.TabIndex = 2;
			this.numericUpDown_mS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label_weight
			// 
			this.label_weight.AutoSize = true;
			this.label_weight.Location = new System.Drawing.Point(16, 84);
			this.label_weight.Name = "label_weight";
			this.label_weight.Size = new System.Drawing.Size(77, 13);
			this.label_weight.TabIndex = 1;
			this.label_weight.Text = "Вес корабля: ";
			// 
			// label_maxSpeed
			// 
			this.label_maxSpeed.AutoSize = true;
			this.label_maxSpeed.Location = new System.Drawing.Point(16, 30);
			this.label_maxSpeed.Name = "label_maxSpeed";
			this.label_maxSpeed.Size = new System.Drawing.Size(90, 13);
			this.label_maxSpeed.TabIndex = 0;
			this.label_maxSpeed.Text = "Макс. скорость:";
			// 
			// panel_ship
			// 
			this.panel_ship.AllowDrop = true;
			this.panel_ship.Controls.Add(this.pictureBox_ship);
			this.panel_ship.Location = new System.Drawing.Point(255, 12);
			this.panel_ship.Name = "panel_ship";
			this.panel_ship.Size = new System.Drawing.Size(270, 181);
			this.panel_ship.TabIndex = 3;
			this.panel_ship.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_ship_DragDrop);
			this.panel_ship.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_ship_DragEnter);
			// 
			// pictureBox_ship
			// 
			this.pictureBox_ship.Location = new System.Drawing.Point(22, 11);
			this.pictureBox_ship.Name = "pictureBox_ship";
			this.pictureBox_ship.Size = new System.Drawing.Size(224, 158);
			this.pictureBox_ship.TabIndex = 2;
			this.pictureBox_ship.TabStop = false;
			// 
			// groupBoxColor
			// 
			this.groupBoxColor.Controls.Add(this.panelCol_fuchsia);
			this.groupBoxColor.Controls.Add(this.panelCol_red);
			this.groupBoxColor.Controls.Add(this.panelCol_orange);
			this.groupBoxColor.Controls.Add(this.panelCol_yellow);
			this.groupBoxColor.Controls.Add(this.panelCol_gray);
			this.groupBoxColor.Controls.Add(this.panelCol_green);
			this.groupBoxColor.Controls.Add(this.panelCol_blue);
			this.groupBoxColor.Controls.Add(this.panelCol_black);
			this.groupBoxColor.Controls.Add(this.labelDopCol);
			this.groupBoxColor.Controls.Add(this.labelBasicCol);
			this.groupBoxColor.Location = new System.Drawing.Point(458, 208);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Size = new System.Drawing.Size(293, 160);
			this.groupBoxColor.TabIndex = 4;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Цвета";
			// 
			// panelCol_fuchsia
			// 
			this.panelCol_fuchsia.BackColor = System.Drawing.Color.Fuchsia;
			this.panelCol_fuchsia.Location = new System.Drawing.Point(220, 68);
			this.panelCol_fuchsia.Name = "panelCol_fuchsia";
			this.panelCol_fuchsia.Size = new System.Drawing.Size(39, 32);
			this.panelCol_fuchsia.TabIndex = 5;
			// 
			// panelCol_red
			// 
			this.panelCol_red.BackColor = System.Drawing.Color.Red;
			this.panelCol_red.Location = new System.Drawing.Point(157, 68);
			this.panelCol_red.Name = "panelCol_red";
			this.panelCol_red.Size = new System.Drawing.Size(39, 32);
			this.panelCol_red.TabIndex = 8;
			// 
			// panelCol_orange
			// 
			this.panelCol_orange.BackColor = System.Drawing.Color.Orange;
			this.panelCol_orange.Location = new System.Drawing.Point(94, 68);
			this.panelCol_orange.Name = "panelCol_orange";
			this.panelCol_orange.Size = new System.Drawing.Size(39, 32);
			this.panelCol_orange.TabIndex = 7;
			// 
			// panelCol_yellow
			// 
			this.panelCol_yellow.BackColor = System.Drawing.Color.Yellow;
			this.panelCol_yellow.Location = new System.Drawing.Point(30, 68);
			this.panelCol_yellow.Name = "panelCol_yellow";
			this.panelCol_yellow.Size = new System.Drawing.Size(39, 32);
			this.panelCol_yellow.TabIndex = 6;
			// 
			// panelCol_gray
			// 
			this.panelCol_gray.BackColor = System.Drawing.Color.Gray;
			this.panelCol_gray.Location = new System.Drawing.Point(30, 108);
			this.panelCol_gray.Name = "panelCol_gray";
			this.panelCol_gray.Size = new System.Drawing.Size(39, 32);
			this.panelCol_gray.TabIndex = 5;
			// 
			// panelCol_green
			// 
			this.panelCol_green.BackColor = System.Drawing.Color.Green;
			this.panelCol_green.Location = new System.Drawing.Point(94, 108);
			this.panelCol_green.Name = "panelCol_green";
			this.panelCol_green.Size = new System.Drawing.Size(39, 32);
			this.panelCol_green.TabIndex = 4;
			// 
			// panelCol_blue
			// 
			this.panelCol_blue.BackColor = System.Drawing.Color.Blue;
			this.panelCol_blue.Location = new System.Drawing.Point(157, 108);
			this.panelCol_blue.Name = "panelCol_blue";
			this.panelCol_blue.Size = new System.Drawing.Size(39, 32);
			this.panelCol_blue.TabIndex = 3;
			// 
			// panelCol_black
			// 
			this.panelCol_black.BackColor = System.Drawing.Color.Black;
			this.panelCol_black.Location = new System.Drawing.Point(220, 108);
			this.panelCol_black.Name = "panelCol_black";
			this.panelCol_black.Size = new System.Drawing.Size(39, 32);
			this.panelCol_black.TabIndex = 2;
			// 
			// labelDopCol
			// 
			this.labelDopCol.AllowDrop = true;
			this.labelDopCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopCol.Location = new System.Drawing.Point(157, 20);
			this.labelDopCol.Name = "labelDopCol";
			this.labelDopCol.Size = new System.Drawing.Size(91, 30);
			this.labelDopCol.TabIndex = 1;
			this.labelDopCol.Text = "Дополн. цвет";
			this.labelDopCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopCol_DragDrop);
			this.labelDopCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragEnter);
			// 
			// labelBasicCol
			// 
			this.labelBasicCol.AllowDrop = true;
			this.labelBasicCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBasicCol.Location = new System.Drawing.Point(42, 20);
			this.labelBasicCol.Name = "labelBasicCol";
			this.labelBasicCol.Size = new System.Drawing.Size(91, 30);
			this.labelBasicCol.TabIndex = 0;
			this.labelBasicCol.Text = "Основной цвет";
			this.labelBasicCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBasicCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragDrop);
			this.labelBasicCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBasicCol_DragEnter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(549, 73);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(93, 33);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(549, 116);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(93, 33);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxGuns
			// 
			this.groupBoxGuns.Controls.Add(this.label_rocAuto);
			this.groupBoxGuns.Controls.Add(this.label_rocMod);
			this.groupBoxGuns.Controls.Add(this.label_rockStand);
			this.groupBoxGuns.Controls.Add(this.label_can6);
			this.groupBoxGuns.Controls.Add(this.label_can4);
			this.groupBoxGuns.Controls.Add(this.label_can2);
			this.groupBoxGuns.Controls.Add(this.label_typeRocket);
			this.groupBoxGuns.Controls.Add(this.label_numCan);
			this.groupBoxGuns.Location = new System.Drawing.Point(296, 208);
			this.groupBoxGuns.Name = "groupBoxGuns";
			this.groupBoxGuns.Size = new System.Drawing.Size(156, 241);
			this.groupBoxGuns.TabIndex = 7;
			this.groupBoxGuns.TabStop = false;
			this.groupBoxGuns.Text = "Выбор оружия";
			// 
			// label_rocAuto
			// 
			this.label_rocAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_rocAuto.Image = ((System.Drawing.Image)(resources.GetObject("label_rocAuto.Image")));
			this.label_rocAuto.Location = new System.Drawing.Point(110, 158);
			this.label_rocAuto.Name = "label_rocAuto";
			this.label_rocAuto.Size = new System.Drawing.Size(28, 75);
			this.label_rocAuto.TabIndex = 7;
			this.label_rocAuto.Text = "A";
			this.label_rocAuto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_rocAuto_MouseDown);
			// 
			// label_rocMod
			// 
			this.label_rocMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_rocMod.Image = ((System.Drawing.Image)(resources.GetObject("label_rocMod.Image")));
			this.label_rocMod.Location = new System.Drawing.Point(63, 158);
			this.label_rocMod.Name = "label_rocMod";
			this.label_rocMod.Size = new System.Drawing.Size(28, 75);
			this.label_rocMod.TabIndex = 6;
			this.label_rocMod.Text = "M";
			this.label_rocMod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_rocMod_MouseDown);
			// 
			// label_rockStand
			// 
			this.label_rockStand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_rockStand.Image = ((System.Drawing.Image)(resources.GetObject("label_rockStand.Image")));
			this.label_rockStand.Location = new System.Drawing.Point(14, 158);
			this.label_rockStand.Name = "label_rockStand";
			this.label_rockStand.Size = new System.Drawing.Size(28, 75);
			this.label_rockStand.TabIndex = 5;
			this.label_rockStand.Text = "S";
			this.label_rockStand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_rockStand_MouseDown);
			// 
			// label_can6
			// 
			this.label_can6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_can6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_can6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_can6.Location = new System.Drawing.Point(108, 68);
			this.label_can6.Name = "label_can6";
			this.label_can6.Size = new System.Drawing.Size(30, 30);
			this.label_can6.TabIndex = 4;
			this.label_can6.Text = "6";
			this.label_can6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_can6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_can6_MouseDown);
			// 
			// label_can4
			// 
			this.label_can4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_can4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_can4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_can4.Location = new System.Drawing.Point(63, 68);
			this.label_can4.Name = "label_can4";
			this.label_can4.Size = new System.Drawing.Size(30, 30);
			this.label_can4.TabIndex = 3;
			this.label_can4.Text = "4";
			this.label_can4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_can4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_can4_MouseDown);
			// 
			// label_can2
			// 
			this.label_can2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_can2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_can2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_can2.Location = new System.Drawing.Point(17, 68);
			this.label_can2.Name = "label_can2";
			this.label_can2.Size = new System.Drawing.Size(30, 30);
			this.label_can2.TabIndex = 2;
			this.label_can2.Text = "2";
			this.label_can2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_can2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_can2_MouseDown);
			// 
			// label_typeRocket
			// 
			this.label_typeRocket.AllowDrop = true;
			this.label_typeRocket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_typeRocket.Location = new System.Drawing.Point(6, 115);
			this.label_typeRocket.Name = "label_typeRocket";
			this.label_typeRocket.Size = new System.Drawing.Size(144, 30);
			this.label_typeRocket.TabIndex = 1;
			this.label_typeRocket.Text = "Виды ракет";
			this.label_typeRocket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_typeRocket.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_typeRocket_DragDrop);
			this.label_typeRocket.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_typeRocket_DragEnter);
			// 
			// label_numCan
			// 
			this.label_numCan.AllowDrop = true;
			this.label_numCan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_numCan.Location = new System.Drawing.Point(6, 25);
			this.label_numCan.Name = "label_numCan";
			this.label_numCan.Size = new System.Drawing.Size(144, 30);
			this.label_numCan.TabIndex = 0;
			this.label_numCan.Text = "Количество пушек";
			this.label_numCan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_numCan.DragDrop += new System.Windows.Forms.DragEventHandler(this.label_numCan_DragDrop);
			this.label_numCan.DragEnter += new System.Windows.Forms.DragEventHandler(this.label_numCan_DragEnter);
			// 
			// FormShipConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBoxGuns);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxColor);
			this.Controls.Add(this.panel_ship);
			this.Controls.Add(this.groupB_setting);
			this.Controls.Add(this.groupBox_);
			this.Name = "FormShipConfig";
			this.Text = "Выбор корабля";
			this.groupBox_.ResumeLayout(false);
			this.groupB_setting.ResumeLayout(false);
			this.groupB_setting.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_W)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mS)).EndInit();
			this.panel_ship.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_ship)).EndInit();
			this.groupBoxColor.ResumeLayout(false);
			this.groupBoxGuns.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_;
        private System.Windows.Forms.Label labelBattSh;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.GroupBox groupB_setting;
        private System.Windows.Forms.Label label_maxSpeed;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.CheckBox checkBox_rocket;
        private System.Windows.Forms.CheckBox checkBox_cannon;
        private System.Windows.Forms.NumericUpDown numericUpDown_W;
        private System.Windows.Forms.NumericUpDown numericUpDown_mS;
        private System.Windows.Forms.PictureBox pictureBox_ship;
        private System.Windows.Forms.Panel panel_ship;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelCol_green;
        private System.Windows.Forms.Panel panelCol_blue;
        private System.Windows.Forms.Panel panelCol_black;
        private System.Windows.Forms.Label labelDopCol;
        private System.Windows.Forms.Label labelBasicCol;
        private System.Windows.Forms.Panel panelCol_fuchsia;
        private System.Windows.Forms.Panel panelCol_red;
        private System.Windows.Forms.Panel panelCol_orange;
        private System.Windows.Forms.Panel panelCol_yellow;
        private System.Windows.Forms.Panel panelCol_gray;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxGuns;
        private System.Windows.Forms.Label label_can6;
        private System.Windows.Forms.Label label_can4;
        private System.Windows.Forms.Label label_can2;
        private System.Windows.Forms.Label label_typeRocket;
        private System.Windows.Forms.Label label_numCan;
        private System.Windows.Forms.Label label_rockStand;
        private System.Windows.Forms.Label label_rocAuto;
        private System.Windows.Forms.Label label_rocMod;
    }
}
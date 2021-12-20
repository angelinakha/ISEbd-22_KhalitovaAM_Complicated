﻿namespace WindowsFormsBattleship
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
            this.button_AddShip = new System.Windows.Forms.Button();
            this.pictureBox_doc = new System.Windows.Forms.PictureBox();
            this.groupBox_whatPlaces = new System.Windows.Forms.GroupBox();
            this.button_checking = new System.Windows.Forms.Button();
            this.maskedTextBox_numPlace = new System.Windows.Forms.MaskedTextBox();
            this.label_numPlace = new System.Windows.Forms.Label();
            this.label_parks = new System.Windows.Forms.Label();
            this.textBox_parkName = new System.Windows.Forms.TextBox();
            this.button_del = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_listDoc = new System.Windows.Forms.ListBox();
            this.buttonAddFromStack = new System.Windows.Forms.Button();
            this.menuStrip_ship = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбраннуюПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПарковкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однуПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПарковкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_ship = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_ship = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            this.groupBox_extract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).BeginInit();
            this.groupBox_whatPlaces.SuspendLayout();
            this.menuStrip_ship.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_extract
            // 
            this.groupBox_extract.Controls.Add(this.button_extract);
            this.groupBox_extract.Controls.Add(this.maskedTextBox_place);
            this.groupBox_extract.Controls.Add(this.label_place);
            this.groupBox_extract.Location = new System.Drawing.Point(654, 294);
            this.groupBox_extract.Name = "groupBox_extract";
            this.groupBox_extract.Size = new System.Drawing.Size(139, 75);
            this.groupBox_extract.TabIndex = 7;
            this.groupBox_extract.TabStop = false;
            this.groupBox_extract.Text = "Забрать корабль";
            // 
            // button_extract
            // 
            this.button_extract.Location = new System.Drawing.Point(23, 45);
            this.button_extract.Name = "button_extract";
            this.button_extract.Size = new System.Drawing.Size(104, 23);
            this.button_extract.TabIndex = 5;
            this.button_extract.Text = "Забрать в стек";
            this.button_extract.UseVisualStyleBackColor = true;
            this.button_extract.Click += new System.EventHandler(this.button_extract_Click);
            // 
            // maskedTextBox_place
            // 
            this.maskedTextBox_place.Location = new System.Drawing.Point(68, 19);
            this.maskedTextBox_place.Name = "maskedTextBox_place";
            this.maskedTextBox_place.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_place.TabIndex = 4;
            // 
            // label_place
            // 
            this.label_place.AutoSize = true;
            this.label_place.Location = new System.Drawing.Point(20, 22);
            this.label_place.Name = "label_place";
            this.label_place.Size = new System.Drawing.Size(42, 13);
            this.label_place.TabIndex = 0;
            this.label_place.Text = "Место:";
            // 
            // button_AddShip
            // 
            this.button_AddShip.Location = new System.Drawing.Point(654, 201);
            this.button_AddShip.Name = "button_AddShip";
            this.button_AddShip.Size = new System.Drawing.Size(140, 38);
            this.button_AddShip.TabIndex = 5;
            this.button_AddShip.Text = "Припарковать корабль";
            this.button_AddShip.UseVisualStyleBackColor = true;
            this.button_AddShip.Click += new System.EventHandler(this.button_AddShip_Click);
            // 
            // pictureBox_doc
            // 
            this.pictureBox_doc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_doc.Location = new System.Drawing.Point(12, 31);
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
            this.groupBox_whatPlaces.Location = new System.Drawing.Point(654, 394);
            this.groupBox_whatPlaces.Name = "groupBox_whatPlaces";
            this.groupBox_whatPlaces.Size = new System.Drawing.Size(139, 78);
            this.groupBox_whatPlaces.TabIndex = 8;
            this.groupBox_whatPlaces.TabStop = false;
            this.groupBox_whatPlaces.Text = "Статус мест";
            // 
            // button_checking
            // 
            this.button_checking.Location = new System.Drawing.Point(22, 45);
            this.button_checking.Name = "button_checking";
            this.button_checking.Size = new System.Drawing.Size(104, 23);
            this.button_checking.TabIndex = 6;
            this.button_checking.Text = "Узнать";
            this.button_checking.UseVisualStyleBackColor = true;
            this.button_checking.Click += new System.EventHandler(this.button_checking_Click);
            // 
            // maskedTextBox_numPlace
            // 
            this.maskedTextBox_numPlace.Location = new System.Drawing.Point(67, 19);
            this.maskedTextBox_numPlace.Name = "maskedTextBox_numPlace";
            this.maskedTextBox_numPlace.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox_numPlace.TabIndex = 5;
            // 
            // label_numPlace
            // 
            this.label_numPlace.AutoSize = true;
            this.label_numPlace.Location = new System.Drawing.Point(19, 22);
            this.label_numPlace.Name = "label_numPlace";
            this.label_numPlace.Size = new System.Drawing.Size(42, 13);
            this.label_numPlace.TabIndex = 1;
            this.label_numPlace.Text = "Место:";
            // 
            // label_parks
            // 
            this.label_parks.AutoSize = true;
            this.label_parks.Location = new System.Drawing.Point(693, 31);
            this.label_parks.Name = "label_parks";
            this.label_parks.Size = new System.Drawing.Size(60, 13);
            this.label_parks.TabIndex = 10;
            this.label_parks.Text = "Парковки:";
            // 
            // textBox_parkName
            // 
            this.textBox_parkName.Location = new System.Drawing.Point(652, 47);
            this.textBox_parkName.Name = "textBox_parkName";
            this.textBox_parkName.Size = new System.Drawing.Size(140, 20);
            this.textBox_parkName.TabIndex = 9;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(653, 167);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(140, 28);
            this.button_del.TabIndex = 13;
            this.button_del.Text = "Удалить парковку";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(653, 73);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(140, 26);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Добавить парковку";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox_listDoc
            // 
            this.listBox_listDoc.FormattingEnabled = true;
            this.listBox_listDoc.Location = new System.Drawing.Point(653, 105);
            this.listBox_listDoc.Name = "listBox_listDoc";
            this.listBox_listDoc.Size = new System.Drawing.Size(140, 56);
            this.listBox_listDoc.TabIndex = 11;
            this.listBox_listDoc.SelectedIndexChanged += new System.EventHandler(this.listBox_listDoc_SelectedIndexChanged);
            // 
            // buttonAddFromStack
            // 
            this.buttonAddFromStack.Location = new System.Drawing.Point(654, 367);
            this.buttonAddFromStack.Name = "buttonAddFromStack";
            this.buttonAddFromStack.Size = new System.Drawing.Size(140, 26);
            this.buttonAddFromStack.TabIndex = 14;
            this.buttonAddFromStack.Text = "Добавить из стека";
            this.buttonAddFromStack.UseVisualStyleBackColor = true;
            this.buttonAddFromStack.Click += new System.EventHandler(this.buttonAddFromStack_Click);
            // 
            // menuStrip_ship
            // 
            this.menuStrip_ship.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip_ship.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ship.Name = "menuStrip_ship";
            this.menuStrip_ship.Size = new System.Drawing.Size(800, 24);
            this.menuStrip_ship.TabIndex = 15;
            this.menuStrip_ship.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбраннуюПарковкуToolStripMenuItem,
            this.всеПарковкиToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выбраннуюПарковкуToolStripMenuItem
            // 
            this.выбраннуюПарковкуToolStripMenuItem.Name = "выбраннуюПарковкуToolStripMenuItem";
            this.выбраннуюПарковкуToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выбраннуюПарковкуToolStripMenuItem.Text = "Выбранную парковку";
            this.выбраннуюПарковкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьвыбраннуюПарковкуToolStripMenuItem_Click);
            // 
            // всеПарковкиToolStripMenuItem
            // 
            this.всеПарковкиToolStripMenuItem.Name = "всеПарковкиToolStripMenuItem";
            this.всеПарковкиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.всеПарковкиToolStripMenuItem.Text = "Все парковки";
            this.всеПарковкиToolStripMenuItem.Click += new System.EventHandler(this.сохранитьвсеПарковкиToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.однуПарковкуToolStripMenuItem,
            this.всеПарковкиToolStripMenuItem1});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // однуПарковкуToolStripMenuItem
            // 
            this.однуПарковкуToolStripMenuItem.Name = "однуПарковкуToolStripMenuItem";
            this.однуПарковкуToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.однуПарковкуToolStripMenuItem.Text = "Одну парковку";
            this.однуПарковкуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьоднуПарковкуToolStripMenuItem_Click);
            // 
            // всеПарковкиToolStripMenuItem1
            // 
            this.всеПарковкиToolStripMenuItem1.Name = "всеПарковкиToolStripMenuItem1";
            this.всеПарковкиToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.всеПарковкиToolStripMenuItem1.Text = "Все парковки";
            this.всеПарковкиToolStripMenuItem1.Click += new System.EventHandler(this.загрузитьвсеПарковкиToolStripMenuItem_Click);
            // 
            // saveFileDialog_ship
            // 
            this.saveFileDialog_ship.Filter = "txt file | *.txt";
            // 
            // openFileDialog_ship
            // 
            this.openFileDialog_ship.FileName = "openFileDialog1";
            this.openFileDialog_ship.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(654, 243);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(140, 35);
            this.buttonSort.TabIndex = 16;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.menuStrip_ship);
            this.Controls.Add(this.buttonAddFromStack);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_listDoc);
            this.Controls.Add(this.label_parks);
            this.Controls.Add(this.textBox_parkName);
            this.Controls.Add(this.groupBox_whatPlaces);
            this.Controls.Add(this.groupBox_extract);
            this.Controls.Add(this.button_AddShip);
            this.Controls.Add(this.pictureBox_doc);
            this.Name = "FormDocks";
            this.Text = "Доки";
            this.groupBox_extract.ResumeLayout(false);
            this.groupBox_extract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_doc)).EndInit();
            this.groupBox_whatPlaces.ResumeLayout(false);
            this.groupBox_whatPlaces.PerformLayout();
            this.menuStrip_ship.ResumeLayout(false);
            this.menuStrip_ship.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_extract;
        private System.Windows.Forms.Button button_extract;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_place;
        private System.Windows.Forms.Label label_place;
        private System.Windows.Forms.Button button_AddShip;
        private System.Windows.Forms.PictureBox pictureBox_doc;
        private System.Windows.Forms.GroupBox groupBox_whatPlaces;
        private System.Windows.Forms.Label label_numPlace;
        private System.Windows.Forms.Button button_checking;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numPlace;
        private System.Windows.Forms.Label label_parks;
        private System.Windows.Forms.TextBox textBox_parkName;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox listBox_listDoc;
        private System.Windows.Forms.Button buttonAddFromStack;
        private System.Windows.Forms.MenuStrip menuStrip_ship;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ship;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ship;
        private System.Windows.Forms.ToolStripMenuItem выбраннуюПарковкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПарковкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однуПарковкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПарковкиToolStripMenuItem1;
        private System.Windows.Forms.Button buttonSort;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBattleship
{
    public partial class FormShipConfig : Form
    {
        Vehicle ship = null;
        private event Action<Vehicle> eventAddShip;
        public FormShipConfig()
        {
            InitializeComponent();
            this.panelCol_yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_fuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelCol_black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBox_ship.Width, pictureBox_ship.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(35, 35, pictureBox_ship.Width, pictureBox_ship.Height);
                ship.DrawShip(gr);
                pictureBox_ship.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vehicle>(ev);

            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelBattSh_MouseDown(object sender, MouseEventArgs e)
        {
            labelBattSh.DoDragDrop(labelBattSh.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panel_ship_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel_ship_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    ship = new Ship((int)numericUpDown_mS.Value, (int)numericUpDown_W.Value, Color.Black);
                    break;
                case "Линкор":
                    ship = new Battleship((int)numericUpDown_mS.Value, (int)numericUpDown_W.Value, Color.Black, Color.DarkGreen,
                        checkBox_cannon.Checked, checkBox_rocket.Checked, 2, 3);
                    break;
            }
            DrawShip();
        }

        private void labelBasicCol_DragDrop(object sender, DragEventArgs e)
        {
            ship.SetBasicColor((Color)e.Data.GetData(typeof(Color)));
            DrawShip();
        }

        private void labelBasicCol_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopCol_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Battleship)
            {
                (ship as Battleship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }

        private void label_numCan_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Battleship)
            {
                switch (e.Data.GetData(DataFormats.Text).ToString())
                {
                    case "2":
                        (ship as Battleship).SetNum(e.Data.GetData(DataFormats.Text).ToString());
                        break;
                    case "4":
                        (ship as Battleship).SetNum(e.Data.GetData(DataFormats.Text).ToString());
                        break;
                    case "6":
                        (ship as Battleship).SetNum(e.Data.GetData(DataFormats.Text).ToString());
                        break;
                }
                DrawShip();
            }
        }

        private void label_numCan_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label_typeRocket_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Battleship)
            {
                (ship as Battleship).SetIDop((InterDop)e.Data.GetData(e.Data.GetFormats()[0]));
                DrawShip();
            }
        }

        private void label_typeRocket_DragEnter(object sender, DragEventArgs e)
        {
            if (typeof(InterDop).IsAssignableFrom(Type.GetType(e.Data.GetFormats()[0])))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

		private void label_rockStand_MouseDown(object sender, MouseEventArgs e)
		{
            InterDop ship = new StandartGuns(1);
            label_rockStand.DoDragDrop(ship, DragDropEffects.Move |
        DragDropEffects.Copy);
        }

		private void label_rocMod_MouseDown(object sender, MouseEventArgs e)
		{
            InterDop ship = new ModificGuns(2);
            label_rockStand.DoDragDrop(ship, DragDropEffects.Move |
        DragDropEffects.Copy);
        }

		private void label_rocAuto_MouseDown(object sender, MouseEventArgs e)
		{
            InterDop ship = new AutomaticGuns(3);
            label_rockStand.DoDragDrop(ship, DragDropEffects.Move |
        DragDropEffects.Copy);
        }

        private void label_can2_MouseDown(object sender, MouseEventArgs e)
        {
            label_can2.DoDragDrop(label_can2.Text, DragDropEffects.Move |
        DragDropEffects.Copy);
        }
        private void label_can4_MouseDown(object sender, MouseEventArgs e)
		{
            label_can4.DoDragDrop(label_can4.Text, DragDropEffects.Move |
        DragDropEffects.Copy);
        }
		private void label_can6_MouseDown(object sender, MouseEventArgs e)
		{
            label_can6.DoDragDrop(label_can6.Text, DragDropEffects.Move |
        DragDropEffects.Copy);
        }
	}
}

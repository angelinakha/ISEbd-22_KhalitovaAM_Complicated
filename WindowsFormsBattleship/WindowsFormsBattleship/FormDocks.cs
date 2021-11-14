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
    public partial class FormDocks : Form
    {
		private readonly Docks<Ship, AutomaticGuns> parking;

		public FormDocks()
		{
			InitializeComponent();
			parking = new Docks<Ship, AutomaticGuns>(pictureBox_doc.Width, pictureBox_doc.Height);
			Draw();

		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBox_doc.Width, pictureBox_doc.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBox_doc.Image = bmp;
		}

		private void button_parkShip_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var ship = new Ship(100, 1000, dialog.Color);
				if (parking + ship)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Доки переполнены");
				}
			}
		}

		private void button_parkBShip_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var ship = new Battleship(100, 1000, dialog.Color, dialogDop.Color,
				   true, true, 2, 3);
					if (parking + ship)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Доки переполнены");
					}
				}
			}
		}

		private void button_extract_Click(object sender, EventArgs e)
		{
			if (maskedTextBox_place.Text != "")
			{
				var ship = parking - Convert.ToInt32(maskedTextBox_place.Text);
				if (ship != null)
				{
					FormBattleship form = new FormBattleship();
					form.SetShip(ship);
					form.ShowDialog();
				}
				Draw();
			}
		}
		
        private void button_checking_Click(object sender, EventArgs e)
        {
			double index;
			if (maskedTextBox_numPlace.Text != "")
			{
				index = Convert.ToInt32(maskedTextBox_numPlace.Text);
			}
			else { return; }

			if (parking > index)
			{
				MessageBox.Show("До " + index + " места свободных доков нет");
			}
			else if (parking < index)
			{
				MessageBox.Show("До " + index + " места есть свободные доки");
			}
		}
    }
}

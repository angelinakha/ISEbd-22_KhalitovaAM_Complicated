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
	public partial class FormBattleship : Form
	{
		Graphics g;
		Battleship ship;

		public FormBattleship()
		{
			InitializeComponent();
			g = CreateGraphics();
			ship = new Battleship();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
			Graphics gr = Graphics.FromImage(bmp);
			ship.DrawShip(gr);
			pictureBoxShip.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int numOfGuns = Convert.ToInt32(comboBox_number.SelectedItem);
			ship = new Battleship();
			ship.Init(rnd.Next(200, 300), rnd.Next(1000, 2000), Color.Black,
		   Color.DarkOliveGreen, true, true, numOfGuns); ship.SetPosition(rnd.Next(10, 100),
		   rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					ship.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					ship.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					ship.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					ship.MoveTransport(Direction.Right);
					break;
			}
			Draw();

		}
    }
}

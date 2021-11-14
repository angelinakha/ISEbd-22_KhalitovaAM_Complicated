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
		private IShip ship;

		public FormBattleship()
		{
			InitializeComponent();
		}

		// Передача корабля на форму
		public void SetShip(IShip ship)
		{
			this.ship = ship;
			Draw();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
			Graphics gr = Graphics.FromImage(bmp);
			ship?.DrawShip(gr);
			pictureBoxShip.Image = bmp;
		}

		// Создание корабля
		private void buttonShipCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			ship = new Ship(rnd.Next(200, 300), rnd.Next(1000, 2000), Color.Black);
			ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxShip.Width,
		   pictureBoxShip.Height);
			Draw();
		}

		// Создание линкора
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int numOfGuns = Convert.ToInt32(comboBox_number.SelectedItem);
			int typeOfRocket= (radioButton_standart.Checked) ? 1 :
				(radioButton_modif.Checked) ? 2 :
				(radioButton_automatic.Checked ? 3 : 0);
			ship = new Battleship(rnd.Next(200, 300), rnd.Next(1000, 2000), Color.Black,
		   Color.DarkOliveGreen, true, true, numOfGuns, typeOfRocket); ship.SetPosition(rnd.Next(10, 100),
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
					ship?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					ship?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					ship?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					ship?.MoveTransport(Direction.Right);
					break;
			}
			Draw();

		}
    }
}

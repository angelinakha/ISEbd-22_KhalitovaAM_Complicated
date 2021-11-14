using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsBattleship
{
	public class Ship : Vehicle
	{
		/// Ширина отрисовки линкора
		private readonly int shipWidth = 110;
		/// Высота отрисовки линкора
		private readonly int shipHeight = 55;


		public Ship(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		protected Ship(int maxSpeed, float weight, Color mainColor, int shipWidth, int
		shipHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.shipWidth = shipWidth;
			this.shipHeight = shipHeight;
		}

		public override void DrawShip(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush mainBrush = new SolidBrush(MainColor);
			g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 70, _startPosY);
			g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX + 70, _startPosY + 50);
			g.DrawLine(pen, _startPosX, _startPosY, _startPosX, _startPosY + 50);
			g.DrawLine(pen, _startPosX + 70, _startPosY, _startPosX + 70 + 50, _startPosY + 50 / 2);
			g.DrawLine(pen, _startPosX + 70, _startPosY + 50, _startPosX + 70 + 50, _startPosY + 50 / 2);
			g.DrawEllipse(pen, _startPosX + 60, _startPosY + 50 / 4, 20, 20);
			g.DrawRectangle(pen, _startPosX + 30, _startPosY + 15, 20, 20);
			g.DrawRectangle(pen, _startPosX + 30 - 15, _startPosY + 20, 15, 10);
			g.FillRectangle(mainBrush, _startPosX - 5, _startPosY + 50 / 6, 5, 15);
			g.FillRectangle(mainBrush, _startPosX - 5, _startPosY + 4 * 50 / 6, 5, 15);
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - shipWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step >= 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step >= 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - shipHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
	}
}

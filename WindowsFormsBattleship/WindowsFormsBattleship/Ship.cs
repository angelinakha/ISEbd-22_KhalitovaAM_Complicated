using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Reflection;


namespace WindowsFormsBattleship
{
	public class Ship : Vehicle, IEquatable<Ship>, IComparable<Ship>, 
		IEnumerator<PropertyInfo>, IEnumerable<PropertyInfo>
	{
		/// Ширина отрисовки линкора
		private readonly int shipWidth = 110;
		/// Высота отрисовки линкора
		private readonly int shipHeight = 55;
		// Разделитель для записи информации по объекту в файл
		protected readonly char separator = ';';

		private int _currentIndex = -1;
		private PropertyInfo[] ShipPropertyInfo => Type.GetType("Ship").GetProperties();
		object IEnumerator.Current => ShipPropertyInfo[_currentIndex];
        public PropertyInfo Current => ShipPropertyInfo[_currentIndex];

        public Ship(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		// Конструктор для загрузки с файла
		public Ship(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
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
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}

		// Метод интерфейса IEquatable для класса Ship
		public bool Equals(Ship other)
		{
			if (other == null)
			{
				return false;
			}
			if (GetType().Name != other.GetType().Name)
			{
				return false;
			}
			if (MaxSpeed != other.MaxSpeed)
			{
				return false;
			}
			if (Weight != other.Weight)
			{
				return false;
			}
			if (MainColor != other.MainColor)
			{
				return false;
			}
			return true;
		}

		/// Перегрузка метода от object
		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Ship shipObj))
			{
				return false;
			}
			else
			{
				return Equals(shipObj);
			}
		}
		public int CompareTo(Object obj)
		{
			if (obj == null)
			{
				return -1;
			}
			if (!(obj is Ship shipObj))
			{
				return -1;
			}
			else
			{
				return CompareTo(shipObj);
			}
		}
		public int CompareTo(Ship b)
		{
			if (MaxSpeed != b.MaxSpeed)
			{
				return MaxSpeed.CompareTo(b.MaxSpeed);
			}
			if (Weight != b.Weight)
			{
				return Weight.CompareTo(b.Weight);
			}
			if (MainColor != b.MainColor)
			{
				return MainColor.Name.CompareTo(b.MainColor.Name);
			}
			return 0;
		}
		public void Dispose()
		{

		}
		public bool MoveNext()
		{
			_currentIndex++; 
			if (_currentIndex >= ShipPropertyInfo.Length)
			{
				Reset();
				return false;
			}
			return true;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public IEnumerator<PropertyInfo> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
		private void printPropert()
		{
			foreach (var proper in this)
			{
				Console.WriteLine(proper.Name.ToString());
			}
		}

	}
}

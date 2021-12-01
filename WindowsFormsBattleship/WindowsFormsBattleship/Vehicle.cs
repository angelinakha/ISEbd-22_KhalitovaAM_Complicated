using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsBattleship
{
	public abstract class Vehicle : IShip
	{
        /// Левая координата отрисовки линкора
        protected float _startPosX;
        /// Правая кооридината отрисовки линкора
        protected float _startPosY;
        /// Ширина окна отрисовки
        protected int _pictureWidth;
        /// Высота окна отрисовки
        protected int _pictureHeight;
        /// Максимальная скорость
        public int MaxSpeed { protected set; get; }
        /// Вес корабля
        public float Weight { protected set; get; }
        /// Основной цвет 
        public Color MainColor { protected set; get; }
        // Установка позиции
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void SetBasicColor(Color color)
        {
            MainColor = color;
        }
        public abstract void DrawShip(Graphics g);
        public abstract void MoveTransport(Direction direction);

    }
}

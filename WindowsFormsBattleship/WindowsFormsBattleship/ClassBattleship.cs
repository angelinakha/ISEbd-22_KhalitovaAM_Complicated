using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    public class Battleship
    {
        /// Левая координата отрисовки линкора
        private float _startPosX;
        /// Правая кооридината отрисовки линкора
        private float _startPosY;
        /// Ширина окна отрисовки
        private int _pictureWidth;
        /// Высота окна отрисовки
        private int _pictureHeight;
        /// Ширина отрисовки линкора
        private readonly int shipWidth = 120;
        /// Высота отрисовки линкора
        private readonly int shipHeight = 65;
        /// Максимальная скорость
        public int MaxSpeed { private set; get; }
        /// Вес корабля
        public float Weight { private set; get; }
        /// Основной цвет 
        public Color MainColor { private set; get; }
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия пушек
        public bool Cannon { private set; get; }
        // Признак наличия ракет
        public bool Rocket { private set; get; }
        //Доп класс
        private ClassDop Guns;


        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool rocket, bool cannon, int guns)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Rocket = rocket;
            Cannon = cannon;
            Guns = new ClassDop(guns);
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void DrawShip(Graphics g)
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
            // отрисовка пушек
            Brush dopBrush = new SolidBrush(DopColor);
            if (Cannon)
            {
                Guns.DrawGuns(g, pen, dopBrush, _startPosX, _startPosY);
            }
            // отрисовка ракеты 
            if (Rocket)
            {
                g.DrawLine(pen, _startPosX + 17, _startPosY + 5, _startPosX + 40, _startPosY + 5);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 10, _startPosX + 40, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 5, _startPosX + 17, _startPosY + 10);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 5, _startPosX + 50, _startPosY + 7);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 10, _startPosX + 50, _startPosY + 7);
                g.FillRectangle(dopBrush, _startPosX + 17, _startPosY + 5, 23, 5);

                g.DrawLine(pen, _startPosX + 17, _startPosY + 45, _startPosX + 40, _startPosY + 45);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 40, _startPosX + 40, _startPosY + 40);
                g.DrawLine(pen, _startPosX + 17, _startPosY + 45, _startPosX + 17, _startPosY + 40);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 45, _startPosX + 50, _startPosY + 42);
                g.DrawLine(pen, _startPosX + 40, _startPosY + 40, _startPosX + 50, _startPosY + 42);
                g.FillRectangle(dopBrush, _startPosX + 17, _startPosY + 40, 23, 5);
            }
        }

        /// Изменение направления перемещения
        public void MoveTransport(Direction direction)
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

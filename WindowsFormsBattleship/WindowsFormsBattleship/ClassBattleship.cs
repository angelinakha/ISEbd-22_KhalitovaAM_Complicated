using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBattleship
{
    public class Battleship : Ship
    {
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия пушек
        public bool Cannon { private set; get; }
        // Признак наличия ракет
        public bool Rocket { private set; get; }
        //Доп класс
        private ClassDop Guns;
        // Интерфейс с выбором оружия
        InterDop TypeRocket;


        public Battleship(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool rocket, bool cannon, int guns, int typeRocket) : base(maxSpeed, weight, mainColor, 120, 65)
        {
            DopColor = dopColor;
            Rocket = rocket;
            Cannon = cannon;
            Guns = new ClassDop(guns);
            if (typeRocket == 1)
            {
                TypeRocket = new StandartGuns(typeRocket, dopColor);
            }
            if (typeRocket == 2)
            {
                TypeRocket = new ModificGuns(typeRocket, dopColor);
            }
            if (typeRocket == 3)
            {
                TypeRocket = new AutomaticGuns(typeRocket, dopColor);
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            base.DrawShip(g);
            // отрисовка пушек
            if (Cannon)
            {
                Guns.DrawGuns(g, pen, dopBrush, _startPosX, _startPosY);
            }
            // отрисовка ракеты 
            if (Rocket)
            {
                TypeRocket.DrawDiffGuns(g, DopColor, _startPosX, _startPosY);
            }
        }
    }
}

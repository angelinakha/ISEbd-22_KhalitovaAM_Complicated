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
                TypeRocket = new StandartGuns(typeRocket);
            }
            if (typeRocket == 2)
            {
                TypeRocket = new ModificGuns(typeRocket);
            }
            if (typeRocket == 3)
            {
                TypeRocket = new AutomaticGuns(typeRocket);
            }
        }
        public Battleship(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Rocket = Convert.ToBoolean(strs[4]);
                Cannon = Convert.ToBoolean(strs[5]);
                if (strs[6] == "StandartGuns")
                {
                    TypeRocket = new StandartGuns(1);
                }
                else if (strs[6] == "ModificGuns")
                {
                    TypeRocket = new ModificGuns(2);
                }
                else if (strs[6] == "AutomaticGuns")
                {
                    TypeRocket = new AutomaticGuns(3);
                }
                Guns = new ClassDop(Convert.ToInt32(strs[7]));
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
        public void SetIDop(InterDop interDop)
        {
            TypeRocket = interDop;
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public void SetNum(string num)
		{
            Guns.SetNumCan(num);
		}
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Rocket}{separator}{Cannon}{separator}{TypeRocket.GetType().Name}{separator}{Guns.ToString()}";
        }
    }
}

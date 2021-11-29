using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBattleship
{
     class DocksCollection
    {
        // Словарь (хранилище) с парковками
        readonly Dictionary<string, Docks<Vehicle, ModificGuns>> parkingStages;
        // Возвращение списка названий праковок
        public List<string> Keys => parkingStages.Keys.ToList();
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Конструктор
        public DocksCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Docks<Vehicle, ModificGuns>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// Добавление парковки
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Docks<Vehicle, ModificGuns>(pictureWidth, pictureHeight));
        }

        /// Удаление парковки
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        /// Доступ к парковке
        public Docks<Vehicle, ModificGuns> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
        public Vehicle this[string key, int ind]
        {
            get
            {
                if (parkingStages.ContainsKey(key) && ind >= 0)
                {
                    return parkingStages[key]._places[ind];
                }
                return null;
            }
        }
    }
}

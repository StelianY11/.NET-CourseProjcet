using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_работа
{
    [Serializable]
    public class Stoka
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cena { get; set; }
        public int Kolichestvo { get; set; }
        public int Total => Cena * Kolichestvo;
    }

}

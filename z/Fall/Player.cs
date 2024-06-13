using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fall
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int LastNumber { get; set; }

        public bool IsBingo { get; set; }
       
        public List<Figure> ActiveFigures = new List<Figure>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class College
    {
        private List<Room> _Aquinas;
        internal List<Room> Aquinas
        {
            get { return _Aquinas; }
            set { _Aquinas = value; }
        }
        public College()
        {
            _Aquinas=new List<Room>();
         }
        public void Add(Room ThisRoom)
        {
            Aquinas.Add(ThisRoom);
        }
    }
}

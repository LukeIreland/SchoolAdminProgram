using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Global
    {
        static College _Aquinas;

        public static College Aquinas
        {
            get
            {
                return _Aquinas;
            }

            set
            {
                _Aquinas = value;
            }
        }

        static Global()
        {
            _Aquinas = new College();
        }
    }
}

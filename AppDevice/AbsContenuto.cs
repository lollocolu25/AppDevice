using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevice
{
    internal abstract class AbsContenuto
    {
        public string _Nome { get; set; }
        public int _Durata { get; set; }
        public string _Autore { get; set; }
        public string _Tipologia{ get; set; }
        public abstract void ToString();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaTVApp
{
    class Channel
    {
        public string Ime { get; set; }
        public bool watched { get; set; }
        public bool fav { get; set; }
        public Channel(string a) {
            Ime = a;
            watched = false;
            fav = false;
        }
    }
}

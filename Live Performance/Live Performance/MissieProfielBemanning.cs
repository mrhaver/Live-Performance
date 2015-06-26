using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    class MissieProfielBemanning
    {
        int aantalKapiteins;
        int aantalBiologen;
        int aantalPolitie;

        public MissieProfielBemanning(int aantalKapiteins, int aantalBiologen, int aantalPolitie)
        {
            this.aantalKapiteins = aantalKapiteins;
            this.aantalBiologen = aantalBiologen;
            this.aantalPolitie = aantalPolitie;
        }
    }
}

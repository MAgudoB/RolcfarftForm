using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRolcraft {
    class Races {
        public RacialsMaxMin Human = new RacialsMaxMin();
        public RacialsMaxMin patata = new RacialsMaxMin();
        public RacialsMaxMin Orc = new RacialsMaxMin();
        public RacialsMaxMin Tauren = new RacialsMaxMin();
        public RacialsMaxMin Dwarf = new RacialsMaxMin();
        public RacialsMaxMin Gnome = new RacialsMaxMin();
        public RacialsMaxMin Troll = new RacialsMaxMin();
        public RacialsMaxMin Kaldorei = new RacialsMaxMin();
        public RacialsMaxMin Queldorei = new RacialsMaxMin();
        public RacialsMaxMin Sindorei = new RacialsMaxMin();
        public RacialsMaxMin Draenei = new RacialsMaxMin();
        public RacialsMaxMin Goblin = new RacialsMaxMin();
        public RacialsMaxMin Ogre = new RacialsMaxMin();
        public RacialsMaxMin HighBorn = new RacialsMaxMin();
        public RacialsMaxMin WildHammer = new RacialsMaxMin();
        public RacialsMaxMin DarkIron = new RacialsMaxMin();
        public RacialsMaxMin AmaniDrakari = new RacialsMaxMin();
        public RacialsMaxMin Zandalari = new RacialsMaxMin();
        public RacialsMaxMin Tabid = new RacialsMaxMin();
        public RacialsMaxMin Vrykul = new RacialsMaxMin();
        public RacialsMaxMin Guthdorei = new RacialsMaxMin();
        public RacialsMaxMin SindoreiDemon = new RacialsMaxMin();
        public RacialsMaxMin KaldoreiDemon = new RacialsMaxMin();
        public RacialsMaxMin HumanDeath = new RacialsMaxMin();
        public RacialsMaxMin OrcDeath = new RacialsMaxMin();
        public RacialsMaxMin TrollDeath = new RacialsMaxMin();
        public RacialsMaxMin OrcDemon = new RacialsMaxMin();
        public RacialsMaxMin DraeneiDemon = new RacialsMaxMin();
        public RacialsMaxMin Semielf = new RacialsMaxMin();
        public RacialsMaxMin Semiorc = new RacialsMaxMin();
        public RacialsMaxMin Semiogre = new RacialsMaxMin();

        public Races() {
            Human.setRacials(8, 4, 7, 4, 7, 4, 7, 4, 8, 4, 8, 4, 7, 4);
            Orc.setRacials(9, 5, 7, 4, 8, 5, 7, 3, 8, 4, 6, 3, 7, 4);
            Dwarf.setRacials(8, 5, 6, 3, 10, 6, 8, 4, 5, 3, 9, 4, 6, 3);
            Tauren.setRacials(10, 5, 6, 3, 9, 5, 6, 3, 9, 5, 7, 4, 5, 3);
            Gnome.setRacials(5, 3, 10, 4, 5, 3, 10, 6, 7, 4, 8, 4, 7, 4);
            Kaldorei.setRacials(7, 3,8, 5, 7, 3, 7, 4, 8, 5, 7, 4, 8, 4);
            Draenei.setRacials(8, 3, 7, 3, 7, 5, 9, 6, 6, 3, 9, 5, 6, 3);
            Sindorei.setRacials(7, 3, 9, 4, 5, 3, 8, 5, 9, 5, 6, 4, 8, 4);
            Queldorei.setRacials(6, 3, 9, 4, 6, 3, 8, 6, 8, 4, 7, 4, 8, 4);
            Goblin.setRacials(6, 3, 10, 6, 6, 4, 9, 5, 6, 3, 6, 3, 9, 5);
            Ogre.setRacials(10, 5, 6, 3, 10, 6, 5, 3, 8, 5, 7, 3, 6, 3);
            Troll.setRacials(7, 3, 9, 5, 7, 4, 6, 3, 8, 5, 6, 3, 9, 5);
            HighBorn.setRacials(6, 3, 7, 4, 6, 3, 8, 5, 9, 5, 8, 4, 8, 4);
            WildHammer.setRacials(9, 5, 7, 4, 9, 5, 6, 4, 7, 3, 8, 4, 6, 3);
            DarkIron.setRacials(7, 4, 8, 4, 8, 5, 9, 5, 6, 4, 9, 3, 5, 3);
            AmaniDrakari.setRacials(8, 4, 8, 4, 8, 5, 5, 3, 8, 5, 7, 3, 8, 4);
            Zandalari.setRacials(7, 3, 8, 4, 6, 4, 8, 4, 8, 5, 8, 4, 7, 4);
            Tabid.setRacials(7, 3, 9, 4, 6, 4, 7, 5, 8, 4, 7, 4, 8, 4);
            Vrykul.setRacials(10, 5, 6, 3, 9, 5, 6, 3, 9, 5, 6, 4, 6, 3);
            HumanDeath.setRacials(8, 4, 6, 3, 9, 5, 7, 3, 7, 5, 9, 4, 6, 4);
            Guthdorei.setRacials(6, 3, 8, 3, 8, 4, 8, 5,7, 5, 8, 4, 7, 4);
            OrcDeath.setRacials(9, 5, 6, 3, 10, 6, 7, 2, 7, 5, 7, 3, 6, 4);
            TrollDeath.setRacials(7, 3, 8, 4, 9, 5, 6, 2, 7, 6, 7, 3, 8, 5);
            SindoreiDemon.setRacials(8, 4, 8, 4, 6, 4, 7, 4, 10, 5, 5, 3, 8, 4);
            OrcDemon.setRacials(10, 6, 6, 4, 9, 6, 6, 2, 9, 4, 5, 2, 7, 4);
            DraeneiDemon.setRacials(9, 4, 6, 3, 8, 6, 8, 5, 7, 3, 8, 4, 6, 3);
            KaldoreiDemon.setRacials(8, 4, 7, 5, 8, 4, 6, 3, 9, 5, 6, 3, 8, 4);
            Semielf.setRacials(7, 4, 8, 4, 7, 4, 7, 4, 8, 4, 8, 4, 7, 4);
            Semiogre.setRacials(10, 5, 7, 3, 9, 6, 6, 3, 8, 5, 6, 3, 6, 3);
            Semiorc.setRacials(8, 4, 7, 4, 8, 5, 8, 4, 7, 4, 8, 4, 6, 3);
        }
    }
}

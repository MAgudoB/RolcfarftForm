using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRolcraft {
    class RacialsMaxMin {
        public int fueMax;
        public int fueMin;
        public int agiMax;
        public int agiMin;
        public int aguMax;
        public int aguMin;
        public int intMax;
        public int intMin;
        public int espMax;
        public int espMin;
        public int volMax;
        public int volMin;
        public int perMax;
        public int perMin;

        public void setRacials(int fMax, int fMin, int aMax, int aMin, int rMax, int rMin, int iMax, int iMin, int eMax, int eMin, int vMax, int vMin, int pMax, int pMin) {
            fueMax = fMax;
            fueMin = fMin;
            agiMax = aMax;
            agiMin = aMin;
            aguMax = rMax;
            aguMin = rMin;
            intMax = iMax;
            intMin = iMin;
            espMax = eMax;
            espMin = eMin;
            volMax = vMax;
            volMin = vMin;
            perMax = pMax;
            perMin = pMin;
        }
    }
}

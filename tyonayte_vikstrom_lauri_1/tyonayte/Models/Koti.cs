using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public class Koti : AbstractState
    {
        public const String UriAlkuKoti = UriAlku + "Paikka=" + KotiString + "&Rahaa=";
        public override void MeneAlas(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override void MeneOikealle(Context context)
        {
            int UusiRaha = context.Rahaa;
            UusiRaha += KauppaRaha;
            context.Rahaa = UusiRaha;
            context.State = new Kauppa();
        }

        public override void MeneVasemmealle(Context context)
        {
            int UusiRaha = context.Rahaa;
            UusiRaha += BaariRaha;
            context.Rahaa = UusiRaha;
            context.State = new Baari();
        }

        public override void MeneYlos(Context context)
        {
            int UusiRaha = context.Rahaa;
            UusiRaha += TyoRaha;
            context.Rahaa = UusiRaha;
            context.State = new Tyo();
        }

        public override string GetStateName()
        {
            return KotiString;
        }

        public override String GetYlosUri()
        {
            return UriAlkuKoti;
        }
        public override String GetAlasUri()
        {
            return "#";
        }
        public override String GetOikealleUri()
        {
            return UriAlkuKoti;
        }
        public override String GetVasemmalleUri()
        {
            return UriAlkuKoti;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public class Baari : AbstractState
    {
        public const String UriAlkuBaari = UriAlku + "Paikka=" + BaariString + "&Rahaa=";
        public override void MeneAlas(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override void MeneOikealle(Context context)
        {
            context.State = new Koti();
        }

        public override void MeneVasemmealle(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override void MeneYlos(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override string GetStateName()
        {
            return BaariString;
        }
        public override String GetYlosUri()
        {
            return "#";
        }
        public override String GetAlasUri()
        {
            return "#";
        }
        public override String GetOikealleUri()
        {
            return UriAlkuBaari;
        }
        public override String GetVasemmalleUri()
        {
            return "#";
        }
    }
}

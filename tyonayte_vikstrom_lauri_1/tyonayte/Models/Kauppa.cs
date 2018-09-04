using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public class Kauppa : AbstractState
    {
        public const String UriAlkuKauppa = UriAlku + "Paikka=" + KauppaString + "&Rahaa=";
        public override void MeneAlas(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override void MeneOikealle(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override void MeneVasemmealle(Context context)
        {
            context.State = new Koti();
        }

        public override void MeneYlos(Context context)
        {
            //Täällä ei ole mitään.
        }

        public override string GetStateName()
        {
            return KauppaString;
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
            return "#";
        }
        public override String GetVasemmalleUri()
        {
            return UriAlkuKauppa;
        }
    }
}

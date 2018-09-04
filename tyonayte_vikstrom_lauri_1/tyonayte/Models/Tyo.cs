using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public class Tyo : AbstractState
    {
        public const String UriAlkuTyo = UriAlku + "Paikka=" + TyopaikkaString + "&Rahaa=";
        public override void MeneAlas(Context context)
        {
            context.State = new Koti();
        }

        public override void MeneOikealle(Context context)
        {
            //Täällä ei ole mitään.
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
            return TyopaikkaString;
        }

        public override String GetYlosUri()
        {
            return "#";
        }
        public override String GetAlasUri()
        {
            return UriAlkuTyo;
        }
        public override String GetOikealleUri()
        {
            return "#";
        }
        public override String GetVasemmalleUri()
        {
            return "#";
        }
    }
}

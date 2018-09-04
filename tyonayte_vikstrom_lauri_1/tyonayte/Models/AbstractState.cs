using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public abstract class AbstractState
    {
        public const int TyoRaha = 50;
        public const int BaariRaha = -50;
        public const int KauppaRaha = -100;
        public const String KotiString = "Koti";
        public const String BaariString = "Baari";
        public const String KauppaString = "Kauppa";
        public const String TyopaikkaString = "Työpaikka";
        public const String UriAlku = "/Home/Index?";

        public abstract void MeneYlos(Context context);
        public abstract void MeneOikealle(Context context);
        public abstract void MeneVasemmealle(Context context);
        public abstract void MeneAlas(Context context);
        public abstract String GetStateName();
        public abstract String GetYlosUri();
        public abstract String GetAlasUri();
        public abstract String GetOikealleUri();
        public abstract String GetVasemmalleUri();
    }
}

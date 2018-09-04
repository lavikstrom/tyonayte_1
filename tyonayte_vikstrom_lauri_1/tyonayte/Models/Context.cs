using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tyonayte.Models
{
    public class Context
    {
        private AbstractState _state;
        private int _rahaa;

        public AbstractState State { get => _state; set => _state = value; }
        public int Rahaa { get => _rahaa; set => _rahaa = value; }

        public Context(String stateName, int rahaa)
        {
            switch (stateName)
            {
                case AbstractState.BaariString:
                    _state = new Baari();
                    break;
                case AbstractState.KauppaString:
                    _state = new Kauppa();
                    break;
                case AbstractState.TyopaikkaString:
                    _state = new Tyo();
                    break;
                default:
                    _state = new Koti();
                    break;
            }
            _rahaa = rahaa;
        }

        public void MeneYlos()
        {
            _state.MeneYlos(this);
        }
        public void MeneOikealle()
        {
            _state.MeneOikealle(this);
        }
        public void MeneVasemmealle()
        {
            _state.MeneVasemmealle(this);
        }
        public void MeneAlas()
        {
            _state.MeneAlas(this);
        }

        public String GetCurrentState()
        {
            return _state.GetStateName();
        }
        public String GetYlosUri()
        {
            String UriAlku = _state.GetYlosUri();
            if (!UriAlku.Equals("#"))
            {
                UriAlku = UriAlku + _rahaa + "&Suunta="+Controllers.HomeController.ylosString;
            }
            return UriAlku;
        }
        public String GetAlasUri()
        {
            String UriAlku = _state.GetAlasUri();
            if (!UriAlku.Equals("#"))
            {
                UriAlku = UriAlku + _rahaa + "&Suunta=" + Controllers.HomeController.alasString;
            }
            return UriAlku;
        }
        public String GetOikealleUri()
        {
            String UriAlku = _state.GetOikealleUri();
            if (!UriAlku.Equals("#"))
            {
                UriAlku = UriAlku + _rahaa + "&Suunta=" + Controllers.HomeController.oikealleString;
            }
            return UriAlku;
        }
        public String GetVasemmalleUri()
        {
            String UriAlku = _state.GetVasemmalleUri();
            if (!UriAlku.Equals("#"))
            {
                UriAlku = UriAlku + _rahaa + "&Suunta=" + Controllers.HomeController.vasemmalleString;
            }
            return UriAlku;
        }
    }
}

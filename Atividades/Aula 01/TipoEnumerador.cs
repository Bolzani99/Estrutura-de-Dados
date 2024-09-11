using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_01
{
    public class TipoEnumerador
    {
        public enum Language
        {
            PTBR, EN, RU 
        }

        public Language _language = Language.PTBR;

        public TipoEnumerador()
        {

        }

        /*public TipoEnumerador(TipoEnumerador enum)
        {
            _language = enum;
        }
        */
        
        public Language GetLanguageEnum(string lang)
        {
            switch(lang.ToLower())
            {
                case "portugues" : return Language.PTBR;
                case "ingles" : return Language.EN;
                case "russo" : return Language.RU;
                default : return Language.PTBR;
            }
        }
    }        
}
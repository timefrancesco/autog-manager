using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class Comuni
    {
        private string m_Comune;
        private string m_Provincia;
        private string m_CodiceComune;
        private string m_CAP;

        public string Comune
        {
            get
            {
                return m_Comune;
            }
            set
            {
                m_Comune = value;
            }
        }

        public string Provincia
        {
            get
            {
                return m_Provincia;
            }
            set
            {
                m_Provincia = value;
            }
        }

        public string CodiceComune
        {
            get
            {
                return m_CodiceComune;
            }
            set
            {
                m_CodiceComune = value;
            }
        }

        public string CAP
        {
            get
            {
                return m_CAP;
            }
            set
            {
                m_CAP = value;
            }
        }
    }
}

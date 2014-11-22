using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class Contatto
    {
        private string m_numero;
        private string m_tipo;
        private string m_codicefiscale;
        private bool m_deleted;

        public string numero
        {
            get
            {
                return m_numero;
            }
            set
            {
                m_numero = value;
            }
        }

        public string tipo
        {
            get
            {
                return m_tipo;
            }
            set
            {
                m_tipo = value;
            }
        }

        public string codicefiscale
        {
            get
            {
                return m_codicefiscale;
            }
            set
            {
                m_codicefiscale = value;
            }
        }

        public bool deleted
        {
            get
            {
                return m_deleted;
            }
            set
            {
                m_deleted = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class Esame
    {
        private DateTime m_data;
        private string m_tipo;
        private string m_cat;
        private string m_esito;
        private string m_codicefiscale;
        private bool m_deleted;

        public DateTime DataEsame
        {
            get
            {
                return m_data;
            }
            set
            {
                m_data = value;
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

        public string Categoria
        {
            get
            {
                return m_cat;
            }
            set
            {
                m_cat = value;
            }
        }
        public string Esito
        {
            get
            {
                return m_esito;
            }
            set
            {
                m_esito = value;
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

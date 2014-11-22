using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class Patente
    {
        private string m_numero;
        private string m_tipo;
        private string m_categoria;
        private DateTime m_datarilascio;
        private DateTime m_datascadenza;
        private string m_enterilascio;
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

        public string categoria
        {
            get
            {
                return m_categoria;
            }
            set
            {
                m_categoria = value;
            }
        }

        public DateTime datarilascio
        {
            get
            {
                return m_datarilascio;
            }
            set
            {
                m_datarilascio = value;
            }
        }

        public DateTime datascadenza
        {
            get
            {
                return m_datascadenza;
            }
            set
            {
                m_datascadenza = value;
            }
        }

        public string enterilascio
        {
            get
            {
                return m_enterilascio;
            }
            set
            {
                m_enterilascio = value;
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

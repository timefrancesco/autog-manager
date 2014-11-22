using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class UtentiScadenza
    {
        private string m_Cognome;
        private string m_nome;
        private string m_Indirizzo;
        private string m_ComuneRes;
        private string m_ProvRes;
        private string m_NumeroPatente;
        private string m_CategoriaPatente;
        private DateTime m_ScadenzaPatente;

        public DateTime ScadenzaPatente
        {
            get
            {
                return m_ScadenzaPatente;
            }
            set
            {
                m_ScadenzaPatente = value;
            }
        }

        public string CategoriaPatente
        {
            get
            {
                return m_CategoriaPatente;
            }
            set
            {
                m_CategoriaPatente = value;
            }
        }

        public string NumeroPatente
        {
            get
            {
                return m_NumeroPatente;
            }
            set
            {
                m_NumeroPatente = value;
            }
        }

        public string ProvinciaRes
        {
            get
            {
                return m_ProvRes;
            }
            set
            {
                m_ProvRes = value;
            }
        }

        public string ComuneRes
        {
            get
            {
                return m_ComuneRes;
            }
            set
            {
                m_ComuneRes = value;
            }
        }

        public string Indirizzo
        {
            get
            {
                return m_Indirizzo;
            }
            set
            {
                m_Indirizzo = value;
            }
        }

        public string Nome
        {
            get
            {
                return m_nome;
            }
            set
            {
                m_nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return m_Cognome;
            }
            set
            {
                m_Cognome = value;
            }
        }

    }
}

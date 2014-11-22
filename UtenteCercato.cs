using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class UtenteCercato
    {
        private string m_Cognome;
        private string m_Nome;
        private DateTime m_DataNascita;
        private string m_ComuneNascita;
        private string m_ComuneResidenza;
        private string m_Indirizzo;
        private string m_CodiceFiscale;
        private bool m_IsMale;
        private string m_ProvNascita;
        private string m_ProvRes;
        private string m_CAP;
        private string m_foto;
        private int m_Id;

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

        public string Nome
        {
            get
            {
                return m_Nome;
            }
            set
            {
                m_Nome = value;
            }
        }

        public DateTime DataNascita
        {
            get
            {
                return m_DataNascita;
            }
            set
            {
                m_DataNascita = value;
            }
        }
        public string ComuneNascita
        {
            get
            {
                return m_ComuneNascita;
            }
            set
            {
                m_ComuneNascita = value;
            }
        }

        public string ComuneResidenza
        {
            get
            {
                return m_ComuneResidenza;
            }
            set
            {
                m_ComuneResidenza = value;
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
        public string CodiceFiscale
        {
            get
            {
                return m_CodiceFiscale;
            }
            set
            {
                m_CodiceFiscale = value;
            }
        }
        public bool Sex
        {
            get
            {
                return m_IsMale;
            }
            set
            {
                m_IsMale = value;
            }
        }
        public string ProvNascita
        {
            get
            {
                return m_ProvNascita;
            }
            set
            {
                m_ProvNascita = value;
            }
        }
        public string ProvResidenza
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
        public string foto
        {
            get
            {
                return m_foto;
            }
            set
            {
                m_foto = value;
            }
        }

        public int IdUtente
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
            }
        }

    }
}

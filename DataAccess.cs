using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VillaUserManager
{
    public class DataAccess
    {
        private static DataAccess _instance;
        private Comuni m_ComuneSelezionato = new Comuni();
        private int m_RigaSelezionata = -1;
        bool m_modifica = false;
        string m_CodiceFiscale;
        private Patente m_PatenteSelezionata;
        private Contatto m_ContattoSelezionato;
        private string m_stringaDaCercare;
        private UtenteCercato  m_UtenteSelezionato;
        private bool m_isPatModifyOn;
        private bool m_isContactModifyOn;
        private bool m_isExamModifyOn;
        private bool m_isUserModifyOn;
        private Esame m_EsameSelezionato;
        private string m_DButenti_Path;
        private string m_DBcomuni_Path;
        private bool m_IsServer;
        private string m_tempstring;
        


        public static DataAccess Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new DataAccess();

                return _instance;
            }
        }

      

        public Comuni ComuneSelezionato
        {
            get
            {
                return m_ComuneSelezionato;
            }
            set
            {
                m_ComuneSelezionato = value;
            }
        }

        public int RigaSelezionata
        {
            get
            {
                return m_RigaSelezionata;
            }
            set
            {
                m_RigaSelezionata = value;
            }
        }

        

        public bool IsModifyOn
        {
            get
            {
                return m_modifica;
            }
            set
            {
                m_modifica = value;
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

        public Patente PatenteSelezionata
        {
            get
            {
                return m_PatenteSelezionata;
            }
            set
            {
                m_PatenteSelezionata = value;
            }
        }

        public Contatto ContattoSelezionato
        {
            get
            {
                return m_ContattoSelezionato;
            }
            set
            {
                m_ContattoSelezionato = value;
            }
        }

        public string StringaDaCercare
        {
            get
            {
                return m_stringaDaCercare;
            }
            set
            {
                m_stringaDaCercare = value;
            }
        }

        public UtenteCercato UtenteSelezionato
        {
            get
            {
                return m_UtenteSelezionato;
            }
            set
            {
                m_UtenteSelezionato = value;
            }
        }

        public bool IsPatModifyOn
        {
            get
            {
                return m_isPatModifyOn;
            }
            set
            {
                m_isPatModifyOn = value;
            }
        }

        public bool IsContactModifyOn
        {
            get
            {
                return m_isContactModifyOn;
            }
            set
            {
                m_isContactModifyOn = value;
            }
        }

        public bool IsEsamModifyOn
        {
            get
            {
                return m_isExamModifyOn;
            }
            set
            {
                m_isExamModifyOn = value;
            }
        }

        public bool IsUserModifyOn
        {
            get
            {
                return m_isUserModifyOn;
            }
            set
            {
                m_isUserModifyOn = value;
            }
        }

        public Esame EsameSelezionato
        {
            get
            {
                return m_EsameSelezionato;
            }
            set
            {
                m_EsameSelezionato = value;
            }
        }

        public string Path_DB_Utenti
        {
            get
            {
                return m_DBcomuni_Path;
            }
            set
            {
                m_DBcomuni_Path = value;
            }
        }

        public string Path_DB_Comuni
        {
            get
            {
                return m_DButenti_Path;
            }
            set
            {
                m_DButenti_Path = value;
            }
        }

        public bool IsServer
        {
            get
            {
                return m_IsServer;
            }
            set
            {
                m_IsServer = value;
            }
        }

        public string TempString
        {
            get
            {
                return m_tempstring;
            }
            set
            {
                m_tempstring = value;
            }
        }

        private DataAccess()
        {


        }


    }
}

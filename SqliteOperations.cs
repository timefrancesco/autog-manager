using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace VillaUserManager
{
    public class SqliteOperations
    {
        string m_DBConnString = "Data Source = " + DataAccess.Instance.Path_DB_Utenti;// = C:\\develop\\VillaUserManager\\VillaUserManager\\bin\\Debug\\VillaDB.sqlite";

        public int InsertUserInDB(string Cognome, string Nome, bool IsMale, DateTime DataNascita, string ComuneNascita,
                            string ProvinciaNascita, string CodiceFiscale, string ComuneResidenza,
                                string ProvinciaResidenza, string Indirizzo, string CAP, string ImagePath)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
                DBcmd.CommandText = "INSERT INTO Utenti (Cognome,Nome,Sesso,DataNascita,ComuneNascita,ProvNascita,ComuneResid,ProvResid,Indirizzo,CAP,CodiceFiscale,Foto) VALUES (@Cognome,@Nome, @IsMale,@DataNascita,@ComuneNascita,@ProvinciaNascita,@ComuneResidenza,@ProvinciaResidenza,@Indirizzo,@CAP,@CodiceFiscale,@Foto)";



                DBcmd.Parameters.Add("@Cognome", DbType.String);
                DBcmd.Parameters.Add("@Nome", DbType.String);
                DBcmd.Parameters.Add("@IsMale", DbType.Boolean);
                DBcmd.Parameters.Add("@DataNascita", DbType.DateTime);
                DBcmd.Parameters.Add("@ComuneNascita", DbType.String);
                DBcmd.Parameters.Add("@ProvinciaNascita", DbType.String);
                DBcmd.Parameters.Add("@CodiceFiscale", DbType.String);
                DBcmd.Parameters.Add("@ComuneResidenza", DbType.String);
                DBcmd.Parameters.Add("@ProvinciaResidenza", DbType.String);
                DBcmd.Parameters.Add("@Indirizzo", DbType.String);
                DBcmd.Parameters.Add("@CAP", DbType.String);
                DBcmd.Parameters.Add("@Foto", DbType.String);
                DBcmd.Parameters["@Cognome"].Value = Cognome;
                DBcmd.Parameters["@Nome"].Value = Nome;
                DBcmd.Parameters["@IsMale"].Value = IsMale;
                DBcmd.Parameters["@DataNascita"].Value = DataNascita;
                DBcmd.Parameters["@ComuneNascita"].Value = ComuneNascita;
                DBcmd.Parameters["@ProvinciaNascita"].Value = ProvinciaNascita;
                DBcmd.Parameters["@CodiceFiscale"].Value = CodiceFiscale;
                DBcmd.Parameters["@ComuneResidenza"].Value = ComuneResidenza;
                DBcmd.Parameters["@ProvinciaResidenza"].Value = ProvinciaResidenza;
                DBcmd.Parameters["@Indirizzo"].Value = Indirizzo;
                DBcmd.Parameters["@CAP"].Value = CAP;
                DBcmd.Parameters["@Foto"].Value = ImagePath;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int ModifyUserInDB(string Cognome, string Nome, bool IsMale, DateTime DataNascita, string ComuneNascita,
                            string ProvinciaNascita, string CodiceFiscale, string ComuneResidenza,
                                string ProvinciaResidenza, string Indirizzo, string CAP, string ImagePath,string PREV_Cfisc)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
                DBcmd.CommandText = "UPDATE Utenti SET cognome=@Cognome, nome=@Nome,Sesso = @IsMale,DataNascita =@DataNascita ,ComuneNascita = @ComuneNascita,ProvNascita = @ProvinciaNascita,ComuneResid = @ComuneResidenza,ProvResid = @ProvinciaResidenza,Indirizzo = @Indirizzo,CAP = @CAP,CodiceFiscale = @CodiceFiscale,Foto = @Foto WHERE codicefiscale=@OldCodice";


                DBcmd.Parameters.Add("@Cognome", DbType.String);
                DBcmd.Parameters.Add("@Nome", DbType.String);
                DBcmd.Parameters.Add("@IsMale", DbType.Boolean);
                DBcmd.Parameters.Add("@DataNascita", DbType.DateTime);
                DBcmd.Parameters.Add("@ComuneNascita", DbType.String);
                DBcmd.Parameters.Add("@ProvinciaNascita", DbType.String);
                DBcmd.Parameters.Add("@CodiceFiscale", DbType.String);
                DBcmd.Parameters.Add("@ComuneResidenza", DbType.String);
                DBcmd.Parameters.Add("@ProvinciaResidenza", DbType.String);
                DBcmd.Parameters.Add("@Indirizzo", DbType.String);
                DBcmd.Parameters.Add("@CAP", DbType.String);
                DBcmd.Parameters.Add("@Foto", DbType.String);
                DBcmd.Parameters.Add("@OldCodice", DbType.String);
                DBcmd.Parameters["@Cognome"].Value = Cognome;
                DBcmd.Parameters["@Nome"].Value = Nome;
                DBcmd.Parameters["@IsMale"].Value = IsMale;
                DBcmd.Parameters["@DataNascita"].Value = DataNascita;
                DBcmd.Parameters["@ComuneNascita"].Value = ComuneNascita;
                DBcmd.Parameters["@ProvinciaNascita"].Value = ProvinciaNascita;
                DBcmd.Parameters["@CodiceFiscale"].Value = CodiceFiscale;
                DBcmd.Parameters["@ComuneResidenza"].Value = ComuneResidenza;
                DBcmd.Parameters["@ProvinciaResidenza"].Value = ProvinciaResidenza;
                DBcmd.Parameters["@Indirizzo"].Value = Indirizzo;
                DBcmd.Parameters["@CAP"].Value = CAP;
                DBcmd.Parameters["@Foto"].Value = ImagePath;
                DBcmd.Parameters["@OldCodice"].Value = PREV_Cfisc;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int RemoveUserFromDB(string cfiscale)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string cmd = string.Format("delete  from utenti where codicefiscale = \"{0}\"", cfiscale);
                //INSERISCO DATI IN DB
                DBcmd.CommandText = cmd;
                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int CheckIfAlreadyExist(string Column, string table, string datatofind)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = string.Format("SELECT count(*) {0} from {1} where {0} = \"{2}\"", Column, table, datatofind);//"SELECT count(*) codicefiscale from utenti where codicefiscale = 'sdf'";
                //INSERISCO DATI IN DB
                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    DBreader.Read();
                    ret = DBreader.GetInt32(0);

                }
                else
                    ret = 0;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ret;
        }

        public int InsertLicenseInDB(string numero, string tipo, string categoria,
                            DateTime datarilascio, DateTime datascadenza, string enterilascio,
                                string codicefiscale)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
                DBcmd.CommandText = "INSERT INTO Patenti (numero,tipo,categoria,Rilasciata,Scadenza,enterilascio,Codice) VALUES (@numero,@tipo, @categoria,@datarilascio,@datascadenza,@enterilascio,@codicefiscale)";



                DBcmd.Parameters.Add("@numero", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@categoria", DbType.String);
                DBcmd.Parameters.Add("@datarilascio", DbType.DateTime);
                DBcmd.Parameters.Add("@datascadenza", DbType.DateTime);
                DBcmd.Parameters.Add("@enterilascio", DbType.String);
                DBcmd.Parameters.Add("@codicefiscale", DbType.String);
                DBcmd.Parameters["@numero"].Value = numero;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@categoria"].Value = categoria;
                DBcmd.Parameters["@datarilascio"].Value = datarilascio;
                DBcmd.Parameters["@datascadenza"].Value = datascadenza;
                DBcmd.Parameters["@enterilascio"].Value = enterilascio;
                DBcmd.Parameters["@CodiceFiscale"].Value = codicefiscale;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int ModifyLicenseInDB(string numero, string tipo, string categoria,
                            DateTime datarilascio, DateTime datascadenza, string enterilascio,
                                string codicefiscale, string oldNum, string oldcfisc, bool deleted)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB

                DBcmd.CommandText = "UPDATE Patenti SET numero=@numero, tipo=@tipo,categoria = @categoria,Rilasciata =@datarilascio ,Scadenza = @datascadenza,enterilascio = @enterilascio,Codice = @codicefiscale, deleted = @deleted WHERE Codice=@oldcfisc AND numero= @oldNum";


                DBcmd.Parameters.Add("@numero", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@categoria", DbType.String);
                DBcmd.Parameters.Add("@datarilascio", DbType.DateTime);
                DBcmd.Parameters.Add("@datascadenza", DbType.DateTime);
                DBcmd.Parameters.Add("@enterilascio", DbType.String);
                DBcmd.Parameters.Add("@codicefiscale", DbType.String);
                DBcmd.Parameters.Add("@deleted", DbType.Boolean);
                DBcmd.Parameters.Add("@oldNum", DbType.String);
                DBcmd.Parameters.Add("@oldcfisc", DbType.String);
                DBcmd.Parameters["@numero"].Value = numero;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@categoria"].Value = categoria;
                DBcmd.Parameters["@datarilascio"].Value = datarilascio;
                DBcmd.Parameters["@datascadenza"].Value = datascadenza;
                DBcmd.Parameters["@enterilascio"].Value = enterilascio;
                DBcmd.Parameters["@CodiceFiscale"].Value = codicefiscale;
                DBcmd.Parameters["@deleted"].Value = deleted;
                DBcmd.Parameters["@oldNum"].Value = oldNum;
                DBcmd.Parameters["@oldcfisc"].Value = oldcfisc;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int InsertContactInDB(string numero, string tipo, string codicefiscale)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
                DBcmd.CommandText = "INSERT INTO Contatti (contatto,tipo,codice) VALUES (@numero,@tipo, @codicefiscale)";

                DBcmd.Parameters.Add("@numero", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@codicefiscale", DbType.String);
                DBcmd.Parameters["@numero"].Value = numero;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@CodiceFiscale"].Value = codicefiscale;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int ModifyContactInDB(string numero, string tipo, string codicefiscale, string oldcodice, string oldtipo, string oldnumero, bool deleted)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

       
                

                DBcmd.CommandText = "UPDATE Contatti SET contatto=@numero, tipo=@tipo,codice = @codicefiscale, deleted = @deleted WHERE codice=@oldcodice AND contatto= @oldnumero AND tipo = @oldtipo";


                DBcmd.Parameters.Add("@numero", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@codicefiscale", DbType.String);
                DBcmd.Parameters.Add("@deleted", DbType.Boolean);
                DBcmd.Parameters.Add("@oldcodice", DbType.String);
                DBcmd.Parameters.Add("@oldtipo", DbType.String);
                DBcmd.Parameters.Add("@oldnumero", DbType.String);
                DBcmd.Parameters["@numero"].Value = numero;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@CodiceFiscale"].Value = codicefiscale;
                DBcmd.Parameters["@deleted"].Value = deleted;
                DBcmd.Parameters["@oldcodice"].Value = oldcodice;
                DBcmd.Parameters["@oldtipo"].Value = oldtipo;
                DBcmd.Parameters["@oldnumero"].Value = oldnumero;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }


        public int InsertExamInDB(string codicefiscale, string tipo, DateTime data, string cat, string esito)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
                DBcmd.CommandText = "INSERT INTO Esami (CODICE,TIPO,DATA,CAT,ESITO) VALUES (@codice,@tipo, @data,@categoria,@esito)";

                DBcmd.Parameters.Add("@codice", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@data", DbType.DateTime);
                DBcmd.Parameters.Add("@categoria", DbType.String);
                DBcmd.Parameters.Add("@esito", DbType.String);
                DBcmd.Parameters["@codice"].Value = codicefiscale;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@data"].Value = data;
                DBcmd.Parameters["@categoria"].Value = cat;
                DBcmd.Parameters["@esito"].Value = esito;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int ModifyExamInDB(string codicefiscale, string tipo, DateTime data, string cat, string esito, string oldcfisc, string oldtipo, string oldcat, DateTime olddata, bool deleted)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);

                //INSERISCO DATI IN DB
               
                DBcmd.CommandText = "UPDATE Esami SET CODICE=@codice, TIPO=@tipo,DATA = @data,CAT =@categoria ,ESITO = @esito, DELETED = @deleted WHERE CODICE=@oldcfisc AND DATA =@olddata and TIPO=@oldtipo and CAT = @oldcat";


                DBcmd.Parameters.Add("@codice", DbType.String);
                DBcmd.Parameters.Add("@tipo", DbType.String);
                DBcmd.Parameters.Add("@data", DbType.DateTime);
                DBcmd.Parameters.Add("@categoria", DbType.String);
                DBcmd.Parameters.Add("@esito", DbType.String);
                DBcmd.Parameters.Add("@deleted", DbType.Boolean);
                DBcmd.Parameters.Add("@oldcfisc", DbType.String);
                DBcmd.Parameters.Add("@olddata", DbType.DateTime);
                DBcmd.Parameters.Add("@oldtipo", DbType.String);
                DBcmd.Parameters.Add("@oldcat", DbType.String);
                DBcmd.Parameters["@codice"].Value = codicefiscale;
                DBcmd.Parameters["@tipo"].Value = tipo;
                DBcmd.Parameters["@data"].Value = data;
                DBcmd.Parameters["@categoria"].Value = cat;
                DBcmd.Parameters["@esito"].Value = esito;
                DBcmd.Parameters["@deleted"].Value = deleted;
                DBcmd.Parameters["@oldcfisc"].Value = oldcfisc;
                DBcmd.Parameters["@olddata"].Value = olddata;
                DBcmd.Parameters["@oldtipo"].Value = oldtipo;
                DBcmd.Parameters["@oldcat"].Value = oldcat;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public BindingList<UtenteCercato> ReadAllUsersExtDB(string databasepathandname)
        {

            string ConnString = "Data Source = " + databasepathandname;

            BindingList<UtenteCercato> ListaUtenti = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(ConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = "SELECT * from Utenti";

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                       

                        UtenteCercato utentetrovato = new UtenteCercato();
                        utentetrovato.IdUtente = DBreader.GetInt32(0);
                        utentetrovato.Cognome = DBreader.GetString(1);
                        utentetrovato.Nome = DBreader.GetString(2);
                        utentetrovato.DataNascita = DBreader.GetDateTime(4);
                        utentetrovato.ComuneNascita = DBreader.GetString(5);
                        utentetrovato.ComuneResidenza = DBreader.GetString(7);
                        utentetrovato.Indirizzo = DBreader.GetString(9);
                        utentetrovato.CodiceFiscale = DBreader.GetString(11);
                        utentetrovato.ProvNascita = DBreader.GetString(6);
                        utentetrovato.ProvResidenza = DBreader.GetString(8);
                        utentetrovato.Sex = DBreader.GetBoolean(3);
                        utentetrovato.CAP = DBreader.GetString(10);
                        utentetrovato.foto = DBreader.GetString(12);
                        utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                        ListaUtenti.Add(utentetrovato);
                          

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaUtenti;
        }


        public BindingList<Patente> ReadAllLicense(string Column, string table, string datatofind)
        {


            BindingList<Patente> ListaPatente = new BindingList<Patente>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = string.Format("SELECT * from {1} where {0} = \"{2}\" and deleted = \"0\"", Column, table, datatofind.ToUpper());//SELECT  * from patenti where codice = 'sdf'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Patente PatenteTrovata = new Patente();

                        PatenteTrovata.numero = DBreader.GetString(1);
                        PatenteTrovata.categoria = DBreader.GetString(2);
                        PatenteTrovata.datarilascio = DBreader.GetDateTime(3);
                        PatenteTrovata.datascadenza = DBreader.GetDateTime(4);
                        PatenteTrovata.enterilascio = DBreader.GetString(5);
                        PatenteTrovata.codicefiscale = DBreader.GetString(6);
                        PatenteTrovata.tipo = DBreader.GetString(7);
                        


                        ListaPatente.Add(PatenteTrovata);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaPatente;
        }

        public BindingList<Contatto> ReadAllContatcs(string Column, string table, string datatofind)
        {


            BindingList<Contatto> ListaContatti = new BindingList<Contatto>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = string.Format("SELECT * from {1} where {0} = \"{2}\" and Deleted = \"0\"", Column, table, datatofind.ToUpper());//SELECT  * from patenti where codice = 'sdf'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Contatto contattotrovato = new Contatto();

                        contattotrovato.numero = DBreader.GetString(1);
                        contattotrovato.codicefiscale =  DBreader.GetString(2);
                        contattotrovato.tipo = DBreader.GetString(3);


                        ListaContatti.Add(contattotrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaContatti;
        }

        public BindingList<Esame> ReadAllExams(string Column, string table, string datatofind)
        {


            BindingList<Esame> ListaEsami = new BindingList<Esame>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = string.Format("SELECT * from {1} where {0} = \"{2}\" and deleted = \"0\"", Column, table, datatofind.ToUpper());//SELECT  * from patenti where codice = 'sdf'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Esame Esametrovato = new Esame();

                        Esametrovato.codicefiscale = DBreader.GetString(1);
                        Esametrovato.tipo = DBreader.GetString(2);
                        Esametrovato.DataEsame = DBreader.GetDateTime(3);
                        Esametrovato.Categoria = DBreader.GetString(4);
                        Esametrovato.Esito = DBreader.GetString(5);


                        ListaEsami.Add(Esametrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaEsami;
        }

        public int RemoveLicense(string codicefiscale, string numero)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string str = string.Format("UPDATE Patenti SET Deleted = '1' where CODICE = \"{0}\" and numero =\"{1}\"", codicefiscale, numero);


             
                //INSERISCO DATI IN DB
                DBcmd.CommandText = str;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int RemoveContact(string codicefiscale, string numero)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string str = string.Format("UPDATE Contatti SET Deleted = '1' where CODICE = \"{0}\" and contatto =\"{1}\"", codicefiscale, numero);


                
                //INSERISCO DATI IN DB
                DBcmd.CommandText = str;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public int RemoveExam(string codicefiscale, string data, string esito, string tipo, string categoria)
        {
            int ret = -1;

            //Apro la connessione al database
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string str = string.Format("UPDATE Esami SET Deleted = '1' where CODICE = \"{0}\" and data =\"{1}\" and esito =\"{2}\" and cat =\"{3}\" and tipo =\"{4}\"", codicefiscale, data, esito, categoria, tipo);

         

                //INSERISCO DATI IN DB
                DBcmd.CommandText = str;

                DBcmd.ExecuteNonQuery();
                ret = 1;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            finally
            {
                DBConn.Close();
            }

            return ret;
        }

        public BindingList<UtenteCercato> ViewAllUsers()
        {
            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                strcmd = string.Format("SELECT * from utenti");
                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        UtenteCercato utentetrovato = new UtenteCercato();
                        utentetrovato.IdUtente = DBreader.GetInt32(0);
                        utentetrovato.Cognome = DBreader.GetString(1);
                        utentetrovato.Nome = DBreader.GetString(2);
                        utentetrovato.DataNascita = DBreader.GetDateTime(4);
                        utentetrovato.ComuneNascita = DBreader.GetString(5);
                        utentetrovato.ComuneResidenza = DBreader.GetString(7);
                        utentetrovato.Indirizzo = DBreader.GetString(9);
                        utentetrovato.CodiceFiscale = DBreader.GetString(11);
                        utentetrovato.ProvNascita = DBreader.GetString(6);
                        utentetrovato.ProvResidenza = DBreader.GetString(8);
                        utentetrovato.Sex = DBreader.GetBoolean(3);
                        utentetrovato.CAP = DBreader.GetString(10);
                        utentetrovato.foto = DBreader.GetString(12);
                        utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                        UtentiTrovati.Add(utentetrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUser(string nome, string cognome)
        {


            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                if (nome.Equals(string.Empty))
                    strcmd = string.Format("SELECT * from utenti where cognome like \"{0}%\"", cognome);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                else
                    strcmd = string.Format("SELECT * from utenti where cognome = \"{0}\" and nome = \"{1}%\"", cognome, nome);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        UtenteCercato utentetrovato = new UtenteCercato();
                        utentetrovato.IdUtente = DBreader.GetInt32(0);
                        utentetrovato.Cognome = DBreader.GetString(1);
                        utentetrovato.Nome = DBreader.GetString(2);
                        utentetrovato.DataNascita = DBreader.GetDateTime(4);
                        utentetrovato.ComuneNascita = DBreader.GetString(5);
                        utentetrovato.ComuneResidenza = DBreader.GetString(7);
                        utentetrovato.Indirizzo = DBreader.GetString(9);
                        utentetrovato.CodiceFiscale = DBreader.GetString(11);
                        utentetrovato.ProvNascita = DBreader.GetString(6);
                        utentetrovato.ProvResidenza = DBreader.GetString(8);
                        utentetrovato.Sex = DBreader.GetBoolean(3);
                        utentetrovato.CAP = DBreader.GetString(10);
                        utentetrovato.foto = DBreader.GetString(12);
                        utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                        UtentiTrovati.Add(utentetrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUserByTown(string comune)
        {


            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                strcmd = string.Format("SELECT * from utenti where comuneresid = \"{0}\"", comune);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        UtenteCercato utentetrovato = new UtenteCercato();
                        utentetrovato.IdUtente = DBreader.GetInt32(0);
                        utentetrovato.Cognome = DBreader.GetString(1);
                        utentetrovato.Nome = DBreader.GetString(2);
                        utentetrovato.DataNascita = DBreader.GetDateTime(4);
                        utentetrovato.ComuneNascita = DBreader.GetString(5);
                        utentetrovato.ComuneResidenza = DBreader.GetString(7);
                        utentetrovato.Indirizzo = DBreader.GetString(9);
                        utentetrovato.CodiceFiscale = DBreader.GetString(11);
                        utentetrovato.ProvNascita = DBreader.GetString(6);
                        utentetrovato.ProvResidenza = DBreader.GetString(8);
                        utentetrovato.Sex = DBreader.GetBoolean(3);
                        utentetrovato.CAP = DBreader.GetString(10);
                        utentetrovato.foto = DBreader.GetString(12);
                        utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);


                        UtentiTrovati.Add(utentetrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUserByLicense(string numero)
        {
            BindingList<string> CFiscTrovati = new BindingList<string>();

            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                strcmd = string.Format("SELECT * from patenti where numero = \"{0}\"", numero);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        string Cfisc = DBreader.GetString(6);
                        CFiscTrovati.Add(Cfisc);

                    }

                }
                DBreader.Close();
                if (CFiscTrovati.Count > 0)
                {
                    foreach (string codicefisc in CFiscTrovati)
                    {
                        strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", codicefisc);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                        DBcmd.CommandText = strcmd;
                        DBreader = DBcmd.ExecuteReader();
                        if (DBreader.HasRows)
                        {
                            while (DBreader.Read())
                            {
                                UtenteCercato utentetrovato = new UtenteCercato();
                                utentetrovato.IdUtente = DBreader.GetInt32(0);
                                utentetrovato.Cognome = DBreader.GetString(1);
                                utentetrovato.Nome = DBreader.GetString(2);
                                utentetrovato.DataNascita = DBreader.GetDateTime(4);
                                utentetrovato.ComuneNascita = DBreader.GetString(5);
                                utentetrovato.ComuneResidenza = DBreader.GetString(7);
                                utentetrovato.Indirizzo = DBreader.GetString(9);
                                utentetrovato.CodiceFiscale = DBreader.GetString(11);
                                utentetrovato.ProvNascita = DBreader.GetString(6);
                                utentetrovato.ProvResidenza = DBreader.GetString(8);
                                utentetrovato.Sex = DBreader.GetBoolean(3);
                                utentetrovato.CAP = DBreader.GetString(10);
                                utentetrovato.foto = DBreader.GetString(12);
                                utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                                UtentiTrovati.Add(utentetrovato);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUserByPhone(string numero)
        {
            BindingList<string> CFiscTrovati = new BindingList<string>();

            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                strcmd = string.Format("SELECT * from contatti where contatto = \"{0}\"", numero);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        string Cfisc = DBreader.GetString(2);
                        CFiscTrovati.Add(Cfisc);

                    }

                }
                DBreader.Close();
                if (CFiscTrovati.Count > 0)
                {
                    foreach (string codicefisc in CFiscTrovati)
                    {
                        strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", codicefisc);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                        DBcmd.CommandText = strcmd;
                        DBreader = DBcmd.ExecuteReader();
                        if (DBreader.HasRows)
                        {
                            while (DBreader.Read())
                            {
                                UtenteCercato utentetrovato = new UtenteCercato();
                                utentetrovato.IdUtente = DBreader.GetInt32(0);
                                utentetrovato.Cognome = DBreader.GetString(1);
                                utentetrovato.Nome = DBreader.GetString(2);
                                utentetrovato.DataNascita = DBreader.GetDateTime(4);
                                utentetrovato.ComuneNascita = DBreader.GetString(5);
                                utentetrovato.ComuneResidenza = DBreader.GetString(7);
                                utentetrovato.Indirizzo = DBreader.GetString(9);
                                utentetrovato.CodiceFiscale = DBreader.GetString(11);
                                utentetrovato.ProvNascita = DBreader.GetString(6);
                                utentetrovato.ProvResidenza = DBreader.GetString(8);
                                utentetrovato.Sex = DBreader.GetBoolean(3);
                                utentetrovato.CAP = DBreader.GetString(10);
                                utentetrovato.foto = DBreader.GetString(12);
                                utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                                UtentiTrovati.Add(utentetrovato);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUserByLicenseSCAD(string dadata, string adata, string cat, string tipodoc)
        {
            BindingList<string> CFiscTrovati = new BindingList<string>();

            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DateTime DaData = Convert.ToDateTime(dadata);
                DateTime AData = Convert.ToDateTime(dadata); //Trucco
                if (!adata.Equals(string.Empty))
                    AData = Convert.ToDateTime(adata);

                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;

                strcmd = string.Format("SELECT  * from patenti where tipo = \"{0}\" and scadenza >= \"{1}\"", tipodoc,dadata);
                if (!adata.Equals(String.Empty))
                    strcmd = string.Format("{0} and scadenza <= \"{1}\"", strcmd, adata);
                if (!cat.Equals(string.Empty))
                    strcmd = string.Format("{0} and categoria = \"{1}\"", strcmd, cat);



                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        string Cfisc = DBreader.GetString(6);
                        CFiscTrovati.Add(Cfisc);

                    }

                }
                DBreader.Close();
                if (CFiscTrovati.Count > 0)
                {
                    foreach (string codicefisc in CFiscTrovati)
                    {
                        strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", codicefisc);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                        DBcmd.CommandText = strcmd;
                        DBreader = DBcmd.ExecuteReader();
                        if (DBreader.HasRows)
                        {
                            while (DBreader.Read())
                            {
                                UtenteCercato utentetrovato = new UtenteCercato();
                                utentetrovato.IdUtente = DBreader.GetInt32(0);
                                utentetrovato.Cognome = DBreader.GetString(1);
                                utentetrovato.Nome = DBreader.GetString(2);
                                utentetrovato.DataNascita = DBreader.GetDateTime(4);
                                utentetrovato.ComuneNascita = DBreader.GetString(5);
                                utentetrovato.ComuneResidenza = DBreader.GetString(7);
                                utentetrovato.Indirizzo = DBreader.GetString(9);
                                utentetrovato.CodiceFiscale = DBreader.GetString(11);
                                utentetrovato.ProvNascita = DBreader.GetString(6);
                                utentetrovato.ProvResidenza = DBreader.GetString(8);
                                utentetrovato.Sex = DBreader.GetBoolean(3);
                                utentetrovato.CAP = DBreader.GetString(10);
                                utentetrovato.foto = DBreader.GetString(12);
                                utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                                UtentiTrovati.Add(utentetrovato);
                            }
                        }
                        DBreader.Close();
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtenteCercato> SearchUserByLicenseSCAD_Doc(string connstr)
        {
            BindingList<string> CFiscTrovati = new BindingList<string>();

            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
               
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = connstr;               

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        string Cfisc = DBreader.GetString(6);
                        CFiscTrovati.Add(Cfisc);

                    }

                }
                DBreader.Close();
                if (CFiscTrovati.Count > 0)
                {
                    foreach (string codicefisc in CFiscTrovati)
                    {
                        strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", codicefisc);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                        DBcmd.CommandText = strcmd;
                        DBreader = DBcmd.ExecuteReader();
                        if (DBreader.HasRows)
                        {
                            while (DBreader.Read())
                            {
                                UtenteCercato utentetrovato = new UtenteCercato();
                                utentetrovato.IdUtente = DBreader.GetInt32(0);
                                utentetrovato.Cognome = DBreader.GetString(1);
                                utentetrovato.Nome = DBreader.GetString(2);
                                utentetrovato.DataNascita = DBreader.GetDateTime(4);
                                utentetrovato.ComuneNascita = DBreader.GetString(5);
                                utentetrovato.ComuneResidenza = DBreader.GetString(7);
                                utentetrovato.Indirizzo = DBreader.GetString(9);
                                utentetrovato.CodiceFiscale = DBreader.GetString(11);
                                utentetrovato.ProvNascita = DBreader.GetString(6);
                                utentetrovato.ProvResidenza = DBreader.GetString(8);
                                utentetrovato.Sex = DBreader.GetBoolean(3);
                                utentetrovato.CAP = DBreader.GetString(10);
                                utentetrovato.foto = DBreader.GetString(12);
                                utentetrovato.foto = string.Format("{0}\\ProfilePictures\\{1}", Path.GetDirectoryName(DataAccess.Instance.Path_DB_Utenti), utentetrovato.foto);

                                UtentiTrovati.Add(utentetrovato);
                            }
                        }
                        DBreader.Close();
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<UtentiScadenza> SearchUserByLicenseSCAD_ForMail(string dadata, string adata, string cat, string tipodoc)
        {
            BindingList<Patente> PatentiTrovate = new BindingList<Patente>();

            BindingList<UtentiScadenza> UtentiTrovati = new BindingList<UtentiScadenza>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DateTime DaData = Convert.ToDateTime(dadata);
                DateTime AData = Convert.ToDateTime(dadata); //Trucco
                if (!adata.Equals(string.Empty))
                    AData = Convert.ToDateTime(adata);

                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;

                strcmd = string.Format("SELECT  * from patenti where tipo = \"{0}\" and scadenza >= \"{1}\"", tipodoc, dadata);
                if (!adata.Equals(String.Empty))
                    strcmd = string.Format("{0} and scadenza <= \"{1}\"", strcmd, adata);
                if (!cat.Equals(string.Empty))
                    strcmd = string.Format("{0} and categoria = \"{1}\"", strcmd, cat);



                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        Patente pattrov = new Patente();
                        pattrov.numero = DBreader.GetString(1);
                        pattrov.categoria = DBreader.GetString(2);
                        pattrov.datascadenza = DBreader.GetDateTime(4);
                        pattrov.codicefiscale = DBreader.GetString(6);
                        PatentiTrovate.Add(pattrov);

                    }

                }
                DBreader.Close();
                if (PatentiTrovate.Count > 0)
                {
                    foreach (Patente patenti in PatentiTrovate)
                    {
                        strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", patenti.codicefiscale);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'
                        DBcmd.CommandText = strcmd;
                        DBreader = DBcmd.ExecuteReader();
                        if (DBreader.HasRows)
                        {
                            while (DBreader.Read())
                            {


                                UtentiScadenza utentetrovato = new UtentiScadenza();
                                
                                utentetrovato.Cognome = DBreader.GetString(1);
                                utentetrovato.Nome = DBreader.GetString(2);
                                utentetrovato.ComuneRes = DBreader.GetString(7);
                                utentetrovato.Indirizzo = DBreader.GetString(9);
                                utentetrovato.ProvinciaRes = DBreader.GetString(8);
                                utentetrovato.CategoriaPatente = patenti.categoria;
                                utentetrovato.NumeroPatente = patenti.numero;
                                utentetrovato.ScadenzaPatente = patenti.datascadenza;

                                UtentiTrovati.Add(utentetrovato);
                            }
                        }
                        DBreader.Close();
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }




        public BindingList<UtenteCercato> SearchUserByCFiscale(string CFiscale)
        {


            BindingList<UtenteCercato> UtentiTrovati = new BindingList<UtenteCercato>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd;
                strcmd = string.Format("SELECT * from utenti where codicefiscale = \"{0}\"", CFiscale);//SELECT  * from utenti where cognome = 'asda' and nome = 'asd'

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        UtenteCercato utentetrovato = new UtenteCercato();
                        utentetrovato.IdUtente = DBreader.GetInt32(0);
                        utentetrovato.Cognome = DBreader.GetString(1);
                        utentetrovato.Nome = DBreader.GetString(2);
                        utentetrovato.DataNascita = DBreader.GetDateTime(4);
                        utentetrovato.ComuneNascita = DBreader.GetString(5);
                        utentetrovato.ComuneResidenza = DBreader.GetString(7);
                        utentetrovato.Indirizzo = DBreader.GetString(9);
                        utentetrovato.CodiceFiscale = DBreader.GetString(11);
                        utentetrovato.ProvNascita = DBreader.GetString(6);
                        utentetrovato.ProvResidenza = DBreader.GetString(8);
                        utentetrovato.Sex = DBreader.GetBoolean(3);
                        utentetrovato.CAP = DBreader.GetString(10);
                        utentetrovato.foto = DBreader.GetString(12);

                        UtentiTrovati.Add(utentetrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return UtentiTrovati;
        }

        public BindingList<Patente> ReadAllLicenseExtDb(string databasepathandname)
        {

            string ConnString = "Data Source = " + databasepathandname;
            BindingList<Patente> ListaPatente = new BindingList<Patente>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(ConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = "SELECT * from PATENTI";

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Patente PatenteTrovata = new Patente();

                        PatenteTrovata.numero = DBreader.GetString(1);
                        PatenteTrovata.categoria = DBreader.GetString(2);
                        PatenteTrovata.datarilascio = DBreader.GetDateTime(3);
                        PatenteTrovata.datascadenza = DBreader.GetDateTime(4);
                        PatenteTrovata.enterilascio = DBreader.GetString(5);
                        PatenteTrovata.tipo = DBreader.GetString(7);
                        PatenteTrovata.codicefiscale = DBreader.GetString(6);
                        PatenteTrovata.deleted = DBreader.GetBoolean(8);

                        ListaPatente.Add(PatenteTrovata);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaPatente;
        }

        public BindingList<Contatto> ReadAllContatcsExtDB(string databasepathandname)
        {
            string ConnString = "Data Source = " + databasepathandname;

            BindingList<Contatto> ListaContatti = new BindingList<Contatto>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(ConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = "SELECT * from Contatti";

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Contatto contattotrovato = new Contatto();

                        contattotrovato.numero = DBreader.GetString(1);
                        contattotrovato.tipo = DBreader.GetString(3);
                        contattotrovato.codicefiscale = DBreader.GetString(2);
                        contattotrovato.deleted = DBreader.GetBoolean(4);


                        ListaContatti.Add(contattotrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaContatti;
        }

        public BindingList<Esame> ReadAllExamsExtDB(string databasepathandname)
        {
            string ConnString = "Data Source = " + databasepathandname;

            BindingList<Esame> ListaEsami = new BindingList<Esame>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(ConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = "SELECT * from Esami";
                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Esame Esametrovato = new Esame();

                        Esametrovato.tipo = DBreader.GetString(2);
                        Esametrovato.DataEsame = DBreader.GetDateTime(3);
                        Esametrovato.Categoria = DBreader.GetString(4);
                        Esametrovato.Esito = DBreader.GetString(5);
                        Esametrovato.codicefiscale = DBreader.GetString(1);
                        Esametrovato.deleted = DBreader.GetBoolean(6);


                        ListaEsami.Add(Esametrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaEsami;
        }

        public BindingList<Esame> ReadExamSpec(string codice, string data, string esito, string categoria,string tipo)
        {


            BindingList<Esame> ListaEsami = new BindingList<Esame>();
            //Apro la connessione al database
            SQLiteDataReader DBreader = null;
            SQLiteConnection DBConn = new SQLiteConnection(m_DBConnString);
            try
            {
                DBConn.Open();
                SQLiteCommand DBcmd = new SQLiteCommand(DBConn);
                string strcmd = string.Format("SELECT * from Esami where codice = \"{0}\" and data = \"{1}\" and esito = \"{2}\" and CAT = \"{3}\" and tipo = \"{4}\" and deleted = \"0\"", codice, data, esito, categoria, tipo);

                DBcmd.CommandText = strcmd;
                DBreader = DBcmd.ExecuteReader();
                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {

                        Esame Esametrovato = new Esame();

                        Esametrovato.tipo = DBreader.GetString(2);
                        Esametrovato.DataEsame = DBreader.GetDateTime(3);
                        Esametrovato.Categoria = DBreader.GetString(4);
                        Esametrovato.Esito = DBreader.GetString(5);
                        Esametrovato.codicefiscale = DBreader.GetString(1);
                        Esametrovato.deleted = DBreader.GetBoolean(6);
                        


                        ListaEsami.Add(Esametrovato);

                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (DBreader != null)
                    DBreader.Close();
                DBConn.Close();
            }
            return ListaEsami;
        }

        public string TransformDate(string dateTotransform)
        {

            try
            {
                string strtmp = dateTotransform;
                char[] str2 = new char[15];
                string s = string.Empty;

                if (strtmp.Length == 5)
                {
                    str2[0] = strtmp[0];
                    str2[1] = strtmp[1];
                    str2[2] = '/';
                    str2[3] = '0';
                    str2[4] = strtmp[2];
                    str2[5] = '/';
                    str2[6] = '1';
                    str2[7] = '9';
                    str2[8] = strtmp[3];
                    str2[9] = strtmp[4];
                    s = new string(str2);

                }
                else if (strtmp.Length == 6)
                {
                    str2[0] = strtmp[0];
                    str2[1] = strtmp[1];
                    str2[2] = '/';
                    str2[3] = strtmp[2];
                    str2[4] = strtmp[3];
                    str2[5] = '/';
                    str2[6] = '1';
                    str2[7] = '9';
                    str2[8] = strtmp[4];
                    str2[9] = strtmp[5];
                    s = new string(str2);

                }
                else if (strtmp.Length == 7)
                {
                    str2[0] = strtmp[0];
                    str2[1] = strtmp[1];
                    str2[2] = '/';
                    str2[3] = '0';
                    str2[4] = strtmp[2];
                    str2[5] = '/';
                    str2[6] = strtmp[3];
                    str2[7] = strtmp[4];
                    str2[8] = strtmp[5];
                    str2[9] = strtmp[6];
                    s = new string(str2);

                }
                else if (strtmp.Length == 8)
                {
                    str2[0] = strtmp[0];
                    str2[1] = strtmp[1];
                    str2[2] = '/';
                    str2[3] = strtmp[2];
                    str2[4] = strtmp[3];
                    str2[5] = '/';
                    str2[6] = strtmp[4];
                    str2[7] = strtmp[5];
                    str2[8] = strtmp[6];
                    str2[9] = strtmp[7];
                    s = new string(str2);

                }
                else
                    s = dateTotransform;
                return s;

            }
            catch (Exception ex)
            {
                MessageBox.Show("E' avvenuto un errore", "Errore", MessageBoxButtons.OK);
                return string.Empty;
            }
        }


    }
}

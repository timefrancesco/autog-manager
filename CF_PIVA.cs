using System;
using System.Collections; //Per definire ArrayList il vettore dei messaggi di errore
using System.Data.OleDb;  //Per collegarsi ad un DB Access mediante Microsoft Jet
using System.IO;		  //Per lavorare sul file system (dir dell'applicazione)
using System.Diagnostics; //Per il debug

namespace VillaUserManager
//Il calcolo del codice fiscale si conclude nella determinazione di due stringhe:
//una è il CF formattato (Es. REX.LAX.15E15.E787.Q) posta nell'attributo della classe 'strCodiceFiscale'
//l'altra stringa è l'output del metodo 'CalcolaCF' che è nella forma: REXLAX15E15E787Q.
{
	/// <summary>
	/// Calcola e verifica il CF
	/// </summary>
	public class ClsCodiceFiscale
	{
		public ClsCodiceFiscale()
		{	// Inserisco i costruttori logici
			strCodiceFiscale = "";
		}
		public void Dispose()
		{	
			strCodiceFiscale = "";
		}
//----------------------------------------------------------------------------------------
//		Attributi
//----------------------------------------------------------------------------------------
		public string strCodiceFiscale;
		public string strNomeFileDBComuni = DataAccess.Instance.Path_DB_Comuni;
		
		//Strutture/Tipi locali
		private const char chrSeparazione = '.';//Carattere di separazione tra le parti del codice fiscale
		//Es. chrSeparazione='.' -> strCodiceFiscale="REX.LAX.15E15.E787.Q"
		private struct infoStrutturaCF
		{
			public string codCognome;
			public string codNome;
			public string codDataSesso;
			public string codCitta;
			public char codCTRL;
		}
		private struct infoTipoData
		{
			public byte giorno;
			public byte mese;
			public ushort anno;
		}
//----------------------------------------------------------------------------------------
//		Metodi della classe
//----------------------------------------------------------------------------------------
		public string CalcolaCF(string strNome,string strCognome,char chrSesso,string strDataNascita,
			string strLuogoNascita,string strSiglaProvincia,ArrayList vetStrErrori)
		//Se tutto OK restituisce il CF nella forma:                               REXLAX15E15E787Q
		//restituisce comunque l'attributo della classe strCodiceFiscale del tipo: REX.LAX.15E15.E787.Q 
		{// Il codice è restituito in MAIUSCOLO
		string strCodiceFiscalePulito = ""; //Output del metodo != "" solo se tutto OK
		string strErrore = "";
		infoStrutturaCF strutturaCF;

			vetStrErrori.Clear();
			strutturaCF.codCognome = CalcolaCognome(strCognome,ref strErrore);
			if (strErrore != "")
				vetStrErrori.Add(strErrore);
			strErrore = "";
			strCodiceFiscale = strutturaCF.codCognome + chrSeparazione;

			strutturaCF.codNome = CalcolaNome(strNome,ref strErrore);
			if (strErrore != "")
				vetStrErrori.Add(strErrore);
			strErrore = "";
			strCodiceFiscale += strutturaCF.codNome + chrSeparazione;

			strutturaCF.codDataSesso = CalcolaDataNascita(strDataNascita, chrSesso,ref strErrore);
			if (strErrore != "")
				vetStrErrori.Add(strErrore);
			strErrore = "";
			strCodiceFiscale += strutturaCF.codDataSesso + chrSeparazione;

			strutturaCF.codCitta = CalcolaLuogoNascita(strLuogoNascita,strSiglaProvincia,ref strErrore);
			strCodiceFiscale += strutturaCF.codCitta + chrSeparazione;
			if (strErrore != "")
				vetStrErrori.Add(strErrore);
			strErrore = "";

			if (vetStrErrori.Count == 0) //Nessun errore?
			{
				strCodiceFiscalePulito = strCodiceFiscale.Replace(chrSeparazione.ToString(),"");
				strutturaCF.codCTRL = CalcolaCarattereCtrl(strCodiceFiscalePulito,ref strErrore);
				
				if (strErrore != "")
					vetStrErrori.Add(strErrore);
				else
				{
					strCodiceFiscale += strutturaCF.codCTRL;
					strCodiceFiscalePulito += strutturaCF.codCTRL;
				}
			}
			return strCodiceFiscalePulito;
		}
		
		public bool CodiceFiscaleOk()
		{//Da sviluppare
			return true;
		}

//----------------------------------------------------------------------------------------
//      Metodi Privati
//----------------------------------------------------------------------------------------
		private string CalcolaCognome(string strCognome,ref string strErrore)
		//Calcola dal Cognome un codice di 3 lettere secondo un algoritmo specifico
		//Es.: AINO -> NAI, DE PAOLA -> DPL
		{
			int intLhCognome = 0;
			string strCognomeVocali = "";
			string strCognomeConsonanti = "";
			string strCodCognome = "";

			strCognome = strCognome.Trim();
			strCognome = strCognome.Replace(" ","");//Se il cognome è separato da spazi occorre toglierli
			if (!VerificaLettereNumeriOK(strCognome))
			{
				strErrore = "Nel cognome sono presenti caratteri inaccettabili. \n <CF_PIVA.CalcolaCognome>.";
				return "";
			}
			intLhCognome = strCognome.Length;
			if (intLhCognome == 0)   //Ulteriore controllo se la stringa di lavoro è vuota
			{
				strErrore = "Manca il cognome per il calcolo del codice fiscale \n <CF_PIVA.CalcolaCognome>.";
				return "";
			}
			SeparaConsonantiVocali(strCognome,ref strCognomeConsonanti,ref strCognomeVocali,ref strErrore);
			if (strErrore != "")
				return "";
			if (intLhCognome<3)
			{
				switch (strCognomeConsonanti.Length)
				{
					case 0:
						if (strCognomeVocali.Length == 2)
							strCodCognome = strCognomeVocali + "X";
						else
							strCodCognome = strCognomeVocali + "XX";
						break;
					case 1:
						if (strCognomeVocali.Length == 1)
							strCodCognome = strCognomeConsonanti + strCognomeVocali + "X";
						else
							strCodCognome = strCognomeConsonanti + "XX";
						break;
					case 2:
						strCodCognome = strCognomeConsonanti + "X";
						break;
				}
			}
			else //intLhCognome >= 3
				switch (strCognomeConsonanti.Length)
				{
					case 1:
						strCodCognome = strCognomeConsonanti + strCognomeVocali.Substring(0, 2);
						break;
					case 2:
						strCodCognome = strCognomeConsonanti + strCognomeVocali[0];
						break;
					default:  // strCognomeConsonanti.Length >= 3
						strCodCognome = strCognomeConsonanti.Substring(0, 3);
						break;
				}
			return strCodCognome; //Tutto Ok sputo fuori il codice
		}

		private string CalcolaNome(string strNome,ref string strErrore)
		//Calcola dal Nome un codice di 3 lettere secondo un algoritmo specifico
		//Es.: GIUSEPPE -> GPP , UGO -> GUO , AL -> LAX
		{
			int intLhNome = 0;
			string strNomeVocali = "";
			string strNomeConsonanti = "";
			string strCodNome = "";

			strNome = strNome.Trim();
			strNome = strNome.Replace(" ","");//Se il nome è separato da spazi occorre toglierli
			if (!VerificaLettereNumeriOK(strNome))
			{
				strErrore = "Nel nome sono presenti caratteri inaccettabili. \n <CF_PIVA.CalcolaNome>.";
				return "";
			}
			intLhNome = strNome.Length;
			if (intLhNome == 0)   //Ulteriore controllo se la stringa di lavoro è vuota
			{
				strErrore = "Manca il cognome per il calcolo del codice fiscale \n <CF_PIVA.CalcolaNome>.";
				return "";
			}                    
			SeparaConsonantiVocali(strNome,ref strNomeConsonanti,ref strNomeVocali,ref strErrore);
			if (strErrore != "")
				return "";
			if (intLhNome<3)
			{
				switch (strNomeConsonanti.Length)
				{
					case 0:
						if (strNomeVocali.Length == 2)
							strCodNome = strNomeVocali + "X";
						else
							strCodNome = strNomeVocali + "XX";
						break;
					case 1:
						if (strNomeVocali.Length == 1)
							strCodNome = strNomeConsonanti + strNomeVocali + "X";
						else
							strCodNome = strNomeConsonanti + "XX";
						break;
					case 2:
						strCodNome = strNomeConsonanti + "X";
						break;
				}
			}
			else //intLhNome >= 3,  Quì solo c'è la parte <> rispetto al calcolo sul Cognome
				switch (strNomeConsonanti.Length)
				{
					case 1:
						strCodNome = strNomeConsonanti + strNomeVocali.Substring(0, 2);
						break;
					case 2:
						strCodNome = strNomeConsonanti + strNomeVocali[0];
						break;
					case 3:
						strCodNome = strNomeConsonanti.Substring(0, 3);
						break;
					default:  // strNomeConsonanti.Length > 3
						strCodNome = strNomeConsonanti[0] + strNomeConsonanti.Substring(2, 2);
						break;
				}
			return strCodNome; //Tutto Ok sputo fuori il codice
		}

		private string CalcolaDataNascita(string strDataNascita, char chrSesso,ref string strErrore)
		//Calcola una stringa di 4 caratteri in cui i primi 2 sono l'anno (del 1900)
		//segue un carattere rappresentante il mese, infine, seguono le due 
		//cifre del giorno di nascita. Se si tratta di una donna il giorno di nascita 
		//viene aumentato di 40. Es. maschio 20/12/1971->71T20
		//
		//La data deve essere nel formato: "GG/MM/YYYY" o "GG/MM/YY"
		{
		const string strMesiCF = "ABCDEHLMPRST";
		infoTipoData mioTipoData;
		int intGiorno = 0;
		int intMese = 0;
		string strCodData = "";

			strDataNascita = strDataNascita.Trim();
			chrSesso = chrSesso.ToString().ToUpper()[0];//Trasformo il carattere in maiuscolo
			//Sesso imprevisto? -> Errore
			if ((chrSesso!='M') && chrSesso!='F')		
			{
				strErrore = "Sesso imprevisto! \n <CF_PIVA.CalcolaDataNascita>.";
				return "";
			}
			mioTipoData = new infoTipoData();
			//Calcolo l'ANNO
			if (!TrasformaDataOk(strDataNascita,ref mioTipoData, ref strErrore))
				return "";
			if (mioTipoData.anno<9)
				strCodData = '0' + mioTipoData.anno.ToString();
			else
				strCodData = mioTipoData.anno.ToString();
			//Calcolo il MESE
			intMese = (int)mioTipoData.mese - 1;
			strCodData = strCodData + strMesiCF[intMese];
			//Calcolo il GIORNO
			if (chrSesso=='F')	//Femmina?
				intGiorno = (int)mioTipoData.giorno + 40;
			else
				intGiorno = (int)mioTipoData.giorno;
			if (intGiorno<9)
				strCodData = strCodData + '0' + intGiorno.ToString();
			else
				strCodData = strCodData + intGiorno.ToString();
			return strCodData;
		}

		private string CalcolaLuogoNascita(string strLuogoNascita, string strSiglaProvincia,ref string strErrore)
		//Verifica i dati di input, l'esistenza del DB ed 
		//infine ottiene il codice associato alla provincia
		{
		string strCodiceComune = "";
		string strPercorsoDB = "";

			strLuogoNascita = strLuogoNascita.ToUpper().Trim();
			if (!VerificaLettereNumeriOK(strLuogoNascita))
			{
				strErrore = "La città di nascita contiene caratteri errati! \n<CF_PIVA.CalcolaLuogoNascita>.";
				return "";
			}
			strSiglaProvincia = strSiglaProvincia.ToUpper().Trim();
			if (strSiglaProvincia.Length!=2)
			{
				strErrore = "Inserire la sigla della provincia (Es. CS)! \n<CF_PIVA.CalcolaLuogoNascita>.";
				return "";
			}
			if (!VerificaLettereNumeriOK(strSiglaProvincia))
			{
				strErrore = "La provincia di nascita contiene caratteri errati! \n<CF_PIVA.CalcolaLuogoNascita>.";
				return "";
			}
			strPercorsoDB = strNomeFileDBComuni;
			if (File.Exists(strPercorsoDB))
				strCodiceComune = TrovaCodiceCitta(strPercorsoDB,strLuogoNascita,strSiglaProvincia,ref strErrore);
			else
				strErrore = "Non è stato trovato il file dei comuni: "+strPercorsoDB+"! \n<CF_PIVA.CalcolaLuogoNascita>.";
			return strCodiceComune;
		}

		private char CalcolaCarattereCtrl(string strCFDaCTRL,ref string strErrore)
		//Il CF è lungo 16 caratteri determina il 16° in base ad un calcolo
		//Se il CF è lungo 16 prende i primi 15 e genera il carattere
		{
			int[] intCodiciXposDispari = {1,0,5,7,9,13,15,17,19,21,2,4,18,20,11,3,6,8,12,
											 14,16,10,22,25,24,23,1,0,5,7,9,13,15,17,19,21};
			string strCaratPosDispari = "";
			string strCaratPosPari = "";
			int intIndice = 0;
			int intValDispari = 0;
			int intValPari = 0;
			int intValore = 0;
			int intIndice2 = 0;
			char carattere = ' ';

			strCFDaCTRL = strCFDaCTRL.ToUpper();
			//Verifico che la lunghezza sia 15 o 16 per poterci lavorare
			if (strCFDaCTRL.Length!=15 && strCFDaCTRL.Length!=16)
			{
				strErrore = "Lunghezza del codice fiscale imprevista! \n <CF_PIVA.CalcolaCarattereCtrl>.";
				return ' ';
			}
			//Separo i caratteri in posizione Dispari da quelli in posizione Pari
			while (intIndice < 14)
			{
				strCaratPosDispari = strCFDaCTRL[intIndice] + strCaratPosDispari;
				intIndice++;
				strCaratPosPari = strCFDaCTRL[intIndice] + strCaratPosPari;
				intIndice++;
			}
			strCaratPosDispari = strCFDaCTRL[intIndice] + strCaratPosDispari;
			strCaratPosDispari = IvertiStringa(strCaratPosDispari);
			strCaratPosPari = IvertiStringa(strCaratPosPari);
			//Ottengo un numero scandendo i caratteri in posizione Pari che sono 7
			for (byte i=0; i<7; i++)
			{
				carattere = strCaratPosPari[i];
				if (((int)carattere >= (int)'A' && ((int)carattere <= (int)'Z'))) //E' una lettera?
					intValPari = (int)carattere - (int)'A' + intValPari;
				else //E' un numero?
					if (((int)carattere >= (int)'0' && ((int)carattere <= (int)'9'))) //E' una lettera?
					intValPari = (int)carattere - (int)'0' + intValPari;
			}
			//Ottengo un numero scandendo i caratteri in posizione Disari che sono 8
			for (byte i=0; i<8; i++)
			{
				carattere = strCaratPosDispari[i];
				if (((int)carattere >= (int)'A' && ((int)carattere <= (int)'Z'))) //E' una lettera?
				{
					intIndice2 = (int)carattere - (int)'A';
					intValDispari = intCodiciXposDispari[intIndice2] + intValDispari;
				}
				else //E' un numero?
					if (((int)carattere >= (int)'0' && ((int)carattere <= (int)'9'))) //E' una lettera?
				{
					intIndice2 = (int)carattere - (int)'0' + 26;
					intValDispari = intCodiciXposDispari[intIndice2] + intValDispari;
				}
			}
			intValore = (intValDispari + intValPari) % 26;
			carattere = (char)(intValore + (int)'A');
			return carattere;
		}
//--------------------------------------------------------------------------------
//		Funzioni di servizio
//--------------------------------------------------------------------------------
		private bool VerificaLettereNumeriOK(string strInput)
			//Verifica che nella stringa ci siano solo lettere o numeri
		{ //Assumo che la stringa abbia non più di 255 caratteri
			char chrCarattere = ' ';

			strInput = strInput.ToUpper();
			for (byte i=0; i<strInput.Length; i++)
			{
				chrCarattere = strInput[i];
				if (( (byte)chrCarattere<(byte)'0' || 
					((byte)chrCarattere>(byte)'9' && (byte)chrCarattere<(byte)'A') ||
                    (byte)chrCarattere > (byte)'Z') && ((byte)chrCarattere != (byte)' ') && ((byte)chrCarattere != (byte)'\''))
					return false; //ERRORE! carattere imprevisto
			}
			return true;
		}

		private void SeparaConsonantiVocali(string stringa,ref string strConsonantiOut,
			ref string strVocaliOut,ref string strErrore)
			//Data una stringa in input, priva di spazi vuoti e composta di sole lettere,
			//rispettando la sequenza iniziale, ne crea due, in una vi saranno le vocali 
			//e nell'altra le consonanti
		{
			const string strVocali = "AEIOU";
			int intLStringa = 0;
			char carattere = ' ';
			bool blnTrovato = false;

			strConsonantiOut = "";
			strVocaliOut = "";
			stringa = stringa.ToUpper();
			intLStringa = stringa.Length;
			for (int i=0; i<intLStringa; i++) //Per ogni carattere della stringa
			{ 
				carattere = stringa[i];
				if (((int)carattere >= (int)'A') && ((int)carattere <= (int)'Z'))
				{ //E' una lettera dell'alfabeto?
					int j = 0;
					blnTrovato = false;
					while ((j<5) && (!blnTrovato))//E' una vocale?
					{
						if (strVocali[j] == carattere)
						{
							blnTrovato = true;
							strVocaliOut = strVocaliOut + carattere;
						}
						j++;
					}//while
					if (!blnTrovato) //E' una consonante.
						strConsonantiOut = strConsonantiOut + carattere;
				}
				else //Errore, sono ammessi solo caratteri dell'alfabeto!
				{
					strErrore = "Sono ammessi solo caratteri dell'alfabeto! <CF_PIVA.SeparaConsonantiVocali>";
					return;
				}
			}//for
		}
		private string IvertiStringa(string stringa)
		{
			int intLungStringa = 0;
			string strNuovaStringa = "";

			stringa = stringa.Trim();
			intLungStringa = stringa.Length;
			for (byte i=1; i<=intLungStringa; i++)
				strNuovaStringa += stringa[intLungStringa-i];
			return strNuovaStringa;
		}

		private bool TrasformaDataOk(string strData,ref infoTipoData dataOut, ref string strErrore)
		//Esegue ctrl semantico e sintattico su una data in formato stringa
		//La data deve essere nel formato: 01/01/1971 o 01/01/71
		{
		bool blnEsito = false;
		string strDataNascita = "";
		DateTime dtDataTest = DateTime.Today;
			
			dataOut.anno = ConvertiStringaAnno(strData,ref strErrore);
			if (dataOut.anno == 0 && strErrore != "")
				return false;

			dataOut.mese = ConvertiStringaMese(strData,ref strErrore);
			if (dataOut.mese == 0)
				return false;

			dataOut.giorno = ConvertiStringaGiorno(strData,ref strErrore);
			if (dataOut.giorno == 0)
				return false;

			//Verifico che la data sia semanticamente corretta
			try
			{
				strDataNascita = dataOut.giorno.ToString()+"/"+dataOut.mese.ToString()+"/"+dataOut.anno.ToString();
				dtDataTest = DateTime.Parse(strDataNascita);
				blnEsito = true;
			}
			catch
			{
				strErrore = "Data inesistente o errata! <CF_PIVA.TrasformaDataOk>";
			}
			return blnEsito;
		}

		private ushort ConvertiStringaAnno(string strData,ref string strErrore)
		//Estrae l'anno da una data in forma di stringa
		//La data deve essere nel formato: 01/01/1971 o 01/01/71
		{
		byte btyPosizioneDa = 0;
		ushort ushoNumero = 0;
		string strAnno = "";
			
			if (strData.Length==8)			//Formato: 01/01/71
				btyPosizioneDa = 6;
			else if (strData.Length==10)	//Formato: 01/01/1971
				btyPosizioneDa = 8;
			else
			{
				strErrore = "Formato di data imprevisto! \n Formato richiesto: GG/MM/YYYY \n<CF_PIVA.ConvertiStringaAnno>.";
				return 0;
			}
			strAnno = strData.Substring(btyPosizioneDa,2);
			//Verifico l'anno stringa di due cifre
			if ((byte)strAnno[0]<(byte)'0' || (byte)strAnno[0]>(byte)'9' ||
				(byte)strAnno[1]<(byte)'0' || (byte)strAnno[1]>(byte)'9')
			{		
				strErrore = "Carattere imprevisto in Anno! \n<CF_PIVA.ConvertiStringaAnno>.";
				return 0;
			}
			ushoNumero = ushort.Parse(strAnno);
			ushoNumero += 1900; //Per prevenire sviluppi futuri
			if (ushoNumero<1900 || ushoNumero>DateTime.Today.Year)
			{
				strErrore = "Anno errato o impossibile! \n<CF_PIVA.ConvertiStringaAnno>.";
				return 0;
			}
			return (ushort)(ushoNumero - 1900);
		}

		private byte ConvertiStringaMese(string strData,ref string strErrore)
		//Estrae il mese da una data in forma di stringa
		//La data deve essere nel formato: 01/01/1971 o 01/01/71
		{
		byte btyNumero = 0;
		string strMese = "";
			
			//Verifico il mese
			strMese = strData.Substring(3,2);
			if ((byte)strMese[0]<(byte)'0' || (byte)strMese[0]>(byte)'9' ||
				(byte)strMese[1]<(byte)'0' || (byte)strMese[1]>(byte)'9')
			{
				strErrore = "Carattere imprevisto in Mese! \n<CF_PIVA.ConvertiStringaMese>.";
				return 0;
			}
			btyNumero = byte.Parse(strMese);
			if (btyNumero<1 || btyNumero>12)
			{
				strErrore = "Mese errato! \n<CF_PIVA.ConvertiStringaMese>.";
				return 0;
			}
			return btyNumero;
		}
		
		private byte ConvertiStringaGiorno(string strData,ref string strErrore)
		//La data deve essere nel formato: 01/01/1971 o 01/01/71
		//La data deve essere nel formato: 01/01/1971 o 01/01/71
		{
		byte btyNumero = 0;
		string strGiorno = "";
			
			//Verifico il giorno
			strGiorno = strData.Substring(0,2);
			if ((byte)strGiorno[0]<(byte)'0' || (byte)strGiorno[0]>(byte)'9' ||
				(byte)strGiorno[1]<(byte)'0' || (byte)strGiorno[1]>(byte)'9')
			{
				strErrore = "Carattere imprevisto in Giorno! \n<CF_PIVA.ConvertiStringaGiorno>.";
				return 0;
			}
			btyNumero = byte.Parse(strGiorno);
			if (btyNumero<1 || btyNumero>31)
			{
				strErrore = "Giorno errato! \n<CF_PIVA.ConvertiStringaGiorno>.";
				return 0;
			}
			return btyNumero;
		}

		private string TrovaCodiceCitta(string percorsoDB, string strCitta,string strProvincia,ref string strErrore)
		//Interroga il DB dei comuni d'Italia per ottenerne il codice
		//Per evitare problemi con comuni che abbiano lo stesso nome 
		//viene fatto anche un controllo sulla provincia se != "". strCitta, strSiglaProvincia MAIUSCOLI!
		{
		string strComuneDaDB = "";
		string strProvinciaDaDB = "";
		bool blnTrovato = false;
		string strCodiceComune = ""; //!="" solo in caso positivo
		string strStringaConnessione = "";

			//Crea una connessione ad un DB Access mediante Microsoft Jet
			strStringaConnessione = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+percorsoDB;
			OleDbConnection connessioneDB = new OleDbConnection(strStringaConnessione);
			//Crea un oggetto comandi per immagazzinare le tabele mediante sql query
			OleDbCommand commandDB = new OleDbCommand("select * from comuni", connessioneDB);
			connessioneDB.Open();
			//Crea un dataReader per connettersi alla tabella
			OleDbDataReader dataReaderDB = commandDB.ExecuteReader();
			try
			{
				//Interrogo LINEARMENTE il DB 
				while (dataReaderDB.Read() && !blnTrovato) //Và al record successivo
				{
					strComuneDaDB = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Comune"));
					strComuneDaDB = strComuneDaDB.ToUpper().Trim();
					if (strComuneDaDB == strCitta)
					{
						strProvinciaDaDB = dataReaderDB.GetString(dataReaderDB.GetOrdinal("Provincia"));
						strProvinciaDaDB = strProvinciaDaDB.ToUpper().Trim();
						if (strProvinciaDaDB == strProvincia)
						{
							blnTrovato = true;
							strCodiceComune = dataReaderDB.GetString(dataReaderDB.GetOrdinal("CodiceComune"));
						}
						else
							strErrore = "Provincia errata o non riconosciuta! \n <CF_PIVA.TrovaCodiceCitta>.";
					}
				}//while
			}
			catch (Exception objException)
			{
				strErrore = "Si è verificato il seguente errore in:"+
					         objException.Source+"\n"+objException.TargetSite+"\n" + 
					         objException.Message+"\n <CF_PIVA.TrovaCodiceCitta>.";
			}
			finally
			{
				dataReaderDB.Close(); //Chiudo il dataReader
				connessioneDB.Close();//Chiudo la connessione.
			}
			if (!blnTrovato)
				strErrore = "Città sconosciuta! \n <CF_PIVA.TrovaCodiceCitta>.";
			return strCodiceComune;
		}
	}

}

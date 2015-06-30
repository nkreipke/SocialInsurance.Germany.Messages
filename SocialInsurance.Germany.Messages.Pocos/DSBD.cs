﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSBD - Datensatz Betriebsdatenpflege
    /// </summary>
    public class DSBD : IDatensatz
    {

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSBD"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public DSBD()
        {
            KE = "DSBD";
            VF = "BTRAG";
            VERNR = "01";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datensatz es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt das Verfahren
        /// </summary>
        /// <remarks>
        /// Verfahren, für das der Datensatz bestimmt ist, Länge 5,
        /// BTRAG = Betriebsdatenpflege durch Arbeitgeber, Mussangabe
        /// </remarks>
        public string VF { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Erstellers des Datensatzes
        /// </summary>
        /// <remarks>
        ///  Betriebsnummer des Erstellers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNRAB { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Empfängers des Datensatzes
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Empfängers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// </remarks>
        public string BBNREP { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des übermittelten Datensatzes
        /// </summary>
        /// <remarks>
        /// Versionsnummer des übermittelten Datensatzes, Länge 2, Mussangabe
        /// </remarks>
        public string VERNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Zeitpunkt der Erstellung des Dateznsatzes
        /// </summary>
        /// <remarks>
        /// Zeitpunkt der Erstellung des Datensatzes, Länge 20, jhjjmmtt (Datum) hhmmss (Uhrzeit) msmsms (Mikrosekunde) (Wert > 0 in letzten 6 Stellen optional), Mussangabe
        /// </remarks>
        public DateTime ED { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichnung für fehlerhafte Datensätze
        /// </summary>
        /// <remarks>
        /// Kennzeichnung für fehlerhafte Datensätze, Länge 1, 0 = Datensatz fehlerfrei 1 = Datensatz fehlerhaft, Mussangabe
        /// </remarks>
        public bool FEKZ
        {
            get { return _hatDbfe ?? Fehler != null; }
            set { _hatDbfe = value; }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public string FEAN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Betriebsstätte
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Betriebsstätte, für die die Meldung vorgenommen wird, Länge 15, Mussangabe
        public string BBRNBS { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 11, Mussangabe
        /// </remarks>
        public string RESERVE1 { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, Länge 15, Pflichtangabe, soweit bekannt
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt den Grund der Abgabe
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// 11 = Änderung der Betriebsbezeichnung
        /// 12 = Änderung der Anschrift
        /// 13 = Änderung des Status/Ruhendkennzeichens
        /// 14 = Änderung des Ansprechpartners
        /// 15 = Änderung im Datenbaustein DBKA
        /// 16 = Änderung der Meldenden Stelle
        /// 17 = Kombination aus 12-16
        /// 18 = Kombination aus 11 mit mindestens einem
        /// weiteren Grund aus 12-16
        /// </remarks>
        public string GD { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 5, Mussangabe unter Bedingungen
        /// </remarks>
        public string RESERVE2 { get; set; }

        /// <summary>
        /// Holt oder setzt den ersten Teil des Namens des Betriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 1, Länge 30, Mussangabe
        /// </remarks>
        public string NAME1 { get; set; }

        /// <summary>
        /// Holt oder setzt den zweiten Teil des Namens des Betriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 2, Länge 30, Pflichtangabe unter Bedingungen
        /// </remarks>
        public string NAME2 { get; set; }

        /// <summary>
        /// Holt oder setzt den dritten Teil des Namens des Betriebes
        /// </summary>
        /// <remarks>
        /// Name / Bezeichnung des Betriebes – Teil 3, Länge 30, Pflichtangabe unter Bedingungen
        /// </remarks>
        public string NAME3 { get; set; }

        /// <summary>
        /// Holt oder setzt die zustellbezogene Postleitzahl
        /// </summary>
        /// <remarks>
        /// Postleitzahl(zustellbezogen), Länge 10, Mussangabe
        /// </remarks>
        public string PLZZU { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort des Betriebes
        /// </summary>
        /// <remarks>
        /// Ort des Betriebes, Länge 34, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt die Straße des Betriebes
        /// </summary>
        /// <remarks>
        /// Straße des Betriebes, Länge 33, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die Hausnummer des Betriebes
        /// </summary>
        /// <remarks>
        /// Hausnummer des Betriebes, Länge 9, Pflichtangabe, soweit bekannt
        /// Hinweis: Wenn die Hausnummer nicht separat abgelegt
        /// werden kann, ist es zulässig, die Hausnummer in
        /// das Feld Straße zu übernehmen. In solchen Fällen
        /// muss dann das Feld Hausnummer auf Grundstellung (Leerzeichen) stehen.
        /// </remarks>
        public string HNR { get; set; }

        /// <summary>
        /// Holt oder setzt die postfachbezogene Postleitzahl
        /// </summary>
        /// <remarks>
        /// Postleitzahl(postfachbezogen), Länge 10, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string PLZPO { get; set; }

        /// <summary>
        /// Holt oder setzt das Postfach des Betriebes
        /// </summary>
        /// <remarks>
        /// Postfach des Betriebes, Länge 10, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string POSTFACH { get; set; }

        /// <summary>
        /// Holt oder setzt die Bestätigung/Einstellung der Betriebstätigkeit
        /// </summary>
        /// <remarks>
        /// Bestätigung über die Betriebstätigkeit bzw. Einstellung
        /// der Betriebstätigkeit (Mitteilung für Betriebseinstellungen bis Ende des lfd. Kalenderjahres möglich)
        /// A = aktiver Betrieb
        /// R = Betriebsaufgabe
        /// </remarks>
        public string RUHEND { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der "meldenden Stelle"
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der „meldenden Stelle“, Länge 15, Pflichtangabe, soweit bekannt
        /// Hinweis: Bei Unternehmen, die über mehrere Betriebsstätten
        /// mit unterschiedlichen Betriebsnummern verfügen,
        /// wird die Betriebsstätte, welche die Meldungen zur
        /// Sozialversicherung erstattet, als „meldende Stelle“
        /// bezeichnet. Dies ist somit kein externer Dienstleister
        /// wie zum Beispiel ein Steuerberater.
        /// </remarks>
        public string BBNRME { get; set; }

        /// <summary>
        /// Holt oder setzt das Geschlecht zur Anrede des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Geschlecht zur Anrede des Ansprechpartners, Länge 1, Pflichtangabe, soweit bekannt
        /// M = Männlich, W = Weiblich, N = Keine Einzelperson
        /// </remarks>
        public string ANRAP { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Name des Ansprechpartners, Länge 30, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string NAMEAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Rufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Rufnummer des Ansprechpartners, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string TELAP { get; set; }

        /// <summary>
        /// Holt oder setzt die Faxrufnummer des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// Faxrufnummer des Ansprechpartners, Länge 20, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string FAXAP { get; set; }

        /// <summary>
        /// Holt oder setzt die E-Mail-Adresse des Ansprechpartners
        /// </summary>
        /// <remarks>
        /// E-Mail-Adresse des Ansprechpartners, Länge 70, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string EMAILAP { get; set; }

        /// <summary>
        /// Dieses Feld steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle: z. B. Aktenzeichen / Personalnummer
        /// des Beschäftigten
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Dieses Feld steht dem Verursacher zur Verfügung
        /// </summary>
        /// <remarks>
        /// Länge 20, Kannangabe
        public string DATENSATZUD { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der für den Beschäftigten zuständigen Einzugsstelle oder der berufsständischen Versorgungseinrichtung
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der für den Beschäftigten zuständigen Einzugsstelle oder der berufsständischen Versorgungseinrichtung, Länge 15, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 15, Mussangabe
        /// </remarks>
        public string RESERVE3 { get; set; }


        /// <summary>
        /// Holt oder setzt das Vorhandensein der abweichenden Korrespondenzanschrift
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBKA, Länge 1, Mussangabe
        /// Abweichende Korrespondenzanschrift vorhanden:
        /// N = Nein
        /// J = Ja
        /// Hinweis: Die Korrespondenzanschrift muss zum Unternehmen
        /// gehören. Sie gehört somit nicht zu einem Dienstleister wie zum Beispiel einem Steuerberater.
        /// </remarks>
        public bool MMKA
        {
            get { return _hatDbka ?? AbwKorrespondenzanschrift != null; }
            set { _hatDbka = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Teilnahmepflichten
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBTN, Länge 1, Mussangabe
        /// Teilnahmepflichten vorhanden: 
        /// N = Nein
        /// J = Ja
        /// </remarks>
        public bool MMTN
        {
            get { return _hatDbtn ?? Teilnahmepflicht != null; }
            set { _hatDbtn = value; }
        }

        /// <summary>
        /// Holt oder setzt das Reservefeld
        /// </summary>
        /// <remarks>
        /// Reservefeld, Länge 5, Mussangabe
        /// </remarks>
        public string RESERVE4 { get; set; }

        public DBKA AbwKorrespondenzanschrift
        {
            get
            {
                return ListeDBKA == null ? null : ListeDBKA.SingleOrDefault();
            }
            set
            {
                ListeDBKA = ListeDBKA.Set(value);
                _hatDbka = null;
            }
        }

        public DBTN Teilnahmepflicht
        {
            get
            {
                return ListeDBTN == null ? null : ListeDBTN.SingleOrDefault();
            }
            set
            {
                ListeDBTN = ListeDBTN.Set(value);
                _hatDbtn = null;
            }
        }

        public DBFE Fehler
        {
            get
            {
                return ListeDBFE == null ? null : ListeDBFE.SingleOrDefault();
            }
            set
            {
                ListeDBFE = ListeDBFE.Set(value);
                _hatDbfe = null;
            }
        }

        public bool? _hatDbka { get; set; }

        public bool? _hatDbtn { get; set; }

        private bool? _hatDbfe { get; set; }

        private IList<DBKA> ListeDBKA { get; set; }

        private IList<DBTN> ListeDBTN { get; set; }

        private IList<DBFE> ListeDBFE { get; set; }
    }
}
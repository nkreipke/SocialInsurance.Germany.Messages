﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datensatz: DSME - Meldung
    /// </summary>
    public class DSME : IDatensatz
    {
        private bool? _hatDbme;

        private bool? _hatDbna;

        private bool? _hatDbgb;

        private bool? _hatDban;

        private bool? _hatDbeu;

        private bool? _hatDbuv;

        private bool? _hatDbks;

        private bool? _hatDbso;

        public bool? _hatDbkv;

        private bool? _hatDbsv;

        private bool? _hatDbvr;

        private bool? _hatDbrg;

        private FehlerKennzeichen? _fekz;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DSME"/> Klasse.
        /// </summary>
        /// <remarks>
        /// Beim Initialisieren werden die Konstanten, wie Kennung und Verfahren gesetzt.
        /// </remarks>
        public DSME()
        {
            KE = "DSME";
            VF = "DEUEV";
            VERNR = 2;
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
        /// DEUEV = DEÜV- Meldeverfahren RVSNR = Rückmeldung der Versicherungsnummer an den Arbeitgeber, Mussangabe
        /// </remarks>
        public string VF{ get; set; }

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
        public int VERNR { get; set; }

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
        public FehlerKennzeichen FEKZ
        {
            get { return _fekz ?? (DBFE == null || DBFE.Count == 0 ? FehlerKennzeichen.Fehlerfrei : FehlerKennzeichen.Fehlerhaft); }
            set { _fekz = value; }
        }

        /// <summary>
        /// Holt oder setzt die Anzahl der Fehler des Datensatzes
        /// </summary>
        /// <remarks>
        /// Anzahl der Fehler des Datensatzes, Länge 1, Mussangabe
        /// </remarks>
        public int FEAN 
        {
            get { return DBFE == null ? 0 : DBFE.Count; } 
            private set { }
        }

        /// <summary>
        /// Holt oder setzt die Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Versicherungsnummer in der Form: bbttmmjjassp, Länge 12, Pflichtangabe, soweit bekannt
        /// </remarks>
        public string VSNR { get; set; }

        /// <summary>
        /// Holt oder setzt den Versicherungsträger, für den die Meldung bestimmt ist
        /// </summary>
        /// <remarks>
        /// Versicherungsträger, für den die Meldung bestimmt ist, Länge 2, Mussangabe
        /// </remarks>
        public string VSTR { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Verursachers des Datensatzes
        /// </summary>
        /// <remarks>
        /// BBNR-VU BBNRVU, Betriebsnummer des Verursachers des Datensatzes, Länge 15, (8 Stellen linksbündig mit nachfolgenden Leerzeichen), Mussangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber und der Datenannahmestelle ist hier die Betriebsnummer des Beschäftigungsbetriebes anzugeben. 
        /// </remarks>
        public string BBNRVU { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen des Verursachers
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht dem Verursacher zur Verfügung, Länge 20, Kannangabe
        /// Bei der Datenübermittlung zwischen dem Arbeitgeber
        /// und der Datenannahmestelle: z. B. Aktenzeichen / Personalnummer
        /// des Beschäftigten 
        /// </remarks>
        public string AZVU { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der zuständigen Einzugsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer, Länge 15, Mussangabe
        /// Betriebsnummer der für den Beschäftigten zuständigen
        /// Einzugsstelle oder der berufsständischen Versorgungseinrichtung.
        /// Bei Sofortmeldungen ist die Betriebsnummer
        /// der Datenstelle der Träger der Rentenversicherung
        /// anzugeben. (8 Stellen linksbündig mit nachfolgenden Leerzeichen) 
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt das Aktenzeichen der Einzugsstelle
        /// </summary>
        /// <remarks>
        /// Dieses Feld steht der Einzugsstelle zur Verfügung, Länge 20, Kannangabe
        /// Bei Meldungen nach § 28a Abs. 10 SGB IV an die Datenannahmestelle
        /// der berufsständischen Versorgungseinrichtungen
        /// ist hier die Mitgliedsnummer des Beschäftigten
        /// bei der Versorgungseinrichtung anzugeben. 
        /// </remarks>
        public string AZKK { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Abrechnungsstelle
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Abrechnungsstelle, Länge 15, Pflichtangabe, soweit bekannt
        ///  (z.B. Steuerberater - 8 Stellen linksbündig mit nachfolgenden Leerzeichen)
        /// </remarks>
        public string BBNRAS { get; set; }

        /// <summary>
        /// Holt oder setzt die Personengruppe
        /// </summary>
        /// <remarks>
        /// Personengruppe, Länge 3, Mussangabe
        /// </remarks>
          
        public string PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt den Abgabegrund
        /// </summary>
        /// <remarks>
        /// Grund der Abgabe, Länge 2, Mussangabe
        /// </remarks>
        public string GD{ get; set; }

        /// <summary>
        /// Holt den Schlüssel zur Staatsangehörigkeit
        /// </summary>
        /// <remarks>
        /// Staatsangehörigkeitsschlüssel des statistischen Bundesamtes, Länge 3, Mussangabe unter Bedingungen
        /// </remarks>
        public string SASC { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein des DBME
        /// </summary>
        /// <remarks>
        /// Meldesachverhalt vorhanden, Länge 1, Mussangabe
        /// N = keine Meldesachverhaltsdaten
        /// J = Meldesachverhaltsdaten vorhanden
        /// </remarks>
        public bool MMME
        {
            get { return _hatDbme ?? Meldesachverhalt != null; }
            set { _hatDbme = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein des DBNA
        /// </summary>
        /// <remarks>
        /// Name vorhanden, Länge 1, Mussangabe
        /// N = keine Namensdaten
        /// J = Namensdaten vorhanden
        /// </remarks>
        public bool MMNA
        {
            get { return _hatDbna ?? Name != null; }
            set { _hatDbna = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein des DBGB
        /// </summary>
        /// <remarks>
        /// Geburtsangaben vorhanden, Länge 1, Mussangabe
        /// N = keine Geburtsangaben
        /// J = Geburtsangaben vorhanden
        /// </remarks>
        public bool MMGB
        {
            get { return _hatDbgb ?? Geburtsangaben != null; }
            set { _hatDbgb = value; }
        }

        /// <summary>
        /// Holt oder setzt  das Vorhandensein der Anschrift
        /// </summary>
        /// <remarks>
        /// Anschrift vorhanden:, Länge 1, Mussangabe
        /// N = keine Anschrift
        /// J = Anschrift vorhanden
        /// </remarks>
        public bool MMAN
        {
            get { return _hatDban ?? Anschrift != null; }
            set { _hatDban = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein der Europäischen Versicherungsnummer
        /// </summary>
        /// <remarks>
        /// Europäische VSNR vorhanden, Länge 1, Mussangabe
        /// N = keine europäische VSNR
        /// J = europäische VSNR vorhanden
        /// </remarks>
        public bool MMEU
        {
            get { return _hatDbeu ?? EuropäischeVersicherungsnummer != null; }
            set { _hatDbeu = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein der Unfallversicherung
        /// </summary>
        /// <remarks>
        /// Unfallversicherung vorhanden, Länge 1, Mussangabe
        /// N = keine Angaben zur Unfallversicherung
        /// J = Angaben zur Unfallversicherung
        /// </remarks>
        public bool MMUV
        {
            get { return _hatDbuv ?? Unfallversicherung != null; }
            set { _hatDbuv = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Knappschaft oder See
        /// </summary>
        /// <remarks>
        /// Knappschaft/See vorhanden:, Länge 1, Mussangabe
        /// </remarks>
        public bool MMKS
        {
            get { return _hatDbks ?? KnappschaftSee != null; }
            set { _hatDbks = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Sozialversicherungsausweis
        /// </summary>
        /// <remarks>
        /// Sozialversicherungsausweis vorhanden, Länge 1, Mussangabe
        /// N = keine SVA-Daten
        /// J = SVA-Daten vorhanden
        /// </remarks>
        public bool MMSV
        {
            get { return _hatDbsv ?? Sozialversicherungsausweis != null; }
            set { _hatDbsv = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Vergabe/Rückmeldung
        /// </summary>
        /// <remarks>
        /// Vergabe/Rückmeldung vorhanden, Länge 1, Mussangabe
        /// N = keine Vergabe/Rückmeldedaten
        /// J = Vergabe/Rückmeldedaten vorhanden
        /// </remarks>
        public bool MMVR
        {
            get { return _hatDbvr ?? Vergabe != null; }
            set { _hatDbvr = value; }
        }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Rückmeldung gerinfügig Beschäftigte
        /// </summary>
        /// <remarks>
        /// Rückmeldung geringfügig Beschäftigte vorhanden, Stellen 180-180, Mussangabe
        /// N = keine Rückmeldedaten
        /// J = Rückmeldedaten vorhanden
        /// </remarks>
        public bool MMRG
        {
            get { return _hatDbrg ?? Rückmeldung != null; }
            set { _hatDbrg = value; }
        }

        /// <summary>
        /// Holt oder setzt die Meldungen der Bundesagentur für Arbeit
        /// </summary>
        /// <remarks>
        /// Meldungen der Bundesagentur für Arbeit, Länge 1, Mussangabe
        /// 1 = coLei, 2 = COLIBRI, 3 = A2LL, 4 = VAM, 5 = MAZ,
        /// 6 = BAB/Reha, 7 = zPDV, 8 = Kommunen (Alg II), A = ALLEGRO
        /// </remarks>
        public string KENNZUE { get; set; }

        /// <summary>
        /// Holt oder setzt den Übermittlungsweg der abgegebenen Meldung
        /// </summary>
        /// <remarks>
        /// Übermittlungsweg der abgegebenen Meldung, Länge 1, Mussangabe unter Bedingungen
        /// 1 = Meldung eines Arbeitgebers aus systemgeprüftem Programm (§ 18 DEÜV)
        /// 4 = Erstellung oder Änderung einer Meldung durch die Krankenkasse
        /// 5 = Meldung eines Arbeitgebers mittels maschinell erstellter Ausfüllhilfe (§ 18 DEÜV)
        /// 9 = Meldung von der Deutschen Rentenversicherung Knappschaft-Bahn-See aufgrund einer 
        /// Meldung eines Arbeitgebers durch Meldebeleg nach§ 28a Absatz 6a SGB IV
        /// </remarks>
        public string MMUEB { get; set; }

        /// <summary>
        /// Holt oder setzt das Kennzeichen, dass die Anschrift zuzulassen ist
        /// </summary>
        /// <remarks>
        /// Kennzeichen, dass die Anschrift nach Prüfung durch die Sachbearbeitung
        /// der Krankenkasse trotz UNIPOSTAbweisung durch die Datenstelle zuzulassen ist, Länge 1, Kannangabe
        /// D = Anschrift ist zuzulassen
        /// </remarks>
        public string KENNZUP { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Sofortmeldung
        /// </summary>
        /// <remarks>
        /// Sofortmeldung vorhanden, Länge 1, Mussangabe
        /// N = keine Sofortmeldung
        /// J = Sofortmeldung vorhanden
        /// </remarks>
        public bool MMSO
        {
            get { return _hatDbso ?? Sofortmeldung != null; }
            set { _hatDbso = value; }
        }

        /// <summary>
        /// Holt oder setzt das Statuskennzeichen 
        /// </summary>
        /// <remarks>
        /// Statuskennzeichen für Ehegatte/Lebenspartner/ Abkömmling, Länge 1, Mussangabe
        /// 1 = Ehegatte/Lebenspartner/Abkömmling
        /// 2 = geschäftsführender Gesellschafter einer GmbH
        /// </remarks>
        public string KENNZSTA { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Überwachung Einzugsvergütung
        /// </summary>
        /// <remarks>
        /// Datenbaustein DBUE, Länge 1, Mussangabe
        /// Überwachung Einzugsvergütung vorhanden:
        /// N = keine Überwachungsdaten
        /// J = Überwachungsdatenvorhanden
        /// Anmerkung: Bei diesem Merkmalsfeld für den Datenbaustein „Überwachung Einzugsvergütung“ handelt es sich um       
        /// eine Information, die ausschließlich die Rentenversicherung intern nutzt. Die Prüfungen mit Ausnahme DSME500
        /// sind nicht im gemeinsamen Kernprüfprogramm realisiert, sondern hier nur dokumentiert, damit mögliche Inhalte transparent sind.
        /// </remarks>
        public bool? MMUE { get; set; }

        /// <summary>
        /// Holt oder setzt die Versionsnummer des Kernprüfungsprogramms
        /// </summary>
        /// <remarks>
        /// Versionsnummer des Kernprüfungsprogramms mit der der Datensatz geprüft wurde, Länge 1, Mussangabe
        /// </remarks>
        public string VERNRKP { get; set; }

        /// <summary>
        /// Holt oder setzt das Vorhandensein von Krankenversicherung
        /// </summary>
        /// <remarks>
        /// Krankenversicherung vorhanden, Länge 1, Mussangabe
        /// N = keine Krankenversicherungsdaten vorhanden
        /// J = Krankenversicherungsdaten vorhanden
        /// </remarks>
        public bool MMKV
        {
            get { return _hatDbkv ?? Krankenversicherung != null; }
            set { _hatDbkv = value; }
        }

        /// <summary>
        /// Reservefeld
        /// </summary>
        private string RESERVE { get; set; }       

        public DBME Meldesachverhalt
        {
            get
            {
                return ListeDBME == null ? null : ListeDBME.SingleOrDefault();
            }
            set
            {
                ListeDBME = ListeDBME.Set(value);
                _hatDbme = null;
            }
        }

        

        public DBNA Name
        {
            get
            {
                return ListeDBNA == null ? null : ListeDBNA.SingleOrDefault();
            }
            set
            {
                ListeDBNA = ListeDBNA.Set(value);
                _hatDbna = null;
            }
        }

        

        public DBGB Geburtsangaben
        {
            get
            {
                return ListeDBGB == null ? null : ListeDBGB.SingleOrDefault();
            }
            set
            {
                ListeDBGB = ListeDBGB.Set(value);
                _hatDbgb = null;
            }
        }

        

        public DBAN Anschrift
        {
            get
            {
                return ListeDBAN == null ? null : ListeDBAN.SingleOrDefault();
            }
            set
            {
                ListeDBAN = ListeDBAN.Set(value);
                _hatDban = null;
            }
        }

        

        public DBEU EuropäischeVersicherungsnummer
        {
            get
            {
                return ListeDBEU == null ? null : ListeDBEU.SingleOrDefault();
            }
            set
            {
                ListeDBEU = ListeDBEU.Set(value);
                _hatDbeu = null;
            }
        }

        

        public DBUV Unfallversicherung
        {
            get 
            {
                return ListeDBUV == null ? null : ListeDBUV.SingleOrDefault();
            }
            set
            {
                ListeDBUV = ListeDBUV.Set(value);
                _hatDbuv = null;
            }
        }

        

        public DBKS KnappschaftSee
        {
            get
            {
                return ListeDBKS == null ? null : ListeDBKS.Select(x => x.Value).SingleOrDefault();
            }
            set
            {
                ListeDBKS = ListeDBKS.Set(WrapperDBKS.Create(value));
                _hatDbks = null;
            }
        }

        public DBSV Sozialversicherungsausweis
        {
            get
            {
                return ListeDBSV == null ? null : ListeDBSV.SingleOrDefault();
            }
            set
            {
                ListeDBSV = ListeDBSV.Set(value);
                _hatDbsv = null;
            }
        }

        public DBKV Krankenversicherung
        {
            get
            {
                return ListeDBKV == null ? null : ListeDBKV.SingleOrDefault();
            }
            set
            {
                ListeDBKV = ListeDBKV.Set(value);
                _hatDbkv = null;
            }
        }

        public DBVR Vergabe
        {
            get
            {
                return ListeDBVR == null ? null : ListeDBVR.SingleOrDefault();
            }
            set
            {
                ListeDBVR = ListeDBVR.Set(value);
                _hatDbvr = null;
            }
        }

        public DBRG Rückmeldung
        {
            get
            {
                return ListeDBRG == null ? null : ListeDBRG.SingleOrDefault();
            }
            set
            {
                ListeDBRG = ListeDBRG.Set(value);
                _hatDbrg = null;
            }
        }

        public DBSO Sofortmeldung
        {
            get
            {
                return ListeDBSO == null ? null : ListeDBSO.SingleOrDefault();
            }
            set
            {
                ListeDBSO = ListeDBSO.Set(value);
                _hatDbso = null;
            }
        }

        private IList<DBME> ListeDBME { get; set; }

        private IList<DBNA> ListeDBNA { get; set; }

        private IList<DBGB> ListeDBGB { get; set; }

        private IList<DBAN> ListeDBAN { get; set; }

        private IList<DBEU> ListeDBEU { get; set; }

        private IList<DBUV> ListeDBUV { get; set; }

        private IList<WrapperDBKS> ListeDBKS { get; set; }

        private IList<DBSO> ListeDBSO { get; set; }

        private IList<DBKV> ListeDBKV { get; set; }

        private IList<DBSV> ListeDBSV { get; set; }

        private IList<DBVR> ListeDBVR { get; set; }

        private IList<DBRG> ListeDBRG { get; set; }        

        public IList<DBFE> DBFE { get; set; }

        private class WrapperDBKS
        {
            public DBKS Value { get; set; }

            public static WrapperDBKS Create(DBKS value)
            {
                if (value == null)
                    return null;
                return new WrapperDBKS
                {
                    Value = value,
                };
            }
        }
    }
}

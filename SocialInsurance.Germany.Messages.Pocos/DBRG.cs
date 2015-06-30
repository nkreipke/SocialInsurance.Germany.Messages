﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBRG - Rückmeldung des Zusammentreffens bei geringfügiger Beschäftigung
    /// </summary>
    public class DBRG : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBRG"/> Klasse.
        /// </summary>
        public DBRG()
        {
            KE = "DBRG";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt.
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Zeitraumbeginn der eingegangenen Meldung, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBG { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Zeitraumende der eingegangenen Meldung, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZREN { get; set; }

        /// <summary>
        /// Holt oder setzt das Personengruppenkennzeichen
        /// </summary>
        /// <remarks>
        /// Personengruppenkennzeichen der eingegangenen Meldung, Länge 3, Mussangabe
        /// </remarks>
        public string PERSGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage der eingegangenen Meldung, Länge 2, Mussangabe
        /// </remarks>
        public string ZLTG { get; set; }

        /// <summary>
        /// Holt oder setzt  das Währungskennzeichen
        /// </summary>
        /// <remarks>
        /// Währungskennzeichen D = DM E = Euro, Länge 1, Mussangabe
        /// </remarks>
        public string WG { get; set; }

        /// <summary>
        /// Holt oder setzt das Entgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 6, Mussangabe
        /// </remarks>
        public string EG { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel, Länge 4, Stelle 1 = KV Stelle 2 = RV Stelle 3 = ALV Stelle 4 = PV
        /// </remarks>
        public string BYGR { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Arbeitgebers, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAG { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Krankenkasse, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRKK { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen der verbalen Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string NABE1 { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen der verbalen Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string NABE2 { get; set; }

        /// <summary>
        /// Holt oder setzt die Strasse der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string STR { get; set; }

        /// <summary>
        /// Holt oder setzt die PLZ der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 5, Mussangabe
        /// </remarks>
        public string PLZ { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 32, Mussangabe
        /// </remarks>
        public string ORT { get; set; }

        /// <summary>
        /// Holt oder setzt den PZB der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 19, Mussangabe
        /// </remarks>
        public string PZB { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der angehängten Teile
        /// </summary>
        /// <remarks>
        /// Anzahl der angehängten Teile, Länge 2, Mussangabe
        /// </remarks>
        public string ANRG { get; set; }
    }
}
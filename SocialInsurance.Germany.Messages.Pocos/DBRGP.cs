﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// sich wiederholende Werte des DBRG, wiederholen sich entsprechend der Anzahl im Feld ZAEHLER von DBRG
    /// </summary>
    public class DBRGP
    {
        /// <summary>
        /// Holt oder setzt den Beginn des Zeitraums der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Zeitraumbeginn der eingegangenen Meldung, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRBGNN { get; set; }

        /// <summary>
        /// Holt oder setzt das Ende des Zeitraums der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Zeitraumende der eingegangenen Meldung, Länge 8, Mussangabe
        /// </remarks>
        public DateTime ZRENNN { get; set; }

        /// <summary>
        /// Holt oder setzt das Personengruppenkennzeichen
        /// </summary>
        /// <remarks>
        /// Personengruppenkennzeichen der eingegangenen Meldung, Länge 3, Mussangabe
        /// </remarks>
        public int PERSGRNN { get; set; }

        /// <summary>
        /// Holt oder setzt die Anzahl der Tage der eingegangenen Meldung
        /// </summary>
        /// <remarks>
        /// Anzahl der Tage der eingegangenen Meldung, Länge 2, Mussangabe
        /// </remarks>
        public int ZLTGNN { get; set; }

        /// <summary>
        /// Holt oder setzt  das Währungskennzeichen
        /// </summary>
        /// <remarks>
        /// Währungskennzeichen D = DM E = Euro, Länge 1, Mussangabe
        /// </remarks>
        public string WGNN { get; set; }

        /// <summary>
        /// Holt oder setzt das Entgelt
        /// </summary>
        /// <remarks>
        /// Entgelt, Länge 6, Mussangabe
        /// </remarks>
        public int EGNN { get; set; }

        /// <summary>
        /// Holt oder setzt den Beitragsgruppenschlüssel
        /// </summary>
        /// <remarks>
        /// Beitragsgruppenschlüssel, Länge 4, Stelle 1 = KV Stelle 2 = RV Stelle 3 = ALV Stelle 4 = PV
        /// </remarks>
        public int BYGRNN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer des Arbeitgebers
        /// </summary>
        /// <remarks>
        /// Betriebsnummer des Arbeitgebers, Länge 15, Mussangabe
        /// </remarks>
        public string BBNRAGNN { get; set; }

        /// <summary>
        /// Holt oder setzt die Betriebsnummer der Krankenkasse
        /// </summary>
        /// <remarks>
        /// Betriebsnummer der Krankenkasse, Länge 15, Mussangabe
        /// </remarks>
        public string EPNRNN { get; set; }

        /// <summary>
        /// Holt oder setzt den Hinweis der Art der Überschneidung
        /// </summary>
        /// <remarks>
        /// Hinweis der Art der Überschneidung, Länge 4, Mussangabe unter Bedingungen
        /// </remarks>
        public string HWNN { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen der verbalen Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string NABE1NN { get; set; }

        /// <summary>
        /// Holt oder setzt den Namen der verbalen Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string NABE2NN { get; set; }

        /// <summary>
        /// Holt oder setzt die Strasse der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 28, Mussangabe
        /// </remarks>
        public string STRNN { get; set; }

        /// <summary>
        /// Holt oder setzt die PLZ der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 5, Mussangabe
        /// </remarks>
        public int PLZNN { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 32, Mussangabe
        /// </remarks>
        public string ORTNN { get; set; }

        /// <summary>
        /// Holt oder setzt den PZB der verbalen  Angabe zur BBNR-AG
        /// </summary>
        /// <remarks>
        /// Verbale Angabe zur BBNR-AG-nn aus der Betriebsdatei der BA, Länge 19, Mussangabe
        /// </remarks>
        public string PZBNN { get; set; }
    }
}
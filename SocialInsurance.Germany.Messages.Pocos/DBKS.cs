﻿// <copyright file="DBKS.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace SocialInsurance.Germany.Messages.Pocos
{
    /// <summary>
    /// Datenbaustein: DBKS - Knappschaft/See
    /// </summary>
    public abstract class DBKS : IDatenbaustein
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="DBKS"/> Klasse
        /// </summary>
        public DBKS()
        {
            KE = "DBKS";
        }

        /// <summary>
        /// Holt oder setzt die Kennung
        /// </summary>
        /// <remarks>
        /// Kennung, um welchen Datenbaustein es sich handelt
        /// </remarks>
        public string KE { get; set; }

        /// <summary>
        /// Holt oder setzt die Kennzeichen-Daten für S = See oder K = Knappschaft
        /// </summary>
        /// <remarks>
        /// Kennzeichen-Daten, Länge 1, Mussangabe
        /// Vorhanden für
        /// K = knappschaftliche SV
        /// S = See-SV
        /// </remarks>
        public string KENNZKS { get; set; }
    }
}

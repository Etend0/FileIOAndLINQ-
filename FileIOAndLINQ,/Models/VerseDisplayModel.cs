using System;
using System.Collections.Generic;
using System.Text;

/*
 * Elijah Hodge
 * CST - 250
 * 04/05/2026
 * File I/O and LINQ
 * Activity 6
 */

namespace FileIOAndLINQ.Models
{
    internal class VerseDisplayModel
    {
        // Class level properties
        public string Reference { get; set; }
        public string Text { get; set; }
        public string Meaning { get; set; }
        public int Importance { get; set; }

        /// <summary>
        /// Default constructor for the Verse Display Model
        /// </summary>
        public VerseDisplayModel()
        {
            // Set the properties to empty string
            Reference = "";
            Text = "";
            Meaning = "";
            Importance = 0;
        }

        /// <summary>
        /// Parameterzed constructor for the Verse Display Model
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="text"></param>
        /// <param name="meaning"></param>
        /// <param name="importance"></param>
        public VerseDisplayModel(string reference, string text, string meaning, int importance)
        {
            Reference = reference;
            Text = text;
            Meaning = meaning;
            Importance = importance;
        }
    }
}

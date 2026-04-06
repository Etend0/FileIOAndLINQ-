using FileIOAndLINQ.Models;
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

namespace FileIOAndLINQ.Services.DataAccessLayer
{
    class VerseDAO
    {
        // Declare class level variables
        List<VerseDataModel> _verses;

        /// <summary>
        /// Default constructor for VerseDAO
        /// </summary>
        public VerseDAO()
        {
            // Create a new List of VerseDataModels
            _verses = new List<VerseDataModel>();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseDataModel verse)
        {
            // Declare and initialize
            int id = _verses.Count + 1;
            VerseDataModel newVerse = new VerseDataModel();

            // Create a new verse based on the verse request model
            newVerse = new VerseDataModel(id, verse.Book, verse.Chapter,
                verse.Verse, verse.Text, verse.Meaning, verse.Importance);
            // Add the verse to the verses list
            _verses.Add(verse);
            // Return the id of the new verse
            return id;
        }
    }
}

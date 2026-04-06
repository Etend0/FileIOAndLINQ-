using FileIOAndLINQ.Services.DataAccessLayer;
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

namespace FileIOAndLINQ.Services.BusinessLogicLayer
{
    class VerseLogic
    {
        // Class level variables
        private VerseDAO _verseDAO;

        /// <summary>
        /// Default constructor for VerseLogic
        /// </summary>
        public VerseLogic()
        {
            // Initialize the data access object
            _verseDAO = new VerseDAO();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseRequestModel verse)
        {
            // Call the AddVerse method in the data access layer and return the result
            return _verseDAO.AddVerse(verse);
        }

        public List<VerseDisplayModel> GetAllVerses()
        {
            // Declare and initialize
            // Get the verses from the DAO
            List<VerseDataModel> dataVerses = _verseDAO.GetAllVerses();
            // Create a DisplayModel list
            List<VerseDisplayModel> displayVerses = new List<VerseDisplayModel>();
            string reference = "";

            // Loop through the dataVerses list
            foreach (VerseDataModel verse in dataVerses)
            {
                // Use the book, chapter, and verse to create the reference
                reference = $"{verse.Book} {verse.Chapter}:{verse.Verse}";
                // Create a display verse model using the VerseDataModel verse
                VerseDisplayModel displayVerse = new VerseDisplayModel(reference, verse.Text, verse.Meaning, verse.Importance);
                // Add the display model to the displayVerses list
                displayVerses.Add(displayVerse);
            }
            // Return the list of VerseDisplayModels
            return displayVerses;
        }
    }
}

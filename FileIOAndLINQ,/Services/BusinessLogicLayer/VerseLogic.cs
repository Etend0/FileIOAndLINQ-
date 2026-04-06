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
    }
}

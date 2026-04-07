using FileIOAndLINQ.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

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
            ExcelPackage.License.SetNonCommercialPersonal("<Elijah Hodge>");
            // Create a new List of VerseDataModels
            _verses = new List<VerseDataModel>();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseRequestModel verse)
        {
            // Declare and initialize
            int id = _verses.Count + 1;
            VerseDataModel newVerse = new VerseDataModel(id, verse.Book, verse.Chapter,
                verse.Verse, verse.Text, verse.Meaning, verse.Importance);
            // Add the verse to the verses list
            _verses.Add(newVerse);
            // Do not increment the saved count here
            return id;
        }

        /// <summary>
        /// Get the list of verses in the inventory
        /// </summary>
        /// <returns></returns>
        public List<VerseDataModel> GetAllVerses()
        {
            // Return the _verses list
            return _verses;
        }

        /// <summary>
        /// Write the verses list to the given file
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public string WriteVerseToFile(string fileName)
        {
            // Declare and initialize
            string serialized = "";
            // Create a switch based on the file extension
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    // Loop through the _verse list
                    foreach (VerseDataModel verse in _verses)
                    {
                        // Add each verse to the serialized string
                        serialized += verse.ToString() + "\n";
                    }
                    break;
                case ".json":
                    // Use ServiceStack to serialize to json
                    serialized = ServiceStack.Text.JsonSerializer.SerializeToString(_verses);
                    break;
                case ".csv":
                    // Use ServiceStack to serialize to csv
                    serialized = ServiceStack.Text.CsvSerializer.SerializeToString(_verses);
                    break;
                case ".xml":
                    // Use ServiceStack to serialize to xml
                    serialized = ServiceStack.Text.XmlSerializer.SerializeToString(_verses);
                    break;
                case ".xlsx":
                    try
                    {
                        // Use EPPlus to write to an Excel file
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            // Add a new worksheet to the workbook
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Verses");
                            worksheet.Cells[1, 1].Value = "Id";
                            worksheet.Cells[1, 2].Value = "Book";
                            worksheet.Cells[1, 3].Value = "Chapter";
                            worksheet.Cells[1, 4].Value = "Verse";
                            worksheet.Cells[1, 5].Value = "Text";
                            worksheet.Cells[1, 6].Value = "Meaning";
                            worksheet.Cells[1, 7].Value = "Importance";
                            // Loop through the _verses list and add each verse to the worksheet
                            for (int i = 0; i < _verses.Count; i++)
                            {
                                int row = i + 2;
                                worksheet.Cells[row, 1].Value = _verses[i].Id;
                                worksheet.Cells[row, 2].Value = _verses[i].Book;
                                worksheet.Cells[row, 3].Value = _verses[i].Chapter;
                                worksheet.Cells[row, 4].Value = _verses[i].Verse;
                                worksheet.Cells[row, 5].Value = _verses[i].Text;
                                worksheet.Cells[row, 6].Value = _verses[i].Meaning;
                                worksheet.Cells[row, 7].Value = _verses[i].Importance;
                            }
                            // Save the package to the file
                            FileInfo fileInfo = new FileInfo(fileName);
                            package.SaveAs(fileInfo);
                        }
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                    // Return here if the file is an Excel file since it is handled separately
                    break;
                default:
                    return "File not recognized";
            }
            try
            {
                // If we successfully serialized and the file is not an Excel file, write the serialized string to the file
                if (Path.GetExtension(fileName) != ".xlsx")
                {
                    File.WriteAllText(fileName, serialized);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            // Return a success message to the user
            return "The verses have been saved to your file";
        }

        /// <summary>
        /// Read verses from the given file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string ReadVersesFromFile(string fileName)
        {
            // Clear the current verses list to avoid duplicates
            _verses.Clear();

            // Declare and initialize
            string data = "";
            List<VerseDataModel> dataVerses = new List<VerseDataModel>();

            // Handle xlsx separately since EPPlus reads the file directly
            if (Path.GetExtension(fileName) == ".xlsx")
            {
                // Set up a try-catch to read the Excel file
                try
                {
                    // Use EPPlus to read from an Excel file
                    FileInfo fileInfo = new FileInfo(fileName);
                    // Check if the file exists
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        // Get the first worksheet
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        // Get the number of rows with data
                        int rowCount = worksheet.Dimension.Rows;
                        // Loop through each row starting at row 2
                        for (int row = 2; row <= rowCount; row++)
                        {
                            // Create a new VerseDataModel from each row
                            VerseDataModel verse = new VerseDataModel(
                                0,
                                worksheet.Cells[row, 2].Value?.ToString() ?? "",
                                int.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out int chapter) ? chapter : 0,
                                worksheet.Cells[row, 4].Value?.ToString() ?? "",
                                worksheet.Cells[row, 5].Value?.ToString() ?? "",
                                worksheet.Cells[row, 6].Value?.ToString() ?? "",
                                int.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out int importance) ? importance : 0
                            );
                            // Add the verse to the dataVerses list
                            dataVerses.Add(verse);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                // Set up a try-catch to read files text
                try
                {
                    // Get the text from the file
                    data = File.ReadAllText(fileName);
                }
                catch (Exception ex)
                {
                    // Return the exception message
                    return ex.Message;
                }
                // Create a switch based on the file extension
                switch (Path.GetExtension(fileName))
                {
                    case ".txt":
                        // Split the text file on the newline character
                        string[] lines = data.Split("\n");
                        // Loop through the array of lines
                        foreach (string line in lines)
                        {
                            // Check if each line contains data
                            if (!string.IsNullOrEmpty(line))
                            {
                                // If so, convert the data to a VerseDataModel
                                //    and add it to the dataVerses list
                                dataVerses.Add(ConvertTxtToVerseDataModel(line));
                            }
                        }
                        break;

                    case ".json":
                        // Deserialize the data using the JsonSerializer
                        dataVerses = ServiceStack.Text.JsonSerializer.DeserializeFromString<List<VerseDataModel>>(data);
                        break;

                    case ".csv":
                        // Deserialize the data using the CsvSerializer
                        dataVerses = ServiceStack.Text.CsvSerializer.DeserializeFromString<List<VerseDataModel>>(data);
                        break;

                    case ".xml":
                        // Deserialize the data using the XmlSerializer
                        dataVerses = ServiceStack.Text.XmlSerializer.DeserializeFromString<List<VerseDataModel>>(data);
                        break;

                    default:
                        // Return the issue to the user
                        return "File not recognized";
                }
            }
            // Loop throughhe dataVerses list
            foreach (VerseDataModel newVerse in dataVerses)
            {
                // Set the id for each new verse
                newVerse.Id = _verses.Count + 1;
                // Add the new verse to the _verses list
                _verses.Add(newVerse);
            }
            // Return a success message to the user
            return "The verses have been read from your file and added to the list";
        } // End of ReadVersesFromFile

        /// <summary>
        /// Take a line from the text file and return a VerseDataModel
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public VerseDataModel ConvertTxtToVerseDataModel(string line)
        {
            // Declare and initialize
            string[] values;
            int chapter = 0, importance = 0;
            VerseDataModel verse;

            // Split the line on '* '
            values = line.Split("* ");
            // Use a try parse to parse the chapter
            int.TryParse(values[1], out chapter);
            // Parse the importance
            int.TryParse(values[5], out importance);
            // Create the new verse
            verse = new VerseDataModel(0, values[0], chapter, values[2], values[3], values[4], importance);
            // Return the verse
            return verse;
        }

        /// <summary>
        /// Get a list of the least important verses
        /// </summary>
        /// <param name="numToFind"></param>
        /// <returns></returns>
        public List<VerseDataModel> GetLeastImportantVerses(int numToFind)
        {
            // Use LINQ query syntax to order the verses and select how
            //   many are needed based on the numToFind parameter
            List<VerseDataModel> leastImportantVerses = (from verse in _verses
                                                         orderby verse.Importance
                                                         select verse).Take(numToFind).ToList();
            // Return the lst of least important verses
            return leastImportantVerses;
        }

        /// <summary>
        /// Get a list of the most important verses
        /// </summary>
        /// <param name="numToFind"></param>
        /// <returns></returns>
        public List<VerseDataModel> GetMostImportantVerses(int numToFind)
        {
            // Use LINQ method query syntax to order the verses and select how
            //   many are needed based on the numToFind parameter
            List<VerseDataModel> mostImportantVerses = _verses.OrderByDescending(verse => verse.Importance).Take(numToFind).ToList();
            // Return the list of the most important verses
            return mostImportantVerses;
        }

        /// <summary>
        /// Calculates the total number of verses, including ranges (example, 1-3 counts as 3 verses)
        /// </summary>
        /// <returns>Total number of verses</returns>
        public int GetTotalVerseCount()
        {
            // Calculate the total number of verses in the current _verses list including ranges and comma-separated values
            int total = 0;
            // Loop through the _verses list and calculate the total based on the Verse property
            foreach (var verse in _verses)
            {
                // Check if the Verse property is empty or whitespace, count it as 1 verse
                if (string.IsNullOrWhiteSpace(verse.Verse))
                {
                    // Increment the total by 1 and continue to the next verse
                    total += 1;
                    continue;
                }
                // Check if the Verse property contains a range and calculate the number of verses in the range
                var parts = verse.Verse.Split(new[] { '-', '–', '—' }, StringSplitOptions.RemoveEmptyEntries);
                // If there are exactly 2 parts and both can be parsed as integers, calculate the number of verses in the range
                if (parts.Length == 2)
                {
                    // Use a try parse to parse the start and end of the range
                    if (int.TryParse(parts[0].Trim(), out int start) && int.TryParse(parts[1].Trim(), out int end) && end >= start)
                    {
                        // Increment the total by the number of verses in the range and continue to the next verse
                        total += (end - start + 1);
                        continue;
                    }
                }
                // If the Verse property does not contain a range, check if it contains multiple verses separated by commas and calculate the number of verses
                if (verse.Verse.Contains(","))
                {
                    // Increment the total by the number of verses separated by commas
                    total += verse.Verse.Split(',').Length;
                }
                else
                {
                    // Otherwise, count it as 1 verse
                    total += 1;
                }
            }
            // Return the total count of verses
            return total;
        }
    }
}

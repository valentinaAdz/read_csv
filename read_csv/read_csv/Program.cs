using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;



namespace read_csv
{
    class Program
    {
        static void Main()
        {
            string sourceFilePath = @"C:\\sample.csv ";
    
            // Create a FileStream object so that you can interact with the file
            // system.
            FileStream sourceFile = new FileStream(
                sourceFilePath,  // Pass in the source file path.
                FileMode.Open,   // Open an existing file.
                FileAccess.Read);// Read an existing file.
            StreamReader reader = new StreamReader(sourceFile);
            StringBuilder fileContents = new StringBuilder();
            // Check to see if the end of the file
            // has been reached.
            while (reader.Peek() != -1)
            {
                // Read the next character.
                fileContents.Append((char)reader.Read());
            }
            // Store the file contents in a new string variable.
            string data = fileContents.ToString();
            // Always close the underlying streams release any file handles.
            reader.Close();
            sourceFile.Close();

            Console.WriteLine(fileContents);
        }
        
    }
}



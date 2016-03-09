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
		//parametri od komandna linija
		//parematar cela pateka na fajlot
		//vtor parametar, dali prviot red e zaglavie (opis na kolonite), da ili, yes no, with_header
        static void Main()
        {
            string sourceFilePath = @"C:\\sample.csv ";
    
            // Create a FileStream object so that you can interact with the file
            // system.
			//promenlivi gi deklariras posebno
			//FileStream sourceFile=null;
			//potoa vo try se stava kodot za kreiranje na objektite so cel da se fatat isklucoci pocnuvajki od notenoughmemory pa do interna inicijalizacija na samite specificni objketi
            FileStream sourceFile = new FileStream(
                sourceFilePath,  // Pass in the source file path.
                FileMode.Open,   // Open an existing file.
                FileAccess.Read);// Read an existing file.
								 // Shared mode, da ne bide exclusive lock
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
			//vo finally clausuly, so cel sigurno da se izvrsat, bez razlika dali imalo isklucok ili ne.
			//bezbedno programiranje, pokvaliteten kod, poveke vreme, no od struga tesko da padne.
            reader.Close();
            sourceFile.Close();

            Console.WriteLine(fileContents);//moze da odi vo final, no so proverka dali filecontents ne e null. ?
        }
		//Na kraj, ke go smenis ciklusot
		//Ako ima zaglavie, togas prviot red e iminja na kolonite
		//DataTable ke kreiras so naziv na kolonite da odgovaraat na procitanite iminja na razdoveni nazivi od prviot red.
		//Od vtoriot kako ke gi razdvois vrednosti, taka ke gi postavis vo DataTable vo soodvetnata kolona.
		//Site od tip stringovi
		//Na kraj vo finaly, Dump na DataTable vo string nekoj. ToString. ToXml().ToString().
        
    }
}



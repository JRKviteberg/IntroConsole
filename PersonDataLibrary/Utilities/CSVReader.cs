namespace PersonDataLibrary.Utilities;

public static class CSVReader
{
    public static IEnumerable<string[]> ReadFromFile(string fileName)
    {
        // oppretter liste med string -> hver linje splittes til string[] og puttes i liste!!!
        var csvList = new List<string[]>();

        if (!File.Exists(fileName)) 
            throw new FileNotFoundException($"Finner ikke filen: {fileName}");
        
        // Exception !! 
        try
        {
            // using -> (python: with open)
            using StreamReader reader = new StreamReader(fileName, System.Text.Encoding.UTF8);
            
            // header line
            string? header = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                
            }
        }
        // catch (IOException ioEx) {}
        catch (Exception e)
        {
            // Logge
            Console.WriteLine(e.ToString());
            throw;
        }

        return csvList;
    }
    
}
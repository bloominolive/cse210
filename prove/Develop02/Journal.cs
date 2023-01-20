using System.Text;

public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void Display(){
        foreach (var entry in _entries){
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void Save(string fileName){
        String file = @$"{fileName}";
        String separator = ",";
        StringBuilder journal = new StringBuilder();

        if(!File.Exists(file)){
            String[] headings = { "Date", "Prompt", "Response"};
            journal.AppendLine(string.Join(separator, headings));
        }
    
        foreach (Entry entry in _entries){
            String[] newLine = { entry._date, entry._prompt, entry._response};
            journal.AppendLine(string.Join(separator, newLine));
        }

        try
        {
            File.AppendAllText(file, journal.ToString());
        }
        catch(Exception)
        {
            Console.WriteLine("Data could not be written to the CSV file.");
            return;
        }
    }

    public Journal Load(string file){
        Journal journal = new Journal();
        using(var reader = new StreamReader(@$"{file}"))
        {
            while(!reader.EndOfStream)
            {
                var values = reader.ReadLine().Split(',');
                Entry entry = new Entry{
                    _date = values[0],
                    _prompt = values[1],
                    _response = values[2]
                };
                journal._entries.Add(entry);                
            }
        }
        return journal;
    }
}
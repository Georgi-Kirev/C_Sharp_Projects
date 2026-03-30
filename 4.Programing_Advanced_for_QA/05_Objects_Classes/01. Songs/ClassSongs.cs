// Input

public class SongsClass
{
    // Характеристики които приема не е задължително да го има !!! -> properties
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    // Констуктор -> специален метод с който си създаваме обекти от класа.
    public SongsClass(string typelist, string name, string time)
    {
        // Това е новият празен обект от класа SongsClass
        // Той притежава Характеристиките/properties от класа: TypeList, Name, Time
        TypeList = typelist;
        Name = name;
        Time = time;
    }

    // действия които прави не е задължително да го има !!! -> methods -> Принтиране, проверки калкулации...

}


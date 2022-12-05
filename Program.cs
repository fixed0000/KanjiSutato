// See https://aka.ms/new-console-template for more information
void StartKanjiApp()
{
    var kanjiNumber = new Dictionary<int, string>()
    {
        {Kanji.NumberInRow, "食", Kanji.UsedToday, Kanji.currentStreak},
        [2] = "点",
        [3] = "光"
    };
    int KanjiCount = 0;
    Console.WriteLine("Let, learn Kanji. Choose a number." +
        "1. Learn Kanji" +
        "2. Add Kanji" +
        "3. Exit");
    int Choice = Convert.ToInt32(Console.ReadLine());
    if (Choice == 1)
    {
        Console.WriteLine("Learning Kanji");
    }
    else if (Choice == 2)
    {
        Console.WriteLine("Write a Kanji you want to add");
        string NewKanji = Console.ReadLine();
        if (NewKanji.Equals(null))
        {
            StartKanjiApp();
        }
        else
        {
            bool isExist = Array.Exists<string>(kanjiNumber,NewKanji);
            if (isExist)
                    {
                Console.WriteLine("Kanji has already been added. Returning.");
                    };
            int Wrote = +1;
            int KanjiAdded = +1;
        }
        Console.WriteLine("Write all the kunyomi readings");
    }
    else if (Choice == 3)
    {
        System.Environment.Exit(1);
    }
    else
    { Console.WriteLine("Error. Write again.");
    StartKanjiApp();
    }

    void AddingKanji()
    {
        Console.WriteLine("Write all the kunyomi readings you want to add");
        string NewKunReading = Console.ReadLine();
        KanjiSutato.Kanji NewKanji = new KanjiSutato.Kanji();
        NewKanji.kunyomi = NewKunReading;
        Console.WriteLine("Write all the onyomi readings you want to add");
        string NewOnReading = Console.ReadLine();
        NewKanji.onyomi = NewOnReading;
        Console.WriteLine("Write the translations you want to add");
        string NewTranslation = Console.ReadLine();
        NewKanji.translation = NewTranslation;
        Console.WriteLine("Write the kanji you want to add");
        string NewKanjiItself = Console.ReadLine();
        NewKanji.kanjiItself = NewKanjiItself;
        String StringKaItself = (NewKanjiItself.ToString());
        KanjiSutato.Kanji (StringKaItself) = new KanjiSutato();
    }

    void IfDoneKanji()
    {
        if (UsingNow.Wrote <= 10)
        {
            Console.WriteLine("Congratulations. This Kanji will not appear anymore");
        }
        else
        { }            
    }

    void KanjiRoll()
    {
        kanjiNumber.OrderBy(Kanji.currentStreak);
        IfDoneKanji();

    }
}

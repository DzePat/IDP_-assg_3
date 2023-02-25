namespace Element
{
    class MainClass
    {
        //uppgift 1 make a class
        //uppgift 3 add print() to the class
        class Element {

            public string namn, atomnummer, typ, smältpunkt, kokpunkt;

            public void print()
            {
                Console.WriteLine($"Grundämne: {namn}");
                Console.WriteLine($"    typ: {typ}");
                Console.WriteLine($"    smältpunkt: {smältpunkt} K");
                Console.WriteLine($"    kokpunkt: {kokpunkt} K");
            }
        
        }

        //uppgift 2 add 3 elements syre,järn, guld
        //uppgift 4 made an array of 6 elements, assigned 3 existing elements to 0-2 index and added 3 new elements to the remaining indexes
        public static void Main(string[] args)
        {
            Element syre = new Element() { namn = "syre", atomnummer = "8", typ = "ickemetall", smältpunkt = "55.36", kokpunkt = "90.188" };
            Element järn = new Element() { namn = "järn", atomnummer = "26", typ = "metall", smältpunkt = "1811", kokpunkt = "3134" };
            Element guld = new Element() { namn = "guld", atomnummer = "79", typ = "metall", smältpunkt = "1337.33", kokpunkt = "3243" };
            syre.print();
            järn.print();
            guld.print();
            Element[] elements = new Element[6]
                {
                syre,
                järn,
                guld,
                new Element()
                {
                    namn = "väte",
                    atomnummer = "1",
                    typ = "ickemetall",
                    smältpunkt = "13.99",
                    kokpunkt = "20.271"},
                new Element()
                {
                    namn = "brom",
                    atomnummer = "35",
                    typ = "ickemetall",
                    smältpunkt = "265.8",
                    kokpunkt = "332.0"},
                new Element()
                {
                    namn = "kvicksilver",
                    atomnummer = "80",
                    typ = "metall",
                    smältpunkt = "234.3210",
                    kokpunkt = "629.88"},
                };

        }
    }
}
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
        public static void Main(string[] args)
        {
            Element syre = new Element() { namn = "syre", atomnummer = "8", typ = "ickemetall", smältpunkt = "55.36", kokpunkt = "90.188" };
            Element järn = new Element() { namn = "järn", atomnummer = "26", typ = "metall", smältpunkt = "1811", kokpunkt = "3134" };
            Element guld = new Element() { namn = "guld", atomnummer = "79", typ = "metall", smältpunkt = "1337.33", kokpunkt = "3243" };
            syre.print();
            järn.print();
            guld.print();

        }
    }
}
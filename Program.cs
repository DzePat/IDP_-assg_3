namespace Element
{
    class MainClass
    {
        //uppgift 1 make a class
        //uppgift 3 add print() to the class
        class Element {

            public string namn, atomnummer, typ;
            public double smältpunkt, kokpunkt;

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
            Element syre = new Element() { namn = "syre", atomnummer = "8", typ = "ickemetall", smältpunkt = 55.36, kokpunkt = 90.188 };
            Element järn = new Element() { namn = "järn", atomnummer = "26", typ = "metall", smältpunkt = 1811, kokpunkt = 3134 };
            Element guld = new Element() { namn = "guld", atomnummer = "79", typ = "metall", smältpunkt = 1337.33, kokpunkt = 3243 };
            syre.print();
            järn.print();
            guld.print();
            //uppgift 4 add an array of 6 elements, assign 3 existing elements to 0-2 index and assign 3 new elements to the remaining indexes
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
                    smältpunkt = 13.99,
                    kokpunkt = 20.271},
                new Element()
                {
                    namn = "brom",
                    atomnummer = "35",
                    typ = "ickemetall",
                    smältpunkt = 265.8,
                    kokpunkt = 332.0},
                new Element()
                {
                    namn = "kvicksilver",
                    atomnummer = "80",
                    typ = "metall",
                    smältpunkt = 234.3210,
                    kokpunkt = 629.88},
                };
            //uppgift 5 add a foreach loop that prints all the elements out from the array
            foreach(Element element in elements)
            {
                element.print();
            };
            // uppgift 6 add a foreach loop that only prints out the name of the element that is metal
            foreach (Element element in elements)
            {
                if (element.typ == "metall")
                {
                    Console.WriteLine(element.namn);
                }
            };
            //uppgift 7 add a foreach loop that prints out the element that only has melting point under 273.16K and boiling point above 273.16K
            foreach(Element element in elements)
            {
                if (element.smältpunkt < 273.16 && element.kokpunkt > 273.16)
                {
                    Console.WriteLine(element.namn);
                }
            }
        }
    }
}
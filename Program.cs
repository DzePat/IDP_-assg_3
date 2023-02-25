namespace Element
{
    class MainClass
    {

        class Element {

            public string namn, atomnummer, typ, smältpunkt, kokpunkt;
        
        }


        public static void Main(string[] args)
        {
            Element syre = new Element() { namn = "syre", atomnummer = "8", typ = "ickemetall", smältpunkt = "55.36", kokpunkt = "90.188" };
            Element järn = new Element() { namn = "järn", atomnummer = "26", typ = "metall", smältpunkt = "1811", kokpunkt = "3134" };
            Element guld = new Element() { namn = "guld", atomnummer = "79", typ = "metall", smältpunkt = "1337.33", kokpunkt = "3243" };


        }
    }
}
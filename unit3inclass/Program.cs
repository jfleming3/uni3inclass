using System;

namespace unit3inclass
{
    class rocket
    {
        private String name;
        private int model;

        public rocket()
        {
            name = "";
            model = 0;
        }


        public rocket(String nname, int nmodel)
        {
            model = nmodel;
            name = nname;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi github");
        }


    }
}

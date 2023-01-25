namespace CollectionsProject
{
    internal class Class9
    {
        static void Main()
        {
            string[] Colors = { "Green","Yellow","Blue","Purple","Orange","Red","Black","Brown","Aqua" };

            ////list of all colors
            //var coll1 = from s in Colors select s;
            //Console.WriteLine(string.Join(" ",coll1));

            ////list of all colors in asceending order
            //var coll2 = from s in Colors orderby s   select s;
            //Console.WriteLine(string.Join(" ",coll2));

            ////list of all colors in descending  order
            //var coll4 = from s in Colors orderby s descending select s;
            //Console.WriteLine(string.Join(" ", coll4));

            ////gets the color whose length is 5 character
            //var coll3=from s in Colors where s.Length==5 select s;
            //Console.WriteLine(string.Join(" ", coll3));

            //Console.WriteLine("\n" + "\n");

            ////gets the colors whose start with character "B"
            //var coll5 = from s in Colors where s.StartsWith("B") select s;
            //Console.WriteLine(string.Join(" ", coll5));

            //var coll6 = from s in Colors where s[0] == 'B' select s;
            //Console.WriteLine(string.Join(" ", coll6));

            //var coll7 = from s in Colors where s.IndexOf('B') == 0 select s;
            //Console.WriteLine(string.Join(" ", coll7));

            //var coll8 = from s in Colors where s.Substring(0,1)=="B" select s;
            //Console.WriteLine(string.Join(" ", coll8));

            //Console.WriteLine("\n"+ "\n");

            ////gets the name of colors whose end with Character "E"
            //var coll9 = from s in Colors where s.EndsWith("e") select s;
            //Console.WriteLine(string.Join(" ", coll9));

            //var coll10 = from s in Colors where s[s.Length-1] == 'e' select s;
            //Console.WriteLine(string.Join(" ", coll10));

            //var coll11 = from s in Colors where s.IndexOf('e') == s.Length-1 select s;
            //Console.WriteLine(string.Join(" ", coll11));

            //var coll12 = from s in Colors where s.Substring(s.Length-1) == "e" select s;
            //Console.WriteLine(string.Join(" ", coll12));

            //Console.WriteLine("\n" + "\n");

            ////Getting the name of colors whose name contains 'a' 3rd character
            //var coll13 = from s in Colors where s.IndexOf('a') == 2 select s;
            //Console.WriteLine(string.Join(" ", coll13));

            //var coll14 = from s in Colors where s[2]=='a' select s;
            //Console.WriteLine(string.Join(" ", coll14));

            //var coll15 = from s in Colors where s.Substring(2,1) == "a" select s;
            //Console.WriteLine(string.Join(" ", coll15));

            //Console.WriteLine("\n" + "\n");

            ////getting he name of colors whose name contains "O" or "o" in it
            //var coll16 = from s in Colors where s.Contains('O') || s.Contains('o') select s;
            //Console.WriteLine(string.Join(" ", coll16));

            //var coll17 = from s in Colors where s.ToUpper().IndexOf('O') >=0 select s;
            //Console.WriteLine(string.Join(" ", coll17));

            Console.WriteLine("\n" + "\n");
            //getting the chracters whose name doesn't contain 'O' or 'o'
            var coll18 = from s in Colors where s.ToLower().Contains('O')==false select s;
            Console.WriteLine(string.Join(" ", coll18));

            var coll19= from s in Colors where s.ToUpper().IndexOf('O') ==-1 select s;
            Console.WriteLine(string.Join(" ", coll19));




            Console.ReadLine();
        }
    }
}

using System;

namespace H2G4D5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, String> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(35, "İzmir");
            myDictionary.Add(06, "Ankara");
            myDictionary.Add(58, "Sivas");

            Console.WriteLine(myDictionary.Length);

            foreach (var item in myDictionary.MyDictionaryItems)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}

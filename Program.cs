using System;
using System.Collections.Generic;

namespace CS_exercise1;

class Program
{
    static void Main(string[] args)
    {
        int a = 16;
        double x = 5.324d;
        string level = "user";

        //Array
        string[] day = {"Monday", "Wednesday", "Friday"};

        //List
        List<string> AuthorList = new List<string>();
        AuthorList.Add("Dickens");
        AuthorList.Add("Christie");
        AuthorList.Add("Tolkien");
        AuthorList.Add("Orwell");

        //Output array
        Console.WriteLine("Array:");
        for(int i=0; i<day.Length; i++){
            Console.WriteLine(day[i]);
        }
        Console.WriteLine();

        //Output List
        Console.WriteLine("List:");
        for(int i=0; i<AuthorList.Count; i++){
            Console.WriteLine(AuthorList[i]);
        }
        /*foreach(string author in AuthorList){
            Console.WriteLine(author);
        }*/
        Console.WriteLine();

        //Objects
        Robot healer = new Robot("Healer", 800, new byte[]{0,10,0});
        //healer.setValues("Healer", 800, new byte[]{0,10,0});
        healer.printValues();
        
        Robot killer = new Robot();
        killer.setValues("Killer", 1000, new byte[] {0,0,10});
        killer.printValues();

        Robot bot = new Robot("Bot");
        bot.printValues();

        Robot bot1 = new Robot("Bot1");
        bot1.printValues();

        Robot.printCount();
    


    }
}

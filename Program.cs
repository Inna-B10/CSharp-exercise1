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
        string[] day = {"Monday", "Wednesday", "Friday"};
        List<string> AuthorList = new List<string>();
        AuthorList.Add("Dickens");
        AuthorList.Add("Christie");
        AuthorList.Add("Tolkien");
        AuthorList.Add("Orwell");
        for(int i=0; i<day.Length; i++){
            Console.WriteLine(day[i]);
        }
        for(int i=0; i<AuthorList.Count; i++){
            Console.WriteLine(AuthorList[i]);
        }
        /*foreach(string author in AuthorList){
            Console.WriteLine(author);
        }*/
    }
}

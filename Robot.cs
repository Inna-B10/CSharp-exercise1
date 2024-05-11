using System;

namespace CS_exercise1{
  class Robot{
    private static int countObj;

    public string? Name {get; set;}="Bot";
    public int? Weight {get; set;}=100;
    public byte[] Coordinates {get; set;}={0,0,0};
    public int? Height {get; set;}=1;

    public Robot(){}
    public Robot(string? name, int? weight, byte[] coordinates, int? height){
      if(name !="")
      Name = name;
      if(weight<200||weight==null) Weight=200; else Weight= weight;
      if(coordinates.Length>0)
      Coordinates = coordinates;
      if (height != null)
      {
        Height = height;
      }
      countObj++;
    }
    
    public void printValues(){
      Console.Write($"Name: {Name}, weight: {Weight}, height: {Height}, coordinates: ");
      foreach (byte el in Coordinates){
        Console.Write(el+" ");
      }
      Console.WriteLine();
    }
    public static void printCount(){
      Console.WriteLine("Total created objects: "+countObj);
    }
  }
}
using System;

namespace CS_exercise1{
  class Robot{
    private static int countObj;
    private string name="Bot";
    private int weight=100;
    private byte[] coordinates={0,0,0};

    public Robot(string name, int weight, byte[] coordinates){
      this.setValues(name, weight, coordinates);
      countObj++;
    }
    public Robot(string name){
      this.name = name;
      countObj++;
    }

    public Robot(){
      countObj++;
    }

    public void setValues(string name, int weight, byte[] coordinates){
      this.name = name;
      this.weight= weight;
      this.coordinates = coordinates;
    }
    public void printValues(){
      Console.Write("Name: "+this.name+", weight: "+this.weight+", coordinates: ");
      foreach (byte el in coordinates){
        Console.Write(el+" ");
      }
      Console.WriteLine();
    }
    public static void printCount(){
      Console.WriteLine("Total created objects: "+countObj);
    }
  }
}
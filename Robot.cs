using System;

namespace CS_exercise1{
  class Robot{
    private string name;
    private int weight;
    private byte[] coordinates;

    public void setValues(string _name, int _weight, byte[] _coordinates){
      name = _name;
      weight= _weight;
      coordinates = _coordinates;
    }
    public void printValues(){
      Console.Write("Name: "+name+", weight: "+weight+", coordinates: ");
      foreach (byte el in coordinates){
        Console.Write(el+" ");
      }
      Console.WriteLine();
    }
  }
}
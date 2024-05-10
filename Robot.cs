using System;

namespace CS_exercise1{
  class Robot{
    private string name="Bot";
    private int weight=100;
    private byte[] coordinates={0,0,0};

    public Robot(string _name, int _weight, byte[] _coordinates){
      setValues(_name, _weight, _coordinates);
      Console.WriteLine("Object has been created");
    }
    public Robot(string _name){
      name = _name;
      Console.WriteLine("Object has been created");
    }

    public Robot(){
      Console.WriteLine("Object has been created");
    }

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
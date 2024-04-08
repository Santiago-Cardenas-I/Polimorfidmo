using System;


class Animal
{
  
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}


class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}


class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Animal animal1 = new Animal();
        Animal animal2 = new Perro();
        Animal animal3 = new Gato();

        
        animal1.HacerSonido(); 
        animal2.HacerSonido(); 
        animal3.HacerSonido(); 
    }
}

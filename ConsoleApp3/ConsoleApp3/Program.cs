using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

  
   class Zoo:Visitable
{
private String Animal;
    public Zoo(string animal)
    {
        this.Animal = animal;
    }
    public void accept(Visitor visitor)
    {
        visitor.visit(this);
    }
    public void printAnimalName()
    {
        Console.WriteLine("The name of this animal is " + Animal);
    }
    public string getAnimalName()
    {    return Animal; 
    }
    public void Hungry()
    {
        Console.WriteLine(Animal + " is hungry!!!!");
    }
}


class FeedFunction : Visitor
{
    Zoo extzoo;
    public void visit(Zoo zoo)
    {
        this.extzoo = zoo;
    }
    public void feedwithMeat()
    {
        String name = extzoo.getAnimalName();
        Console.WriteLine("we feeding meat to " + name);
        Console.WriteLine(name + " is so happy");
    }
    public void feedwithGrass()
    {
        String name = extzoo.getAnimalName();
        Console.WriteLine("we feeding grass to " + name);
        Console.WriteLine(name + " is so happy");
    }
}



public class VistorPattern
{
    public static void Main(string[] args)
    {
        String animal1 = "lion";
        String animal2 = "sheep";
        Zoo z = new Zoo(animal1);
        z.printAnimalName();
        z.Hungry();
        FeedFunction ff = new FeedFunction();
        z.accept(ff);
        ff.feedwithMeat();
        Console.WriteLine("*****************************************");
        Zoo zs = new Zoo(animal2);
        zs.printAnimalName();
        zs.Hungry();
        FeedFunction ffs = new FeedFunction();
        zs.accept(ffs);
        ffs.feedwithGrass();
    }
}




using System;

class Animal<T>
{
    private T data;

    public Animal(T data)
    {
        this.data = data;
    }

    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Bald eagle");
        Animal<string> animalHabitat = new Animal<string>("Within 2 1/2 miles of coasts, bays, rivers, lakes, and other bodies of water.");
        Animal<bool> endangered = new Animal<bool>(false);
        Animal<bool> extinct = new Animal<bool>(false);
        Animal<int> averageLifespan = new Animal<int>(25);

        Console.WriteLine("Animal Name: " + animalName.getAnimal());
        Console.WriteLine("Animal Habitat: " + animalHabitat.getAnimal());
        Console.WriteLine("Endangered: " + endangered.getAnimal());
        Console.WriteLine("Extinct: " + extinct.getAnimal());
        Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal() + " years");
    }
}


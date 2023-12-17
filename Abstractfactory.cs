using System;

//Абстрактні класи продуктів
abstract class AbstractProductA
{
    public abstract void DoSomething();
}

abstract class AbstractProductB
{
    public abstract void DoAnotherThing();
}

//Конкретні класи продуктів
class ConcreteProductA1 : AbstractProductA
{
    public override void DoSomething()
    {
        Console.WriteLine("Продукт А1 робить щось");
    }
}

class ConcreteProductA2 : AbstractProductA
{
    public override void DoSomething()
    {
        Console.WriteLine("Продукт А2 робить щось");
    }
}

class ConcreteProductB1 : AbstractProductB
{
    public override void DoAnotherThing()
    {
        Console.WriteLine("Продукт B1 робить щось друге");
    }
}

class ConcreteProductB2 : AbstractProductB
{
    public override void DoAnotherThing()
    {
        Console.WriteLine("Продукт B2 робить щось друге");
    }
}

//Абстрактний клас фабрики
abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

//Конкретні класи фабрик
class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

//Клієнтський код
class Client
{
    public void ClientCode(AbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        productA.DoSomething();
        productB.DoAnotherThing();
    }
}

class Program
{
    static void Main()
    {
        //Використання ConcreteFactory1
        var factory1 = new ConcreteFactory1();
        var client1 = new Client();
        client1.ClientCode(factory1);

        //Використання ConcreteFactory2
        var factory2 = new ConcreteFactory2();
        var client2 = new Client();
        client2.ClientCode(factory2);
    }
}

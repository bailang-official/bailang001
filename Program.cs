using System;

Mode wolf = new() { Id = 1 };
var category1 = new Mode(233, "panda", 20.3f, 180.0, false);

category1.SetId(233);
System.Console.WriteLine("Id is " + category1.GetId()); //先跑category1.GetId()，后跑"Id is "

category1.Eat("bamboo");

struct Mode //定义结构体类型名
{
    public int Id;
    public float weight;

    public double height;

    public string name;

    public bool Ismale;

    public void SetId(int value)

        if (value > 0)
        {
            Id = value;
        }
    }

    public int GetId()
    {
        System.Console.WriteLine("You have got the Id of " + name);
        return Id;
    }

    public int id
    {
        get { return Id; }
        set { Id = value; }
        //init;
    }

    public void Eat(string food)
    {
        System.Console.WriteLine(name + " eat " + food);
    }

    public Mode(int Id, string name, float weight, double height, bool Ismale)
    {
        this.id = Id;
        this.name = name;
        this.weight = weight;
        this.height = height;
        this.Ismale = Ismale;
    }

    // public Mode()
    // {
    //     System.Console.WriteLine("appear");
    // }
}
#pragma warning disable format

#pragma warning restore format



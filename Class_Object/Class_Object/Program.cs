// Program on Creating a Classes

Console.WriteLine("Hello");


Console.WriteLine("Enter your First Name");
string fn=Console.ReadLine().ToUpper();

Console.WriteLine("Enter your Last Name");
string ln = Console.ReadLine().ToUpper();

Console.WriteLine("Enter your Age");
float ag = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your vehicle make");
string mk = Console.ReadLine().ToUpper();

Console.WriteLine("Enter your vehicle model");
string md = Console.ReadLine().ToUpper();

Console.WriteLine("Enter your Tyres");
int ty = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your Gears");
int ge = int.Parse(Console.ReadLine());

Customer c1 = new Customer(fn, ln, ag);
c1.printfull();

vehicle v1 = new vehicle(mk, md, ty, ge);
v1.printout();



class Customer
{   string _FirstName;
    string _LastName;
    float _Age;

    public  Customer (string firstName, string lastName, float age)
    { 
        this._FirstName = firstName;
        this._LastName = lastName;
        this._Age = age;
    }

    public Customer(float age,string lastName,string firstName)
    {
        this._Age = age;
        this._FirstName = firstName;
        this._LastName = lastName;

    }

        public  void printfull ()
    {
        Console.WriteLine("\nCustomer Details\nName :- Mr/Mrs.{0}\nAge:-{1}", this._FirstName + " " + this._LastName,this._Age);
    }
}

class vehicle
{
    string _make;
    string _model;
    int _tyre;
    int _gears;


    public vehicle(string make,string model,int tyre,int speed)
    {
        this._make = make;
        this._model = model;
        this._tyre = tyre;  
        this._gears = speed;
    }

    public void printout()
    {
        Console.WriteLine("\nVehicle Owned\nMake:-{0}\nModel:-{1}\nTyres:-{2}\nGears:-{3}", this._make, this._model, this._tyre, this._gears);
    }
}

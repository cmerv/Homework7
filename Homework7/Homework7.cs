namespace Homework7;
class Homework7
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(initCusAge:28, initCusName:"Alice", initCusId:110);
        Customer Bob = new Customer(111,"Bob",30);
        Bob.PrintCusInfo();
        Alice.PrintCusInfo();
        Bob.SetCusId(221);
        Alice.SetCusId(220);

    }
}
class Customer 
{
    private int cus_id;
    public int Cus_Id 
    { 
        get { return cus_id; }
        private set { cus_id = value;}
    }
    public void SetCusId (int i)
    {
        this.Cus_Id = i;
    }  

    public int GetCusId()
    {
        return Cus_Id;
    }
    public string Cus_Name
    {
        get { return cus_name; }
        set { cus_name = value; }
    }
    public void SetCusName (string i)
    {
        Cus_Name = i;
    }
    public string GetCusName ()
    {
        return Cus_Name;
    }
    public int Cus_Age 
    {
        get { return cus_age; }
        set { cus_age = value; }
    }  
    public void SetCusAge (int i)
    {
        Cus_Age = i;
    }
    public int GetCusAge ()
    {
        return Cus_Age;
    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {this.GetCusId()}, name: {this.GetCusName()}, age:{this.GetCusAge()}");
    }

    public static void CompareAge(int i) 
    {
        
    }
    public string cus_name;
    public int cus_age;
    public Customer (int initCusId, string initCusName, int initCusAge) // constructor
    {
        this.cus_name = initCusName;
        this.cus_age = initCusAge;
        SetCusId(initCusId);
    }
}

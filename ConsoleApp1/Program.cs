

//Console.Write("Your Position : ");
//string posit = Console.ReadLine();

//Console.Write("Your Salary : ");
//float salary = float.Parse(Console.ReadLine());


//if (posit == "Assintant Developer")
//{
//    float sal = (float)(salary * 0.05);
//    Console.WriteLine("Salary Increase : {0}",salary+sal);
//}
//else if (posit == "IT Support")
//{
//    float sal = (float)(salary * 0.07);
//    Console.WriteLine("Salary Increase : {0}", salary + sal);
//}
//else if (posit == "Senior Developer")
//{
//    float sal = (float)(salary * 0.1);
//    Console.WriteLine("Salary Increase : {0}", salary + sal);
//}
//else if (posit == "Administrator")
//{
//    float sal = (float)(salary * 0.08);
//    Console.WriteLine("Salary Increase : {0}", salary + sal);
//}
//else
//{
//    float sal = (float)(salary * 0.03);
//    Console.WriteLine("Salary Increase : {0}", salary + sal);
//}

//--------------------------------------------------------------------------------

//int num = 0;

//while (num < 5)
//{
//    ++num;
//    Console.WriteLine(num);
//}

//Console.WriteLine("Exit Loop");



//do
//{
//    ++num;
//    Console.WriteLine(num);
//}
//while (num <= 5);

//for (int i = 0; i<=5; i++)
//{
//    Console.WriteLine(i);
//}

//string name = "Peat";

//foreach(char i in name)
//{
//    Console.WriteLine(i);
//}


string[] cars = new string[] { "ford", "benz", "bmw" };

Array.Resize(ref cars, 4);
cars[3] = "Lambo";

cars[0] = "MG";

Array.Reverse(cars);

foreach (string car in cars)
{
Console.WriteLine(car);
}
string[] car2 = new string[4];
Array.Copy(cars, car2, 3);

foreach (string car in car2)
{
Console.WriteLine(car);
}

Console.WriteLine(Array.IndexOf(car2, "ford"));

Array.Clear(car)






List<int> ListNumber = new List<int>();
ListNumber.Remove(0);
foreach (int n in ListNumber)
{
Console.WriteLine(n);
}

if (ListNumber.Contains("True")
{
    Console.WriteLine("true");



    HashSet<int> SetoffNumber = new HashSet<int>();
    SetoffNumber.Add(50);
    SetoffNumber.Add(100);

    foreach (int i in SetoffNumber)
    {
        Console.WriteLine(i);
    }


    Console.Write("Number of Students ? : ");
int numofstd = int.Parse(Console.ReadLine());

//for(int i = 0; i<numofstd; i++)
//{
//    Console.Write("Student Id : ");
//    string studentID = Console.ReadLine();

//    Console.Write("Score : ");
//    int studentScore = int.Parse(Console.ReadLine());

//    Console.Write("Student Id : " + studentID);
//    Console.WriteLine(" Score is " + studentScore);
//    Console.WriteLine("");


//}

Console.WriteLine("Exit (Y/N): ");
char check = char.Parse(Console.ReadLine());


//    if(check == 'Y')
//{
//    Console.WriteLine("Result : ");
//    Console.WriteLine("All Students : " + numofstd);
//}





do
{
    for (int i = 0; i < numofstd; i++)
    {
        Console.Write("Student Id : ");
        string studentID = Console.ReadLine();

        Console.Write("Score : ");
        int studentScore = int.Parse(Console.ReadLine());

        Console.Write("Student Id : " + studentID);
        Console.WriteLine(" Score is " + studentScore);
        Console.WriteLine("");


    }
}
while (check != "Y");


    int num = 0;
    while (num <= 5)
    {
        ++num;
        Console.WriteLine(num);
    }
    Console.WriteLine("exit loop");

    do
    {
        ++num;
        Console.WriteLine(num);
    }



    string[] cars = new string[] { "ford", "toyota", "lambogini" };
    Array.Resize(ref cars, 4);
    cars[3] = "BMW";

    foreach (string car in cars)
    {
        Console.WriteLine(car);
    }

    Console.WriteLine("--------------------------");
    Array.Reverse(cars);

    foreach (string car in cars)
    {
        Console.WriteLine(car);
    }

    string[] cars2 = new string[4];
    Array.Copy(cars, cars2, 3);

    foreach (string car in cars2)
    {
        Console.WriteLine(car);
    }

    Console.WriteLine(Array.IndexOf(cars, "ford"));

    HashSet<int> SetOfNumber = new HashSet<int>();
    SetOfNumber.Add(1);
    SetOfNumber.Add(100);
    SetOfNumber.Add(50);

    foreach (int i in SetOfNumber)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(SetOfNumber.Count);

    HashSet<int> SetOfNumber = new HashSet<int>();
    SetOfNumber.Add(1);
    SetOfNumber.Add(100);
    SetOfNumber.Add(50);

    foreach (int i in SetOfNumber)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine(SetOfNumber.Count);

    -------------Dictionary--------------//

using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;

    Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
    citiesPopulation.Add("Bangkok", 1000000);
    citiesPopulation.Add("Pattaya", 500000);
    Console.WriteLine(citiesPopulation["Bangkok"]);


    int num;
    if (citiesPopulation.TryGetValue("Bangkok1", out num))
    {
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("No Bangkok");
    }
    if (citiesPopulation.ContainsKey("Bangkok"))
    {
        Console.WriteLine("Bangkok");
    }
    else
    {
        Console.WriteLine("No Bangkok");
    }

    foreach (KeyValuePair<string, int> number in citiesPopulation)
    {
        Console.WriteLine(number.Key);
    }


    Console.Write("Number of Student : ");
    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++)
    {
        Console.Write("Enter student ID : ");
        string studentID = Console.ReadLine();
        Console.Write("Enter student score : ");
        int studentScore = int.Parse(Console.ReadLine());
        Console.Write("Student Id " + studentID);
        Console.Write(" ");
        Console.WriteLine("score is " + studentScore);
        Console.WriteLine(" ");

    }
    string exitChoice = "";
    while (exitChoice != "Y")
    {
        Console.Write("Exit? (Y/N): ");
        exitChoice = Console.ReadLine().ToUpper();
    }
    Console.WriteLine("Result :");
    Console.WriteLine("-------------------------");
    Console.WriteLine("All Student : " + num);

    public void PrintInfo()
    {
        Console.WriteLine("Name : {0}")
    }

 class Employee : person
class Program
{
    public static void Main()
    {
        person P2 = new person();
        P2.Name = "Book";
        P2.Age = 24;
        P2.PrintInfo();

        Employee E1 = new Employee();
        E1.Name = "Pond";
        E1.Age = 22;

    }
}


class Human
{
    public int age;
    public string name;
    public string lastname;

    public int Age { get { return age; } set { age = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public virtual int Run()
    {
        return age;
    }

}
internal class pond : Human
{
    public pond(int age, string name, string lastname)
    {
        Age = age;
        Name = name;
        Lastname = lastname;
    }
    public override int Run()
    {
        return age;
    }

}
public class Program
{
    public static void Main()
    {
        pond pond = new pond(22, "Thanaphol", "Kettabtim");
        string name = pond.Name;
        string lastname = pond.Lastname;
        int age = pond.Run();
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Lastname : {lastname}");
        Console.WriteLine($"Age  : {age}");
    }
}



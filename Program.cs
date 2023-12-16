

using OOP_methods;

class Program
{
    static Student GetStudent()
    {
        OOP_methods.Student student = new OOP_methods.Student();


        student.lastName = "Amir";
        student.firstName = "Olimov";
        student.middleName = "Muhamadaminovich";
        student.age = 36;
        student.Id = Guid.NewGuid();
        student.group = Group.IT;

        return student;
    }

    OOP_methods.Car car = new OOP_methods.Car();
    static void Main(string[] args)
    {
        var student = GetStudent();

        student.Print();

        student.GetFullName();

        Console.WriteLine("\t== Car1 ==");
        var car = new OOP_methods.Car();
        car.PrintSreed();
        car.DriveFoward();
        car.PrintSreed();
        car.DriveBackward();
        car.PrintSreed();
        car.Stop();
        car.PrintSreed();

    }
}
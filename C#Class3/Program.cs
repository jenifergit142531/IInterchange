
/*struct Employee
{
    public int eid;
    public string name; 
    public Employee(int x,string y)
    {
        eid = x;
        name = y;
    }
    public void Show()
    {
        Console.WriteLine("EmployeeId :" + eid);
        Console.WriteLine("Employee Name :" + name);
    }
    public static void Main()
    {
        Employee emp1 = new Employee(101, "Amy");
        emp1.Show();
    }

}
*/
using C_Class3;
using System.Net;

class Program
{
    
    public static void Main()
    {

        //Persona p = new Persona();

        HR h1 = new HR();
        h1.salary();
        h1.roles();
        h1.portfolioDetails();

        Sales s1 = new Sales();
        s1.portfolioDetails();
        s1.salary();
        s1.roles();
        //Tollywood t1 = new Tollywood();
        //t1.movieList();
        //t1.showTimings();

        //Hollywood h1 = new Hollywood();
        //h1.movieList();
        //h1.showTimings();

        //Movie m1 = new Movie();
        //m1.showTimings();
        //m1.movieList();

        //Movie m1 = new Movie();

        //Vehicle v1 = new Vehicle();

        //Ford f1 = new Ford();
        //f1.getFordBooking();
        //f1.showFordBooking();

        //Bike b1 = new Bike();
        //b1.showBike();
        //b1.showVehicle();

        //Car c1 = new Car();
        //c1.getBooking();
        //c1.showBooking();
        //c1.showVehicle();

    
        //Ford f1 = new Ford();
        //f1.showVehicle();
        ////f1.getBooking();
        ////f1.showBooking();
        //f1.fordUpdates();

        //Lexus l1 = new Lexus();
        //l1.lexusUpdate();
        //l1.getBooking();
        //l1.showLexusDetails();


        //Car booking1 = new Car();
        //booking1.getBooking();
        //booking1.showBooking();
        //booking1.showVehicle();
        

       // Encap book1 = new Encap();

        // book1.getBook();
        // book1.showBook();

        //Employee emp1 = new Employee(101, "Amy");
        //emp1.Show();

        //Pizza order1 = new Pizza();
        //order1.getOrder();
        //order1.showOrder();

        //Pizza order2 = new Pizza();
        //order2.getOrder();
        //order2.showOrder();

        //Pizza order3 = new Pizza();
        //order3.getOrder();
        //order3.showOrder();
    }
}

       


using System; //imports all libraries
namespace p1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            DateTime dat = DateTime.Now;

              Console.WriteLine("//////////////////////////////////////////////////////////////////////////");
              Console.WriteLine("Program Requirements:");
              Console.WriteLine("P1 - Room Size Calculator using Classes");
              Console.WriteLine("Author: Ariana M. Davis");
              Console.WriteLine("  1) Create Room class");
              Console.WriteLine("  2) Create following fields (aka properties or data members)");
              Console.WriteLine("    a. private string type //room type");
              Console.WriteLine("    b. private double length // room length");
              Console.WriteLine("    c. private double width // room width");
              Console.WriteLine("    d. private double height //room height");
              Console.WriteLine("  3) Create two constructors");
              Console.WriteLine("    a. Default constructor");
              Console.WriteLine("    b. parameterized constructor that accepts four arguments (four fields above)");
              Console.WriteLine("  4) Create the following mutator (aka setter) methods:");
              Console.WriteLine("    a. SetType");
              Console.WriteLine("    b. SetLength");
              Console.WriteLine("    c. SetWidth");
              Console.WriteLine("    d. SetHeight");
              Console.WriteLine("  5) Create the followign accessor (aka getter) methods:");
              Console.WriteLine("    a. GetType");
              Console.WriteLine("    b. GetLength");
              Console.WriteLine("    c. GetWidth");
              Console.WriteLine("    d. GetHeight");
              Console.WriteLine("    e. GetArea");
              Console.WriteLine("    f. GetVolume");
              Console.WriteLine("  6) Must include the following functionalilty:");
              Console.WriteLine("    a. Display room size calculations in feet (as per below)");
              Console.WriteLine("    b. Must include data validation");
              Console.WriteLine("    c. Round to two decimal places");
              Console.WriteLine("  7) Allow user to press any key to return back to command line.");
              Console.WriteLine("//////////////////////////////////////////////////////////////////////////");

              Console.WriteLine();

              Console.WriteLine("*  Now: {0:d}, {0:T}   *", dat);       //display current date and time

              Console.WriteLine();

              //default constructor w/no parameters
              Room room1 = new Room();

              Console.Write("Room Type: "); 
              Console.WriteLine(room1.GetType());

              Console.WriteLine();

              Console.Write("Room Length: "); 
              Console.WriteLine(room1.GetLength());

              Console.Write("Room Width: "); 
              Console.WriteLine(room1.GetWidth());

              Console.Write("Room Height: "); 
              Console.WriteLine(room1.GetHeight());

              Console.Write("Room Area: "); 
              Console.WriteLine(room1.GetArea().ToString("F2") + " sq ft");

              Console.Write("Room Volume: "); 
              Console.WriteLine(room1.GetVolume().ToString("F2") + " cu ft");

              Console.Write("Room Volume: "); 
              Console.WriteLine((room1.GetVolume()/27).ToString("F2") + " cu yd");

              Console.WriteLine();

              Console.Write("\nModify " + room1.GetType() + " room object's data member values");
              Console.WriteLine("Use setter/getter methods:");

              //initalize variables
              string rtype = "";
              double rlength = 0.0;  
              double rwidth = 0.0; 
              double rheight = 0.0;

              Console.Write("Room type: "); 
              rtype = Console.ReadLine();

              Console.Write("Room length: "); 
              while (!double.TryParse(Console.ReadLine(),out rlength))
              {
                Console.WriteLine("Room length must be numeric");
              }

              Console.Write("Room width: "); 
              while (!double.TryParse(Console.ReadLine(),out rwidth))
              {
                Console.WriteLine("Room width must be numeric");
              }

              Console.Write("Room height: "); 
              while (!double.TryParse(Console.ReadLine(),out rheight))
              {
                Console.WriteLine("Room height must be numeric");
              }

              Console.WriteLine("\nDisplay " + room1.GetType() + " room object's new data member values:");

              //use setter/mutator methods
              room1.SetType(rtype); 
              room1.SetLength(rlength); 
              room1.SetWidth(rwidth); 
              room1.SetHeight(rheight); 

              Console.Write("Room Type: "); 
              Console.Write(room1.GetType());

              Console.WriteLine();

              Console.Write("Room Length: "); 
              Console.Write(room1.GetLength());

              Console.WriteLine();

              Console.Write("Room Width: "); 
              Console.Write(room1.GetWidth());

              Console.WriteLine();

              Console.Write("Room Height: "); 
              Console.Write(room1.GetHeight());

              Console.WriteLine();

              Console.Write("Room Area: "); 
              Console.Write(room1.GetArea().ToString("F2") + " sq ft");

              Console.WriteLine();

              Console.Write("Room Volume: "); 
              Console.Write(room1.GetVolume().ToString("F2") + " cu ft");

              Console.WriteLine();

              Console.Write("Room Volume: "); 
              Console.Write((room1.GetVolume()/27).ToString("F2") + " cu yd");

              Console.WriteLine("\n");

              Console.WriteLine("Call parameterized constructor (accetps four arguments)");

              Console.Write("Room type: "); 
              rtype = Console.ReadLine();

              Console.Write("Room length: "); 
              while (!double.TryParse(Console.ReadLine(),out rlength))
              {
                Console.WriteLine("Room length must be numeric");
              }

              Console.Write("Room width: "); 
              while (!double.TryParse(Console.ReadLine(),out rwidth))
              {
                Console.WriteLine("Room width must be numeric");
              }

              Console.Write("Room height: "); 
              while (!double.TryParse(Console.ReadLine(),out rheight))
              {
                Console.WriteLine("Room height must be numeric");
              }

              Console.WriteLine();

              Room room2 = new Room(rtype, rlength, rwidth, rheight);

              Console.Write("Room Type: "); 
              Console.Write(room2.GetType());

              Console.WriteLine();

              Console.Write("Room Length: "); 
              Console.Write(room2.GetLength());

              Console.WriteLine();

              Console.Write("Room Width: "); 
              Console.Write(room2.GetWidth());

              Console.WriteLine();

              Console.Write("Room Height: "); 
              Console.Write(room2.GetHeight());

              Console.WriteLine();

              Console.Write("Room Area: "); 
              Console.Write(room2.GetArea().ToString("F2") + " sq ft");

              Console.WriteLine();

              Console.Write("Room Volume: "); 
              Console.Write(room2.GetVolume().ToString("F2") + " cu ft");

              Console.WriteLine();

              Console.Write("Room Volume: "); 
              Console.Write((room2.GetVolume()/27).ToString("F2") + " cu yd");

              Console.WriteLine();

              Console.WriteLine("\nPress any key to exit!");
              Console.ReadKey();

         }

    }
}

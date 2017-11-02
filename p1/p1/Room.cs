using System; //imports all libraries
namespace p1
{
    public class Room
    {
        //field/property/data member
        private string type; 
        private double length; 
        private double width; 
        private double height; 

        //default constructor (accepts no arguments)
        public Room()
        {
            type = "Default"; 
            length = 10.0; 
            width = 10.0; 
            height = 10.0; 
            Console.WriteLine("Creating" + " " + this.type + " " + "room object from default constructor (accepts no arguments):");

        }

        //parameterized constrcutor that accepts four arguments 
        public Room(string t="", double l=0.0, double w=0.0, double h=0.0)
        {
            type = t; 
            length = l; 
            width = w; 
            height = h; 
            Console.WriteLine("Creating" + " " + this.type + " " + "room object from parameterized constructor (accepts four arguments):");
        }

        //******mutator methods******
        //setter method
        public void SetType(string t="default")
        {
            type = t; 
        }

        public void SetLength(double l=0.0)
        {
            length = l; 
        }

        public void SetWidth(double w=0.0)
        {
            width = w;
        }

        public void SetHeight(double h=0.0)
        {
            height = h;
        }


        //******accessor methods******
        //getter method
        public string GetType()
        {
            return type; 
        }

        public double GetLength()
        {
            return length; 
        }

        public double GetWidth()
        {
            return width; 
        }

        public double GetHeight()
        {
            return height; 
        }

        public double GetArea()
        {
            return length * width; 
        }

        public double GetVolume()
        {
            return length * width * height; 
        }

    }
}

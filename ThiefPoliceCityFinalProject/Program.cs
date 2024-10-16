namespace ThiefPoliceCityFinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intializing and declaring the grid
            int gridWidth = 100; //col
            int gridHeight = 25; //rows

            //Creating an object of class Grid
            Grid grid =  new Grid(gridWidth, gridHeight);

            //Creating an object of class Persons
            List<Persons> allPersons = new List<Persons>();

            //Creating an instance of Random to generate random numbers
            Random rnd = new Random();
            
        }
    }
}

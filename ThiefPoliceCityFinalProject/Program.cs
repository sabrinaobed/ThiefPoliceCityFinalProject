using ThiefPoliceCityFinalProject;

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
            string lastInteractionMessage = string.Empty;// to show last interaction


            //Creating persons ( police, theieves and citizens) on grid
            //Police
            for(int i = 0; i < 10; i++)
            {
                allPersons.Add(new Police(rnd.Next(1, gridWidth -1), rnd.Next(1, gridHeight -1)));//random int between 1 and gridWidth- 1(X coordinate), random int betweeb 1 and gridheight- 1(Y coordinate), rnd is an instance whcih we created of class Random
            }
            //Thieves
            for (int i = 0; i < 20; i++)
            {
                allPersons.Add(new Thief(rnd.Next(1, gridWidth - 1), rnd.Next(1, gridHeight - 1)));
            }
            //Citizen
            for (int i = 0; i < 30; i++)
            {
                allPersons.Add(new Citizen(rnd.Next(1, gridWidth - 1), rnd.Next(1, gridHeight - 1)));
            }

            Console.CursorVisible = false; //Hide the cursor for cleaner display

        while (true)
         {
                //Call update all persons on grid method
                grid.UpdateGridWithAllPersons(allPersons);

                //Clear the console after each update
                Console.Clear();

                //Call diaply grid method to display the grid
                grid.DisplayGrid();

                //Welcome note
                Console.WriteLine("Welcome to Police and Thief Game!");
                Console.WriteLine("---Lets Begin the Game---");
                Console.WriteLine("Recent interactions between people in the city: ");
               

            //Display the last Interaction message
            if (!string.IsNullOrEmpty(lastInteractionMessage))
                {
                    Console.WriteLine(lastInteractionMessage);
                }
                else
                {
                    Console.WriteLine("No major recent interactions.");
                }

                //Call move method from persons class for random movements of all persons on grid
                foreach(Persons person in allPersons)
                {
                    person.PersonsMovement(gridWidth, gridHeight,allPersons,ref lastInteractionMessage);
                }

                //Sleep for 1000 milliseconds to slow down the refrsh rate
                Thread.Sleep(1500);

        }

    }
}


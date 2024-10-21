using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefPoliceCityFinalProject
{
    internal class Grid
    {
        //Fields
        //Decalring fields with private access modifier so they are not accessed outside the grid class 
        private int width;    //col
        private int height;   //rows
        private char[,] grid; //2D char array representing actual grid

        //Parameterized Constructor Method
        public Grid(int width, int height)
        {
            this.width = width; //this.width refers to the  private field of the class and width refers to parameter width value passed to constructor
            this.height = height;
            grid = new char[height, width]; //creating a new object & represents different elements of grid like empty spaces boundaries etc
            CreateGrid(); //calling this method here in constructor to set the intial state of grid with empty spaces as the Grid object is created.

        }

        //Method
        //Creating a method for creating and initializing the grid with empty spaces using nested for loop
       public void CreateGrid()
            
        {

            for(int row = 0; row < height; row++)//grid with empty spaces
            {
                for(int col = 0; col < width; col++)
                {
                    grid[row, col] = ' ';
                }
            }

            //Creating boundaries of the grid using for loop
            for(int col = 0; col < width; col++) 
            {
                grid[0, col] = '*'; //upper boundary
                grid[height - 1, col]= '*'; //lower boundary ,height - 1 refers to last row (index 24)
            }   

            for(int row = 0; row < height; row++)
            {
                grid[row, 0] = '*'; //left boundary
                grid[row, width - 1] = '*'; //right boundary,width - 1 refers to last col (index 99)

            }

        } 

        //Method
        //Update Grid with allPersons List and empty spaces
        public void UpdateGridWithAllPersons(List<Persons> allPersons)
        {
            //First reset to the grid to avoid overlapping and be ensure that the previous characters are cleared and also reset grid to empty spaces
            for(int row = 1; row < height - 1; row++)
            {
                for (int col = 1; col < width - 1; col++)
                {
                    grid[row, col] = ' ';
                }
            }

            //updating grid with persons
            foreach (Persons person in allPersons)
            {
                if(person.XCoordinate >= 1 && person.XCoordinate < width - 1 && person.YCoordinate >= 1 && person.YCoordinate < height - 1)
                {
                    grid[person.YCoordinate, person.XCoordinate] = person.PersonRepresentation;
                }
            }
        }


        //Method
        //Creating a method to DisplayGrid with all persons and their character represnattion  whith specific colors
        public void DisplayGrid()
        {
            Console.Clear();
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    //Decalring a variable to hold character value and intialized with the value at the current position on grid
                    char character = grid[row, col];
                    if (character == 'P')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (character == 'T')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (character == 'C')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White; 
                    }
                    Console.Write(character);
                }
                Console.WriteLine();
            }
            Console.ResetColor(); //Reset color after drawing the grid



        }    

        

    }
}

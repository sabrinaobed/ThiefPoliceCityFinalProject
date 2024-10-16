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
            grid = new char[width, height]; //creating a new object & represents different elements of grid like empty spaces boundaries etc
            CreateGrid(); //calling this method here in constructor to set the intial state of gris with empty spaces as the Grid object is created.
        }

        //Method
        //Creating a method for creating and initializing the grid with empty spaces using nested for loop
       public void CreateGrid()
        {
            for(int row = 0; row < height; row++)
            {
                for(int col = 0; col < width; col++)
                {
                    grid[row, col] = ' ';
                }
            }
        }
            

        

    }
}

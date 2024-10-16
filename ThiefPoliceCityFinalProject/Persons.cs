﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefPoliceCityFinalProject
{
    internal class Persons
    {

        //Properties
        public int XCoordinate{ get; set; } //col
        public int YCoordinate { get; set; } //row
        public virtual char PersonRepresentation { get; } //characters for all persons,its virtual so the subclasses can override it.

        //Field and object of class Random
        protected static Random random = new Random(); // field of type Random and also an object created by new random(),its protected so its only accessed by base class and its subclasses.

        //Parameterized Constructor Method
        public Persons(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        //Creating a method for Character Representation
        public virtual char CharacterRepresentation()
        {
            return PersonRepresentation; //return the PersonsRepresntation property in the method
        }

        //Creating a method for Persons Movement in grid
        public virtual void PersonsMovement(int width, int height,List<Persons>allPersons)
        {
            //creating a varaible to define the random 6 directions in which the persons will move
            int direction = random.Next(0,6);
            //declaring variables for types of directions
            int xDirection = 0; 
            int yDirection = 0;

            switch(direction)
            {
                case 0:
                    yDirection = -1; //up
                    break;
                case 1:
                    yDirection = 1; //down
                    break ;
                case 2:
                    xDirection = -1;//left
                    break;
                case 3:
                    xDirection = 1; //right
                    break;
                case 4:
                    yDirection = -1;
                    xDirection += 1;//upper right
                    break;
                case 5:
                    yDirection += 1;
                    xDirection = -1; //lower left
                    break;

            }

            //Updating the positions/current locations/coordinates of persons while keeping them within boundaries of grid
            XCoordinate = Math.Clamp(XCoordinate + xDirection, 1, width - 2);
            YCoordinate = Math.Clamp(YCoordinate +  yDirection, 1, height - 2);


        }
    } 



    //Subclasses
    public class Police : Persons //Police
    {
        //Constructor
        public Police ( int xCoordinate,int yCoordinate) : base(xCoordinate, yCoordinate)
        {

        }

        //Overrid PersonRepresentation()
        public override char CharacterRepresentation()
        
        {
            return 'P';
        }
    }

    public class Thief : Persons //Thief
    {
        //constructor
        public Thief (int xCoordinate, int yCoordinate) : base (xCoordinate, yCoordinate)
        {

        }


        //Overrid PersonRepresentation()
        public override char CharacterRepresentation()

        {
            return 'T';
        }
    }

    public class Citizen : Persons //Citizen
    {
        //constructor
        public Citizen (int xCoordinate, int yCoordinate) : base(xCoordinate,yCoordinate)
        {

        }


        //Overrid PersonRepresentation()
        public override char CharacterRepresentation()

        {
            return 'C';
        }
    }

}

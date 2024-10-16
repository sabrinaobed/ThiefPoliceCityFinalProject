using System;
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

        protected static Random random = new Random(); // field of type Random and also an object created by new random(),its protected so its only accessed by base class and its subclasses.


    } 
}

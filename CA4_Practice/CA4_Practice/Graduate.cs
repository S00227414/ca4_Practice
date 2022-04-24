using System;
using System.Collections.Generic;
using System.Text;

namespace CA4_Practice
{
    class Graduate
    {
        //attributes
        private string _name;
        private string _projectType;
        private int _averageGrade;
        private int _graduateNumber;

        // static variable that belongs to Class
        public  static int lastGraduateNumber;

        //Name property to get and set the name attribute of the object
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //Average Grade property used to get and set the attribute of the object
        public int AverageGrade
        {
            get
            {
                return _averageGrade;
            }
            set
            {
                _averageGrade = value;
            }
        }

        // Final Project Type property to get and set attribute of object
        public string ProjectType
        {
            get
            {
                return _projectType;
            }
            set
            {
                _projectType = value;
            }
        }

        //Graduate Number property used to get and set the graduate number attribute of the object
        public int GraduateNumber
        {
            get
            {
                return this._graduateNumber;
            }
            set
            {
                this._graduateNumber = value;
            }
        }

        //Default constructor
        public Graduate()
        {
            lastGraduateNumber++;  //increment the static variable by 1
            GraduateNumber = lastGraduateNumber;  //assign to the graduate number attribute
        }

        //Paramaterised constructor
        public Graduate(string n,int g, string p)
        {
            Name = n;
            AverageGrade = g;
            ProjectType = p;
            lastGraduateNumber++;  // increment the static variable by 1
            GraduateNumber = lastGraduateNumber;  // assign to the graduate number
        }

        //Method to designate the degree class depending on the average grade
        public virtual string GetDegreeClassification(int g)
        {
            string degreeClass = "";

            if (g >= 70)
            {
                degreeClass = "Distinction";
            }
            else if ( g < 70 && g >= 60)
            {
                degreeClass = "Merit";
            }
            else if (g < 60 && g >= 40)
            {
                degreeClass = "Pass";
            }
            else
            {
                degreeClass = "Fail";
            }

            return degreeClass;
        }

        //Method to print the attributes of the object
        public override string ToString()
        {
            

            return GraduateNumber +","+ Name + "," + AverageGrade + "," + GetDegreeClassification(AverageGrade) + "," + ProjectType;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    public class TriangleSolver
    {

        private int Side1;
        private int Side2;
        private int Side3;
        int Equi;
        int Isos;
        int Scal;
        int yes;

        // Constructor1; default values are 1
        public TriangleSolver()
        {
            this.Side1 = 1;
            this.Side2 = 1;
            this.Side3 = 1;
        }

        // Constructor2 to set Side1, Side2, Side3 for values inputted by the user
        public TriangleSolver(int Side1, int Side2, int Side3)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
        }

        //to analyze category of traingle
        public int TriangleCategory
        {
            get
            {
                if (Side1 == Side2 && Side2 == Side3)
                {
                    Console.Write("\n");
                    Console.Write("Values entered by user forms a triangle. \n",yes);
                    Console.Write("This is an Equilateral Triangle.\n", Equi);
                    return Equi;
                    
                }
                else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
                {
                    Console.Write("\n");
                    Console.Write("Values entered by user forms a triangle. \n");
                    Console.Write("This is an Isosceles Triangle.\n",Isos);
                    return Isos;
                }
                else
                {
                    Console.Write("\n");
                    Console.Write("Values entered by user forms a triangle. \n");
                    Console.Write("This is a Scalene Triangle.\n",Scal);
                    return Scal;

                }
            }
        }

        //contains a static method called Analyze which accepts three integers as an input, returns a string as an output.
        //public static int Analyze()
        //{
        //    return ();
        //}


        public void SetSide1(int Side1)
        {
            this.Side1 = Side1;
            return;
        }

        public void SetSide2(int Side2)
        {
            this.Side2 = Side2;
            return;
        }
        
        public void SetSide3(int Side3)
        {
            this.Side3 = Side3;
            return;
        }

        //public int GetSide1()
        //{
        //    return this.Side1;
        //}

        //public int GetSide2()
        //{
        //    return this.Side2;
        //}

        //public int GetSide3()
        //{
        //    return this.Side3;
        //}

    }
}

using GeometricShapeMath.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeometricShapeMath.Model
{
    public abstract class GeometricShape
    {
        private string _name;
        private double _square;
        
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Square
        {
            get { return _square; }
            set { _square = value; }
        }
    }

    public class Circle : GeometricShape, IGeometricShape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public void Print()
        {
            Console.WriteLine($"Name of shape: {Name}, Radius: {Radius}, Square:{Square}");
        }

        public double SquareOfShape()
        {
           return Square=Math.PI*Math.Pow(_radius, 2 );
        }
    }

    public class Triangle : GeometricShape, IGeometricShape
    {
        private double _firsttriangleSide;
        private double _secondtriangleSide;
        private double _thirdtriangleSide;
        private bool _rightTriangle;
        public double FirstTriangleSide
        {
            get { return _firsttriangleSide; }
            set { _firsttriangleSide = value; }
        }
        public double SecondTriangleSide
        {
            get { return _secondtriangleSide; }
            set { _secondtriangleSide = value; }

        }
        public double ThirdTriangleSide
        {
            get { return _thirdtriangleSide; }
            set { _thirdtriangleSide = value; }

        }
        public bool RightTriangle
        {
            get { return _rightTriangle; }
            set { _rightTriangle=value; }
        }
        public void Print()
        {
            Console.WriteLine($"Name of shape: {Name}," +
                $" First side: {FirstTriangleSide}, Second side: {SecondTriangleSide}, Third side: {ThirdTriangleSide}" +
                $" Square:{Square}");
        }
        public string CheckOfTriangleToRight()
        {
            if(this.FirstTriangleSide*this.FirstTriangleSide + this.SecondTriangleSide*this.SecondTriangleSide == this.ThirdTriangleSide*this.ThirdTriangleSide)
            {
                this.RightTriangle = true;
                return "This triangle right";
            }
            else
            {
                this.RightTriangle = false;
                return "This triangle not right";
            }
        }
        public double SquareOfShape()
        {
            CheckOfTriangleToRight();
            if (this.RightTriangle)
            {
                return Square=0.5*FirstTriangleSide*SecondTriangleSide;
            }
            else
            {
                double p = (FirstTriangleSide+SecondTriangleSide+ThirdTriangleSide)/2;
                return Square=Math.Sqrt(p*(p-FirstTriangleSide)*(p-SecondTriangleSide)*(p-ThirdTriangleSide));
            }
        }
    }
}

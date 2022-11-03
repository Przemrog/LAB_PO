using System.Runtime.CompilerServices;

namespace WebApplication3.Services.LAB3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetArea(int x)
        {
            return Width * Height * x;
        }

        public int GetArea(double x)
        {
            return Width * Height;
        }

        public virtual int GetShorterSide()
        {
            return new List<int>() { Width, Height}.Min();
        }
    }
}

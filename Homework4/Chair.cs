using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    public class Chair
    {
        private string material;
        private string color;
        private int numberOfLegs;
        private int posX;
        private int posY;
    
        public Chair(string material, string color, int numberOfLegs, int posX, int posY) 
        {
            this.material = material;
            this.color = color;
            this.numberOfLegs = numberOfLegs;
            this.posX = posX;
            this.posY = posY;
        }
    
        public void DisplayInfo () 
        {
            Console.WriteLine($"Chair Material: {material}");
            Console.WriteLine($"Chair Color: {color}");
            Console.WriteLine($"Number of Legs {numberOfLegs}");
        }
        public void MoveChair(int translateX, int translateY) 
        {
            posX += translateX;
            posY += translateY;
        }
    
    }
}

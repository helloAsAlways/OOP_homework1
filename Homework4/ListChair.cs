using System;
using System.Collections.Generic;

namespace my_project
{
    public class Chairs
    {
        private List<Chair> chairList;

        public Chairs()
        {
            chairList = new List<Chair>();
        }

        public void AddChair(Chair chair)
        {
            chairList.Add(chair);
        }

        public void DisplayAllChairs()
        {
            foreach (var chair in chairList)
            {
                chair.DisplayInfo();
                Console.WriteLine(); 
            }
        }

        public static void Main(string[] args)
        {
            Chairs chairsCollection = new Chairs();
            
            Chair chair1 = new Chair("Wood", "Brown", 4, 0, 0);
            Chair chair2 = new Chair("Metal", "Black", 4, 5, 2);
            
            chairsCollection.AddChair(chair1);
            chairsCollection.AddChair(chair2);
            
            chairsCollection.DisplayAllChairs();
        }
    }
}

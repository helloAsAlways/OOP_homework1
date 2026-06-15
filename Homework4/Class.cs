namespace my_project
{
    class Class
    {
        private int area;
        private int capacity;

        public Class(int area, int capacity)
        {
            this.area = area;
            this.capacity = capacity;
        }
        public DisplayInfo() 
        {
            Console.WriteLine(area);
            Console.WriteLine(capacity);
        }
        public static void main(string[] args)
        {
            Class class = new Class(50, 30);
            class.DisplayInfo();
        }
    }
}

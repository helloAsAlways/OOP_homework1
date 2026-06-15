namespace my_project
{
    class Lecturer
    {
        private string fullName;
        private string agenda;

        private int age;
        
        public Lecturer(string fullName, string agenda, int age)
        {
            this.fullName = fullName;
            this.agenda = agenda;
            this.age = age;
        }

        public void InspirationalSpeech()
        {
            Console.WriteLine("Sky is beautiful");
        }

        public void beginLecture()
        {
            Console.WriteLine("Sky is beautiful");
        }
        public static void main(string[] args)
        {
            Lecturer("Jackson Sami", "Computer Engineering", 27);
            InspirationalSpeech();
            beginLecture();
        }
    }
}

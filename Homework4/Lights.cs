class Lights
    {
        private List<Light> lights = new List<Light>();
        private belongTo belongs;
        public Lights(belongTo  belongs)
        {
           this.belongs = belongs;
        }

        public void addLight()
        {
            Light newLight = new Light(50, Spiral);
            lights.add(newLight);
        }
        public static void Main(String[] args)
        {
            Lights lightlist = new Lights(room1);
            addLight();
            Console.WriteLine(lightlist);
        }
    }
}

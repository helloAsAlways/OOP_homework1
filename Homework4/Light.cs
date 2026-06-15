enum LightType
{
    Traditional,
    Golf, 
    Spiral,
    Candle,
    DownLight,
    Stick
}

namespace my_project
{
    class Light
    {
        private bool state = false;
        private int wattage;
        public LightType lightType;

        public Light(int wattage, LightType lightType)
        {
            this.wattage = wattage;
            this.lightType = lightType;
        }

        public void turnOn()
        {   
            state = true;
        }
        public void turnOff()
        {
            state = false;
        }

        public void toggle()
        {
            state = !state;
        }
    }
}

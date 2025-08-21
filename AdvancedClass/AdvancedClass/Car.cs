namespace AdvancedClass{

    class Car
    {
        public Car()
        {
        int gas = 12;
        int tickets = 0;
        }

        public int getGas(Car car)
        {
            int currentGas = car.gas;
            return currentGas;
        }

        public void Drive()
        {
            Console.WriteLine("Zoom!");
        }
    }
}
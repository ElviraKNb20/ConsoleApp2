using System;

namespace ConsoleApp2
{
    interface ILamp
    {
        string Type { get; }
        string Maker();
        int Power { set; }
        void GetInfo();
        void ChangePower();
    }
    interface ICamera
    {
        string Type { get; }
        string Maker();
        void LightSensitivity();
    }
    class Bush
    {
        public int CrownHeight { get; }

        public void GetInfo(ILamp l)
        {
            l.GetInfo();
        }

        public void ChangePower(ILamp l)
        {
            l.ChangePower();
        }
        public void ChangeLightSensitivity(ICamera l)
        {
            l.LightSensitivity();
        }

        internal void PlantName(ITree str)
        {
            throw new NotImplementedException();
        }

        internal void GetHeight(ITree str)
        {
            throw new NotImplementedException();
        }

        internal void GetInfo(ITree str)
        {
            throw new NotImplementedException();
        }
    }

    internal interface ITree
    {
    }

    class PhotoStudio : ILamp, ICamera
    {
        public int CrownHeight => 9;

        public string Type => throw new NotImplementedException();

        public int Power { set => throw new NotImplementedException(); }

        public void ChangePower()
        {
            throw new NotImplementedException();
        }

        public void GetHeight()
        {
            Console.WriteLine($"Висота: {CrownHeight}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{GetType().Name}: Дерево");
        }

        public void LightSensitivity()
        {
            throw new NotImplementedException();
        }

        public string Maker()
        {
            throw new NotImplementedException();
        }

        public void PlantName()
        {
            Console.WriteLine("Назва: Верба");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bush = new Bush();
            ITree[] arr = { new Bushh(), new Tree(), new Grass() };
            foreach (var str in arr)
            {
                bush.GetInfo(str);
                Console.WriteLine();
                bush.PlantName(str);
                Console.WriteLine();
                bush.GetHeight(str);
                Console.WriteLine();
            }
        }
    }
}

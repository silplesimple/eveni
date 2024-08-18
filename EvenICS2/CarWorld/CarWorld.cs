using System;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;

namespace CarWorld
{
    interface IStandard { void Run(); }

    class Car : IStandard
    {
        #region
        private string name;
        private string[] names;
        private readonly int _Length;
        #endregion

        #region
        public Car()
        {
            this.name = "좋은차";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.name = "좋은차";
            _Length = length;
            names = new string[length];
        }
        #endregion

        #region
        public void Run() => Console.WriteLine("{0} 자동차가 달립니다.", name);
        #endregion
        #region
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region
        ~Car()
        {
            Console.WriteLine("{0} 자동차가 폐차됨", name);
        }
        #endregion
        #region
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region
        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<_Length;i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region
        public delegate void EventHandler();
        #endregion
        #region
        public event EventHandler Click;
        #endregion

        #region
        public void OnClick()
        {
            if(Click!=null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarWorld
    {
        static void Main()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.Run();

            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            for(int i=0;i<cars.Length;i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach(string name in cars)
            {
                Console.WriteLine(name);
            }

            Car btn = new Car("전기자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }

}
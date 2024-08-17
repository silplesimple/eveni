using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNote
{
    public class Car
    {
        public static string Color;

        private static string _Type;

        public static string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;//여기에 이 값을 세팅해라
            }
        }

        static Car()
        {
            Color = "Red";
            _Type = "스포츠카";
        }
    }

}

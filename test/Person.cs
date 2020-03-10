using System;
using System.Collections.Generic;
using System.Text;

namespace test
{

    class Person
    {
        private int _age;

        private string _name;

        private string _gender;

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        public string Name { get => _name; set => _name = value; }
        public string Gender { 
            get
            {
                if (_gender != "男" && _gender != "女")
                {
                    return _gender = "男";
                }
                return _gender;
            }

            set => _gender = value; }
    }
}

﻿namespace encapsulation_prectice {
    public class Person {
        private string name;
        protected int age;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
    }
}


using System;

namespace CommunityCollege
{
    class Professor
    {
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;

        public string LNumber
        {
            get { return lNumber; }
            set
            {
                if (value.StartsWith("L") && value.Length == 9)
                {
                    lNumber = value;
                }
                else
                {
                    throw new ArgumentException("LNumber should start with L and be 9 characters long");
                }
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public Professor()
        {

        }

        public Professor(string lNumber, string firstName, string lastName, string department)
        {
            LNumber = lNumber;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }

        public override string ToString()
        {
            return $"{LNumber} {FirstName} {LastName} ({Department})";
        }
    }
}


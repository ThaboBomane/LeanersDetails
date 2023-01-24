using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnersDetails
{
     class Learners
    {
        public string firstname;
        public string lastname;
        public string gender;
        public int age;
        public char initials;
        public Learners (String Firstname, string Lastname, string Gender, int Age, char Initials)
        {
            firstname = Firstname;
            lastname = Lastname;
            gender = Gender;
            age = Age;
            initials = Initials;

        }
    }
    
   
}

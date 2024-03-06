namespace HW1_FirstClass
{
    public class User
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public Gender Gender { get; set; }

        public User() 
        {
            Age = 0;
        }

        public User(string firstName, string lastName, int age, Gender gender) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name is {LastName}. I am {Age} years old. I am {Gender}.";
        }
    }
}

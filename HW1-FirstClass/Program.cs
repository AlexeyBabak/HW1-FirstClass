using HW1_FirstClass;

User user1 = new("Alexey", "Babak", 29, Gender.Male)
{
    FirstName = StringExtensions.GetValidatedAndCapitalizedInput("Enter First name:"),
    LastName = StringExtensions.GetValidatedAndCapitalizedInput("Enter Last name:"),
    Gender = Gender.Male
};

Console.WriteLine(user1);

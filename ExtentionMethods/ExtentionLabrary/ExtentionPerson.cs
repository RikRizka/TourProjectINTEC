namespace ExtentionLabrary
{
    public static class ExtentionPerson
    {
        public static string GetPersonFullName(this Person person)
        {
            return person.FirstName + " " + person.LastName;
        }
    }
}

namespace CodeFirstDemo.Data
{
    public class DataValidation
    {
        public static class Student
        {
            public const int NameMaxLength = 30;
        }
        public static class Course
        {
            public const int NameMaxLength = 100;
            public const int DescriptionMaxLength = 500;
        }
    }
}
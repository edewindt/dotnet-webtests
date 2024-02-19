public class Person
{
    public Person(Guid id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}
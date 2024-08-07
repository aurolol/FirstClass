using FirstClass;

Person student1 = new Person()
{
    FirstName = "Atakan",
    LastName = "Çelik",
    BirthDate = new DateTime(1998, 11, 04)

};
Person student2 = new Person()
{
    FirstName = "Ahmet",
    LastName = "Kılıç",
    BirthDate = new DateTime(1998, 08, 02)

};
Person teacher = new Person()
{
    FirstName = "Mustafa",
    LastName = "Yılmaz",
    BirthDate = new DateTime(1982, 01, 05)

};
Console.WriteLine("--------Öğrencilerimiz--------");
student1.Student();
student2.Student();
Console.WriteLine("--------Öğretmenimiz--------");
teacher.Teacher();
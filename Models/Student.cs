namespace Avaliacao3BimLp3.Models
{
    
}
class Student
{
    public string Registration {get;set}
    public string Name {get;set}
    public string City {get;set}
    public bool Formed {get;set}

    public Student(){}
    public Student (string registration; string name; string city; bool formed)
    {
        Registration= registration;
        Name= name;
        City=city;
        Formed=Formed;

    }


}

class CountStudentGroupByAttribute
{
    public string AttributeName {get;set}
    public int StudentNumber {get;set}

    {
        AttributeName= attributename;
        StudentNumber= studentnumber;
    }
}
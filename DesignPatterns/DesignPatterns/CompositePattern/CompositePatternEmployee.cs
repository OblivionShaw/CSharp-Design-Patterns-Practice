using System;
using System.Collections.Generic;

public class CompositePatternEmployee
{
    private string name;
    private string dept;
    private int salary;
    private List<CompositePatternEmployee> subordinates;

    // Constructor
    public CompositePatternEmployee(string name, string dept, int sal)
    {
        this.name = name;
        this.dept = dept;
        this.salary = sal;
        subordinates = new List<CompositePatternEmployee>();
    }

    public void Add(CompositePatternEmployee e)
    {
        subordinates.Add(e);
    }

    public void Remove(CompositePatternEmployee e)
    {
        subordinates.Remove(e);
    }

    public List<CompositePatternEmployee> GetSubordinates()
    {
        return subordinates;
    }

    public override string ToString()
    {
        return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salary + " ]");
    }
}
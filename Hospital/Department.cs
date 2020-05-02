using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Department
{
    public string name { get; set; }
    public int maximum { get; set; }
    public List<Pacient> people = new List<Pacient>();
    public string manager { get; set; }
    public int countpac { get; set; }
    public string phone { get; set; }



    public Department()
    {

    }

    public Department(string name, int max, string manager, string phone)
    {
        this.name = name;
        this.maximum = max;
        this.manager = manager;
        this.phone = phone;
        
    }



    public void Delete(Pacient pac)
    {
        this.people.Remove(pac);
        this.countpac = people.Count;
    }


    public void Add(Pacient pac)
    {
        people.Add(pac);
        pac.depart_name = name;
        countpac = people.Count;
    }

    public void ChangeName(string newname)
    {
        foreach(Pacient pac in people)
        {
            pac.depart_name = newname;
            name = newname;
        }
    }
    public string GetString()
    {
        return string.Format("Отделение - {0}, Начальник  - {1}, Пациентов - {2} ", name, manager, people.Count);
    }
}

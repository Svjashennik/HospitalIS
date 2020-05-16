using System.Collections.Generic;

public class Department
{
    public string name { get; set; }
    public List<Pacient> people = new List<Pacient>();
    public string manager { get; set; }
    public int countpac { get; set; }
    public string phone { get; set; }
    public List<int> rooms { get; set; }
    public int countroom { get; set; }

    public Department()
    {

    }

    public Department(string name, string manager, string phone, List<int> rooms)
    {
        this.name = name;
        this.rooms = rooms;
        this.manager = manager;
        this.phone = phone;
        countroom = rooms.Count;
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
        foreach (Pacient pac in people)
        {
            pac.depart_name = newname;
            name = newname;
        }
    }

    public static List<int> roomslst(int c, int id)
    {
        List<int> r = new List<int>();
        for (int i = 0; i < c; i++)
        {
            r.Add(id * 100 + i);
        }
        return r;
    }

    public string GetString()
    {
        return string.Format("Отделение - {0}, Начальник  - {1}, Пациентов - {2} ", name, manager, people.Count);
    }
}

using System.Collections.Generic;

public class Department
{
    public string name { get; set; } // название
    public List<Pacient> people = new List<Pacient>(); // список пациентов 
    public string manager { get; set; } // имя заведующего
    public int countpac { get; set; } // кол-во пациентов
    public string phone { get; set; } // телефон
    public List<int> rooms { get; set; } // список палат
    public int countroom { get; set; } // кол-во палат

    public Department()
    {

    }

    public Department(string name, string manager, string phone, List<int> rooms) // конструктор 
    {
        this.name = name;
        this.rooms = rooms;
        this.manager = manager;
        this.phone = phone;
        countroom = rooms.Count;
    }



    public void Delete(Pacient pac) // удаление пациента из списка
    {
        this.people.Remove(pac);
        this.countpac = people.Count;
    }


    public void Add(Pacient pac) // добавление пациента в список
    {
        people.Add(pac);
        pac.depart_name = name;
        countpac = people.Count;
    }

    public void ChangeName(string newname) // функция изменения имени
    {
        foreach (Pacient pac in people)
        {
            pac.depart_name = newname;
            name = newname;
        }
    }

    public static List<int> roomslst(int c, int id) // формирование списка палат
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

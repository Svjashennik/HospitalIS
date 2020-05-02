using Hospital;
using System;
using System.Collections.Generic;


public class Pacient
{
    public string name { get; set; } // Имя пациента
    public DateTime date { get; set; } // Дата рождения
    public string syndrom { get; set; }// Название болезни
    public string depart_name { get; set; } //Имя Департамента
    public int age { get; set; } // Возраст
    public DateTime date_add { get; set; } // Дата приема
    public DateTime date_close { get; set; } // Дата выписки
    public Pacient()
    {

    }

    public Pacient(string name, DateTime date, string syndrom, string depart_name, DateTime date_add, DateTime date_close, List<Department> departs)
    {
        this.depart_name = depart_name;
        Department dep = departs.Find(
            delegate (Department d)
            {
                return d.name == depart_name;
            });
        this.name = name;
        this.date_add = date_add;
        this.date_close = date_close;
        this.date = date;
        this.syndrom = syndrom;
        dep.Add(this);
        this.age = DateTime.Now.Year - this.date.Year;
    }

    public void ChangeDepart(Department dep, string syndrom, List<Department> departs) // Функция смены отделения и соответсвенно диагноза.
    {

        FindDep(departs).Delete(this);
        this.syndrom = syndrom;
        dep.Add(this);
    }

    public void ChangeDate(DateTime date) // Функция смены даты рождения.
    {
        this.date = date;
        age = DateTime.Now.Year - this.date.Year;
    }

    public void Out(List<Department> departs)
    {
        FindDep(departs).Delete(this);
    }

    public Department FindDep(List<Department> departs)
    {
        return departs.Find(dep => dep.name == depart_name);
    }
    public string GetString()
    {
        return string.Format("Имя - , Дата рождения - , Диагноз - , Отделение -  ,палата - .", name, date, syndrom, depart_name);
    }
}

using Hospital;
using System;
using System.Collections.Generic;


public class Pacient
{
    public string name { get; set; } // ��� ��������
    public int date { get; set; } // ���� ��������
    public string syndrom { get; set; }// �������� �������
    public string depart_name { get; set; } //��� ������������
    public int age { get; set; } // �������

    public Pacient()
    {

    }

    public Pacient(string name, int date, string syndrom, string depart_name,List<Department> departs)
    {
        this.depart_name = depart_name;
        Department dep = departs.Find(
            delegate (Department d)
            {
                return d.name == depart_name;
            });
        this.name = name;
        this.date = date;
        this.syndrom = syndrom;
        dep.Add(this);
        this.age = DateTime.Now.Year - this.date;
    }

    public void ChangeDepart(Department dep, string syndrom, List<Department> departs) // ������� ����� ��������� � ������������� ��������.
    {

        FindDep(departs).Delete(this);
        this.syndrom = syndrom;
        dep.Add(this);
    }

    public void ChangeDate(int date) // ������� ����� ���� ��������.
    {
        this.date = date;
        age = DateTime.Now.Year - this.date;
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
        return string.Format("��� - , ���� �������� - , ������� - , ��������� -  ,������ - .", name, date, syndrom, depart_name);
    }
}

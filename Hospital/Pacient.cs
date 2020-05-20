using System;
using System.Collections.Generic;

public class Pacient
{
    public string name { get; set; } // ��� ��������
    public DateTime date { get; set; } // ���� ��������
    public string syndrom { get; set; }// �������� �������
    public string depart_name { get; set; }//��� ������������
    public int room { get; set; }
    public int age { get; set; } // �������
    public DateTime date_add { get; set; } // ���� ������
    public DateTime date_close { get; set; } // ���� �������
    public bool hear { get; set; } // ���� �������
    public int dayhear { get; set; } // ���� � ��������
    public string medicinecard { get; set; } // ���.�����
    public Pacient()
    {

    }

    public Pacient(string name, DateTime date, string syndrom, string depart_name, int room, DateTime date_add, DateTime date_close, string medicinecard, List<Department> departs)
    { // �����������
        this.depart_name = depart_name;
        Department dep = departs.Find(
            delegate (Department d)
            {
                return d.name == depart_name;
            });
        this.name = name;
        this.room = room;
        this.date_add = date_add;
        this.date_close = date_close;
        this.date = date;
        this.syndrom = syndrom;
        dep.Add(this);
        this.hear = this.date_close > DateTime.Now;
        this.age = DateTime.Now.Year - this.date.Year;
        this.dayhear = date_close.Subtract(date_add).Days;
        this.medicinecard = medicinecard;
    }

    public void ChangeDepart(Department dep, string syndrom, int room, List<Department> departs) // ������� ����� ��������� � ������������� ��������.
    { // ������� ����� ������������.

        FindDep(departs).Delete(this); // �������� ���� �� ���������
        this.syndrom = syndrom; // ���������� ��������
        this.room = room; // ����� ������
        dep.Add(this); // ���������� ���� � �����
    }

    public void ChangeCloseDate(DateTime date_add, DateTime date_close)
    {
        this.date_add = date_add; // ����� ���� ������
        this.date_close = date_close;
        this.hear = (this.date_close > DateTime.Now);
        this.dayhear = date_close.Subtract(date_add).Days;
    }
    public void ChangeDate(DateTime date) // ������� ����� ���� ��������.
    {
        this.date = date;
        age = DateTime.Now.Year - this.date.Year;
    }

    public void Out(List<Department> departs) // ������� �������� �� ���������
    {
        FindDep(departs).Delete(this);
    }

    public Department FindDep(List<Department> departs) // ������� ���������� ��������� �� ������ ���������
    {
        return departs.Find(dep => dep.name == depart_name);
    }
    public string GetString()
    {
        return string.Format("��� - , ���� �������� - , ������� - , ��������� -  ,������ - .", name, date, syndrom, depart_name);
    }
}

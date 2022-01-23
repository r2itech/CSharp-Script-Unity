using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int age;
    public string name;

    public Item(int _age, string _name)
    {
        this.age = _age;
        this.name = _name;
    }

    public Item(int _age)
    {
        this.age = _age;
    }
}

[System.Serializable]
public class List
{
    public int no;
    public string list;
}

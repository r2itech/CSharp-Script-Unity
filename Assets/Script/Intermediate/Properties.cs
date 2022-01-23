using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    private int _myAge = 22;

    public int MyAge
    {
        get
        {
            return _myAge;
        }
        set
        {
            _myAge = value;
        }
    }
}

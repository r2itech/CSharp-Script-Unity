using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Helper;

public class Player : MonoBehaviour
{
    public Item[] myItem = new Item[2];

    public List myList;

    private Properties myProperties;
    // Start is called before the first frame update
    void Start()
    {
        //Constructor
        myItem[0] = new Item(12, "Ryucant");
        myItem[1] = new Item(22);

        //Static Types
            //transform.position = StaticExample.SetPositionToZero();

        //Properties
        myProperties = new Properties();
        Debug.Log(myProperties.MyAge);
        
        myProperties.MyAge = 23;
        Debug.Log(myProperties.MyAge);

        //Namespace
        transform.position = Helper.Position.SetPositionToZero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

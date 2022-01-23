using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            positionGameObject(this.gameObject);
            cube.GetComponent<Renderer>().material.color = ChangeColor(Color.green, cube);
        }
    }

    void positionGameObject(GameObject go)
    {
        Debug.Log("Position : " + go.transform.position);
    }

    Color ChangeColor(Color newColor, GameObject go)
    {
        return newColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tractor : MonoBehaviour
{
    public float tractspeed;
    public float turnspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * tractspeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * tractspeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, turnspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
        }
    }
}

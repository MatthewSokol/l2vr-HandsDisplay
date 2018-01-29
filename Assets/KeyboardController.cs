using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {
    public int spd = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print("keyboard input update");
        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // update player position based on input
        Vector3 position = transform.position;
        position.x += moveHorizontal * spd * Time.deltaTime;
        position.z += moveVertical * spd * Time.deltaTime;
        transform.position = position;

    }
}
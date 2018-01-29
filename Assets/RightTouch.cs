using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTouch : MonoBehaviour {

    public Camera firstPerson;
    public Camera thirdPerson;
    public Camera farFollow;
    public int i = 0;
    private bool prevA;

    // Use this for initialization
    void Start ()
    {
        this.firstPerson.enabled = false;
        this.thirdPerson.enabled = true;
        this.farFollow.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        OVRInput.Update();
        //print("right touch update");
        //bool thumbstickDown = OVRInput.GetDown(OVRInput.RawButton.RThumbstick);
       // bool thumbstickUp = OVRInput.GetUp(OVRInput.RawButton.RThumbstick);
       // bool aDown = OVRInput.GetDown(OVRInput.Button.Three);
       // bool aUp = OVRInput.GetUp(OVRInput.Button.Three);
       // bool bDown = OVRInput.GetDown(OVRInput.Button.Four);
       // bool bUp = OVRInput.GetUp(OVRInput.Button.Four);

        bool a = OVRInput.Get(OVRInput.Button.Three);
        bool b = OVRInput.Get(OVRInput.Button.Four);
        bool thumbstick = OVRInput.Get(OVRInput.Button.SecondaryThumbstick);

        //NOTE: touch controllers seem to be getting crossed

        //mimic for others...
        if (a != prevA && a)
        {
            print("a pressed");
            prevA = a;
        }
        else if (a != prevA && !a)
        {
            print("a released");
            prevA = a;
        }
        if (b)
        {
            print("b pressed");
        }
        if (thumbstick)//NOT WORKING
        {
            print("Right thumbstick pressed");
        }
        float triggerPressure = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        float gripPressure = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger);
        if (triggerPressure > 0)
        {
            print("Right Trigger pressed in " + triggerPressure * 100 + "%");
        }
        if (gripPressure > 0)
        {
            print("Right Grip pressed in " + gripPressure * 100 + "%");
        }

        // get input data from keyboard or controller
        Vector2 thumb = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 position = transform.position;
        position.x += thumb.x  * Time.deltaTime;
        position.z += thumb.y  * Time.deltaTime;
    }
}

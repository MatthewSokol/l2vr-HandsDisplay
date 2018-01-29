using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTouch : MonoBehaviour {

    public int speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        OVRInput.Update();
        //bool thumbstickDown = OVRInput.GetDown(OVRInput.RawButton.LThumbstick);
        //bool thumbstickUp = OVRInput.GetUp(OVRInput.RawButton.LThumbstick);
        //bool xDown = OVRInput.GetDown(OVRInput.Button.One);
        //bool xUp = OVRInput.GetUp(OVRInput.Button.One);
        //bool yDown = OVRInput.GetDown(OVRInput.Button.Two);
        //bool yUp = OVRInput.GetUp(OVRInput.Button.Two);
        bool x = OVRInput.Get(OVRInput.Button.One);
        bool y = OVRInput.Get(OVRInput.Button.Two);
        bool thumbstick = OVRInput.Get(OVRInput.Button.PrimaryThumbstick);
        if (x) {
            print("x pressed");
        }
        if (y)
        {
            print("y pressed");
        }
        if (thumbstick)
        {
            print("Left thumbstick pressed");
        }
        float triggerPressure = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        float gripPressure = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
        if (triggerPressure > 0)
        {
            print("Left Trigger pressed in " + triggerPressure * 100 + "%");
        }
        if (gripPressure > 0)
        {
            print("Left Grip pressed in " + gripPressure * 100 + "%");
        }

        //        print("; " + thumbstickDown + "; " + thumbstickUp + "; " + triggerPressure + "; " + gripPressure + "; " + xDown + "; " + xUp + "; " + yDown + "; " + yUp);
        // get input data from keyboard or controller
        Vector2 thumb = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 position = transform.position;
        position.x += thumb.x * speed * Time.deltaTime;
        position.z += thumb.y * speed * Time.deltaTime;
        transform.position = position;
	}
}

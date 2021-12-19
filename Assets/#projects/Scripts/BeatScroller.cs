using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    //arrow speed
    public float beatTempo; 

    //press button to start the scroll
    public bool hasStarted; 

    // Start is called before the first frame update
    void Start()
    {
        //ex : at 120bpm, will move two units per sec
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) 
        { //if "not has started" = true
            // if (Input.anyKeyDown) 
            // {//if any key has been pressed
            //     hasStarted = true;
            // }
        } else 
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
     
        }
    }
}

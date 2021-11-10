using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStaticValues : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Conductor.songPosition = 0;
        Conductor.songPositionInBeats = 0;
        Conductor.completedLoops = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

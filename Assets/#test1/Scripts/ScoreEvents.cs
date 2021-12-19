using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEvents : MonoBehaviour
{

public Conductor completedLoops; 
    public void PrintMessage()
    {
        Debug.Log("Hey");
        Debug.Log(completedLoops);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

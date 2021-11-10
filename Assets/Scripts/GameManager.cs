using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public bool startPlaying;
    public BeatScroller beatScroller;
    public static GameManager instance;
    public int currentScore;
    public int scorePerNote = 50;
    public Text scoreText;
    public Text multiText;

    //Multiplier system
    public int currentMultiplier;
    //Keep track of how we move to the next multiplier level
    public int multiplierTracker;
    //For each multiplier leve, make it harder to go to the next multiplier level
    public int[] multiplierThresholds;

    // Start is called before the first frame update
    void Start()
    {
        instance = this; //this = the object the script is attached to
        scoreText.text = "Score: 0";
        currentMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                beatScroller.hasStarted = true;

                music.Play();
            }
        }

    }

    public void NoteHit()
    {
        Debug.Log("Hit on Time");
        //If the maximum I can get to is three and that is less than the threshold's length:
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {



            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Multiplier : x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;

    }

    public void NoteMissed()
    {
        Debug.Log("Missed note");

    }
}

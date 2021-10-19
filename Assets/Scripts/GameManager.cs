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

    // Start is called before the first frame update
    void Start()
    {
        instance = this; //this = the object the script is attached to
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying){
            if(Input.anyKeyDown){
                startPlaying = true;
                beatScroller.hasStarted = true;

                music.Play();
            }
        }
        
    }

    public void NoteHit(){
        Debug.Log("Hit on Time");
        currentScore += scorePerNote;
    }

    public void NoteMissed(){
        Debug.Log("Missed note");

    }
}

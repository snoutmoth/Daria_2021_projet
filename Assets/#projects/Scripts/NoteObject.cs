using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed = true;
    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                //deactivate the button to see if it's visually working
                gameObject.SetActive(false);
                //calling our reference
                GameManager.instance.NoteHit();
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == ("Activator")) {
            canBePressed = true;
            

        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == ("Activator") && gameObject.activeSelf) {
            canBePressed = false;
            GameManager.instance.NoteMissed();
        }
    }
}

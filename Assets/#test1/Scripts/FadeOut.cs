using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public float timer = 0f;
    void Start()
    {

    }

    void Update(){

        
    }
    void Fading(float t)
    {
        timer += Time.deltaTime;
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FadeTo(0.0f, 0.2f));
        }

    }

    IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = transform.GetComponent<SpriteRenderer>().material.color.a;
        for (float t = 0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            transform.GetComponent<SpriteRenderer>().material.color = newColor;
            
            //regarder si bouton a été appuyé

            yield return null;
            
        }

    }
    // Start is called before the first frame update

}
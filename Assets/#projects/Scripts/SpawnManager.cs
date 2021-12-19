using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> arrows;
    public int arrowIndex;
    private float spawnRate = 1.0f;
    public float beatTempo;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody arrows = GetComponent<Rigidbody>();
        beatTempo = beatTempo / 60f;
        StartCoroutine(SpawnLeftArrow());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnLeftArrow()
    {
        while (gameManager.currentScore < 500)
        {
            
            Instantiate(arrows[2], new Vector3(2, 9, 0), arrows[2].transform.rotation);
            gameObject.transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            if (gameManager.currentScore >= 500)
            {   
                //find objects of type
                //si score à 500, il doit être setactive
                Destroy(gameObject);
                StopCoroutine("SpawnLeftArrow");
                

            }
            yield return new WaitForSeconds(spawnRate);
        }

        //stop coroutine spawnleftarrow
        //start coroutine
        //sur script flèches : find objects of type, avant d'arrêter coroutine (trouver préfabs dans la scène), ça va crééer liste, il faut la clear

    }

    

}
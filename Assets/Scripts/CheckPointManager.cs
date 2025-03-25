using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public short checkpointProgress = 1;
    public GameObject water;

    //Water position when touching checkpoint 
    private Vector2 waterTp2 = new Vector2(0f, -9f);
    private Vector2 waterTp3 = new Vector2(0f, 18.49f);
    private Vector2 waterTp4 = new Vector2(0f, -34.89f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Checkpoint2"))
        {
            checkpointProgress = 2;
            water.transform.position = waterTp2;
        }
        else if (other.gameObject.CompareTag("Checkpoint3"))
        {
            checkpointProgress = 3;
            water.transform.position = waterTp3;
        }
        else if (other.gameObject.CompareTag("Checkpoint4"))
        {
            checkpointProgress = 4;
            water.transform.position = waterTp4;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public short checkpointProgress = 1;
    public GameObject water;

    //Water position when touching checkpoint 
    private Vector2 waterTp2 = new Vector2(0f, -8.29f);
    private Vector2 waterTp3 = new Vector2(0f, 19.54f);
    private Vector2 waterTp4 = new Vector2(0f, 47.38f);
    private Vector2 waterTp5 = new Vector2(0f, 75.22f);
    private Vector2 waterTp6 = new Vector2(0f, 102.1f);
    private Vector2 waterTp7 = new Vector2(0f, 129.94f);
    private Vector2 waterTp8 = new Vector2(0f, 157.78f);
    private Vector2 waterTp9 = new Vector2(0f, 185.62f);

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
            if (checkpointProgress != 2)
            {
                water.transform.position = waterTp2;
            }
            checkpointProgress = 2;
        }
        else if (other.gameObject.CompareTag("Checkpoint3"))
        {
            if (checkpointProgress != 3)
            {
                water.transform.position = waterTp3;
            }
            checkpointProgress = 3;
        }
        else if (other.gameObject.CompareTag("Checkpoint4"))
        {
            if (checkpointProgress != 4)
            {
                water.transform.position = waterTp4;
            }
            checkpointProgress = 4;
        }
        else if (other.gameObject.CompareTag("Checkpoint5"))
        {
            if (checkpointProgress != 5)
            {
                water.transform.position = waterTp5;
            }
            checkpointProgress = 5;
        }
        else if (other.gameObject.CompareTag("Checkpoint6"))
        {
            if (checkpointProgress != 6)
            {
                water.transform.position = waterTp6;
            }
            checkpointProgress = 6;
        }
        else if (other.gameObject.CompareTag("Checkpoint7"))
        {
            if (checkpointProgress != 7)
            {
                water.transform.position = waterTp7;
            }
            checkpointProgress = 7;
        }
        else if (other.gameObject.CompareTag("Checkpoint8"))
        {
            if (checkpointProgress != 8)
            {
                water.transform.position = waterTp8;
            }
            checkpointProgress = 8;
        }
        else if (other.gameObject.CompareTag("Checkpoint9"))
        {
            if (checkpointProgress != 9)
            {
                water.transform.position = waterTp9;
            }
            checkpointProgress = 9;
        }

    }
}

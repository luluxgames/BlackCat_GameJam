using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertirX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvertirPosicionX();
        }
    }
    public void InvertirPosicionX()
    {
        transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
    }
}

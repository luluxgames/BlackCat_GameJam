using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionReflejo : MonoBehaviour
{
    public Transform gato;
    public bool onGround = false;
    public float speed = 10;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gato != null)
        {
            Vector3 targetPosition = new Vector3(-gato.position.x, gato.position.y, gato.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

        //        Collider2D detectedObject = Physics2D.OverlapCircle(detectionPoint.position, detectionRadius, objectLayer);
        //        if (detectedObject != null)
        //        {
        //            Debug.Log("Detected object: " + detectedObject.gameObject.name);
        //            onGround = true;
        //}
        //        else
        //        {
        //            onGround = false;
        //        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            
            InvertirPosicionX();

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.CompareTag("Suelo"))
        {
            onGround = true;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            onGround = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Collision undetected with: " + other.gameObject.name);
        if (other.CompareTag("Suelo"))
        {
            onGround = false;
        }
    }
    public void InvertirPosicionX()
    {
        if (onGround == false)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }

    }


}

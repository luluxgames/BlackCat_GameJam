using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionReflejo : MonoBehaviour
{
    public Transform gato;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gato != null)
        {
            transform.position = new Vector3(-gato.position.x, gato.position.y, gato.position.z);
        }
    }
}

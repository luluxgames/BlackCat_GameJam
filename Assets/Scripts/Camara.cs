using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform gato;
    public float upOffset;

    // Start is called before the first frame update
    void Start()
    {
        // Forzar una relación de aspecto 16:9 (1920x1080)
        float aspectRatio = 16f / 9f;
        Camera.main.aspect = aspectRatio;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(0, gato.position.y + upOffset, -10);
    }
}

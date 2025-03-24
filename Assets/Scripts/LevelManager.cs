using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Vector2 actualSpawn;
    private Vector2 actualWater;
    private Vector2 spawnLv1 = new Vector2(-6.25f, -2.45f);
    private Vector2 waterLv1 = new Vector2(0f, -33f);

    public GameObject gato;
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        movimientoGato scriptGato = gato.GetComponent<movimientoGato>();
        actualSpawn = spawnLv1;
        actualWater = waterLv1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void triggerGameOver()
    {
        Debug.Log("Perdiste mamahuevo");
        movimientoGato scriptGato = gato.GetComponent<movimientoGato>();
        scriptGato.playerMoved = false;

        gato.transform.position = actualSpawn;
        water.transform.position = actualWater;
    }
}

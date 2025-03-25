using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Vector2 actualSpawn;
    private Vector2 actualWater;

    //Spawn points per lvl
    private Vector2 spawnLv1 = new Vector2(-7f, -3.729f);

    //Water spawn points
    private Vector2 waterLv1 = new Vector2(0f, -34.89f);

    //Water speeds
    private float waterSpeedLv1 = 0.5f;

    public GameObject gato;
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        actualSpawn = spawnLv1;
        actualWater = waterLv1;


        WaterController scriptWater = water.GetComponent<WaterController>();
        scriptWater.velocidad = waterSpeedLv1;

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

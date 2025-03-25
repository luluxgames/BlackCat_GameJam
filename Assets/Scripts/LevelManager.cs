using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Vector2 actualSpawn;
    private Vector2 actualWaterSpawn;

    //Spawn points per lvl
    private Vector2 spawnLv1 = new Vector2(-7f, -3.729f);
    private Vector2 spawnLv2 = new Vector2(5.22f, 23.79f);
    private Vector2 spawnLv3 = new Vector2(-5.034f, 51.31f);
    private Vector2 spawnLv4 = new Vector2(-7f, -3.729f);

    //Water spawn points
    private Vector2 waterSpawnLv1 = new Vector2(0f, -34.89f);
    private Vector2 waterSpawnLv2 = new Vector2(0f, -7.68f);
    private Vector2 waterSpawnLv3 = new Vector2(0f, 19.81f);
    private Vector2 waterSpawnLv4 = new Vector2(0f, -34.89f);

    //Water speeds
    private float waterSpeedLv1 = 0.5f;
    private float waterSpeedLv2 = 1f;
    private float waterSpeedLv3 = 2f;
    private float waterSpeedLv4 = 0.5f;

    
    

    public GameObject gato;
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        actualSpawn = spawnLv1;
        actualWaterSpawn = waterSpawnLv1;

        //gato.transform.position = actualSpawn;
        //water.transform.position = actualWaterSpawn;

        WaterController scriptWater = water.GetComponent<WaterController>();
        scriptWater.velocidad = waterSpeedLv1;

    }

    // Update is called once per frame
    void Update()
    {
        CheckPointManager checkpointScript = gato.GetComponent<CheckPointManager>();
        WaterController scriptWater = water.GetComponent<WaterController>();
        if (checkpointScript.checkpointProgress == 2)
        {
            actualSpawn = spawnLv2;
            actualWaterSpawn = waterSpawnLv2;
            scriptWater.velocidad = waterSpeedLv2;

        }
        else if (checkpointScript.checkpointProgress == 3){
            actualSpawn = spawnLv3;
            actualWaterSpawn = waterSpawnLv3;
            scriptWater.velocidad = waterSpeedLv3;
            
        }
        else if (checkpointScript.checkpointProgress == 4)
        {
            actualSpawn = spawnLv4;
            actualWaterSpawn = waterSpawnLv4;
            scriptWater.velocidad = waterSpeedLv4;
            
        }
    }
    public void triggerGameOver()
    {
        Debug.Log("Perdiste mamahuevo");
        movimientoGato scriptGato = gato.GetComponent<movimientoGato>();
        scriptGato.playerMoved = false;

        gato.transform.position = actualSpawn;
        water.transform.position = actualWaterSpawn;
    }
}

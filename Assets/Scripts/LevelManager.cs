using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Vector2 actualSpawn;
    private Vector2 actualWaterSpawn;

    //Spawn points per lvl
    private Vector2 spawnLv1 = new Vector2(-6.78f, -3.49682f);
    private Vector2 spawnLv2 = new Vector2(2.14f, 24.35f);
    private Vector2 spawnLv3 = new Vector2(-6.65f, 52.18f);
    private Vector2 spawnLv4 = new Vector2(-3.37f, 80.02f);
    private Vector2 spawnLv5 = new Vector2(0.99f, 107.86f);
    private Vector2 spawnLv6 = new Vector2(-1.88f, 134.74f);
    private Vector2 spawnLv7 = new Vector2(5.75f, 162.58f);
    private Vector2 spawnLv8 = new Vector2(-4.34f, 190.42f);
    private Vector2 spawnLv9 = new Vector2(-4.33f, 218.26f);

    //Water spawn points -31,39 -1.25
    private Vector2 waterSpawnLv1 = new Vector2(0f, -34.89f);
    private Vector2 waterSpawnLv2 = new Vector2(0f, -7.04f);
    private Vector2 waterSpawnLv3 = new Vector2(0f, 20.79f);
    private Vector2 waterSpawnLv4 = new Vector2(0f, 48.63f);
    private Vector2 waterSpawnLv5 = new Vector2(0f, 76.47f);
    private Vector2 waterSpawnLv6 = new Vector2(0f, 103.35f);
    private Vector2 waterSpawnLv7 = new Vector2(0f, 131.19f);
    private Vector2 waterSpawnLv8 = new Vector2(0f, 159.03f);
    private Vector2 waterSpawnLv9 = new Vector2(0f, 186.87f);

    //Water speeds
    private float waterSpeedLv1 = 0.75f;
    private float waterSpeedLv2 = 1f;
    private float waterSpeedLv3 = 2f;
    private float waterSpeedLv4 = 0.5f;
    private float waterSpeedLv5 = 0.5f;
    private float waterSpeedLv6 = 0.5f;
    private float waterSpeedLv7 = 0.5f;
    private float waterSpeedLv8 = 0.5f;
    private float waterSpeedLv9 = 0.5f;




    public GameObject gato;
    public GameObject water;
    public GameObject reflejo;

    // Start is called before the first frame update
    void Start()
    {
        actualSpawn = spawnLv7;
        actualWaterSpawn = waterSpawnLv7;

        gato.transform.position = actualSpawn;
        water.transform.position = actualWaterSpawn;
        reflejo.transform.position = new Vector2(-actualSpawn.x, actualSpawn.y);

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
        else if (checkpointScript.checkpointProgress == 5)
        {
            actualSpawn = spawnLv5;
            actualWaterSpawn = waterSpawnLv5;
            scriptWater.velocidad = waterSpeedLv5;

        }
        else if (checkpointScript.checkpointProgress == 6)
        {
            actualSpawn = spawnLv6;
            actualWaterSpawn = waterSpawnLv6;
            scriptWater.velocidad = waterSpeedLv6;

        }
        else if (checkpointScript.checkpointProgress == 7)
        {
            actualSpawn = spawnLv7;
            actualWaterSpawn = waterSpawnLv7;
            scriptWater.velocidad = waterSpeedLv7;

        }
        else if (checkpointScript.checkpointProgress == 8)
        {
            actualSpawn = spawnLv8;
            actualWaterSpawn = waterSpawnLv8;
            scriptWater.velocidad = waterSpeedLv8;

        }
        else if (checkpointScript.checkpointProgress == 9)
        {
            actualSpawn = spawnLv9;
            actualWaterSpawn = waterSpawnLv9;
            scriptWater.velocidad = waterSpeedLv9;

        }
    }
    public void triggerGameOver()
    {
        Debug.Log("Perdiste mamahuevo");
        movimientoGato scriptGato = gato.GetComponent<movimientoGato>();
        scriptGato.playerMoved = false;

        gato.transform.position = actualSpawn;
        reflejo.transform.position = new Vector2 (-actualSpawn.x, actualSpawn.y);
        water.transform.position = actualWaterSpawn;
    }
}

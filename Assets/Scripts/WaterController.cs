using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    public GameOver gameOver;
    public movimientoGato movimientoGato;
    public float velocidad = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoGato.playerMoved == true && gameOver.destructionStarted == false)
        {
            Debug.Log("Se mueve la awita");
            transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameOver.KillPlayerWithDelay();
        }
    }
}

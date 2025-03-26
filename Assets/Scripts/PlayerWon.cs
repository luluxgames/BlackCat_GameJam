using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerWon : MonoBehaviour
{
    public GameObject texto;

    private Animator animator;
    public bool checkpointActivated = false;
    public GameObject gato;
    public MonoBehaviour movimientoGato;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!checkpointActivated)
            {
                animator.SetBool("Check", true);
                movimientoGato.enabled = false;
                texto.SetActive(true);

            }
            checkpointActivated = true;
        }
    }
}

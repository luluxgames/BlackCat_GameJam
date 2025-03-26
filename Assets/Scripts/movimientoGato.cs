using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
//using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class movimientoGato : MonoBehaviour
{
    private Rigidbody2D rb;
    public PosicionReflejo posicionReflejo;

    //detectar si el jugador se ha movido
    public bool playerMoved = false;
    public RayCast rayCast;

    [Header("Movimiento")]
    private float movimientoHorizontal = 0f;
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float smoothMovimiento;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;

    [Header("Salto")]
    [SerializeField] private float fuerzaSalto;
    private bool salto = false;
    
    // Sprites y animaciones
    public SpriteRenderer playerSprite;
    public Animator animator;
    bool isIdle = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadMovimiento;

        if (Input.GetButtonDown("Horizontal"))
        {
            playerMoved = true;
            animator.SetBool("Jump", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Walk", true);
            isIdle = false; // Reset idle state
            Debug.Log("Walk");
        }
    

        if (Input.GetButtonDown("Jump"))
        {
            playerMoved = true;
            salto = true;
            animator.SetBool("Idle", false);
            animator.SetBool("Walk", false);
            animator.SetBool("Jump", true);
            Debug.Log("Jump");
            isIdle = false; // Reset idle state
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            playerMoved = true;
            InvertirPosicionX();

        }

        if (movimientoHorizontal == 0 && !Input.GetButton("Jump") && !Input.GetKey(KeyCode.J))
        {
            if (!isIdle) // Only trigger Idle once
            {
                animator.SetBool("Idle", true);
                animator.SetBool("Walk", false);
                animator.SetBool("Jump", false);
                Debug.Log("Idle");
                isIdle = true; // Mark as idle so it doesn’t keep firing
            }
        }
        else
        {
            isIdle = false; // Reset if the player moves again
        }

    }

    private void FixedUpdate()
    {
        Mover(movimientoHorizontal * Time.fixedDeltaTime, salto);
        salto = false;
        //salto = false;
    }

    private void Mover(float mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, velocidadObjetivo, ref velocidad, smoothMovimiento);
    
        if(mover>0 && !mirandoDerecha)
        {
            Girar();

        } else if(mover<0 && mirandoDerecha)
        {
            Girar();

        }

        if(rayCast.enSuelo && saltar)
        {

            rb.AddForce(new Vector2(0f, fuerzaSalto));
        }

    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }



    public void InvertirPosicionX()
    {
        if (posicionReflejo.onGround == false)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
        
    }

}

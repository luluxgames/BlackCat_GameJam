using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointAnimator : MonoBehaviour
{
    private Animator animator;
    public bool checkpointActivated = false;
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
            if (!checkpointActivated) {
                animator.SetBool("Check", true);
            }
            checkpointActivated = true;
        }
    }


}

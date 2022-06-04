using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masked_Man_Animation : MonoBehaviour
{
    private Animator maskedManAnimation;
    private Rigidbody2D rb;

    private void Start()
    {
        maskedManAnimation = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb.velocity.x != 0f && rb.velocity.y != 0f )
            maskedManAnimation.SetBool("Walk", true);
        else maskedManAnimation.SetBool("Walk", false );
    }
}

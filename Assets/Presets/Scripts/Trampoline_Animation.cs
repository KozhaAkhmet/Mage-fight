using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline_Animation : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private AudioSource onSound;    
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            onSound.Play();
            anim.SetBool("Trigger", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.SetBool("Trigger", false);
        }
    }
}

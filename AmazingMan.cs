using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmazingMan : MonoBehaviour
{
    public float WalkSpeed = 1.5f;
    public float TurnSpeed = 100.0f;
    private Animator anim = null;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private void Update()
    {
        //reading input
        float vert = Input.GetAxis("Vertical"); // -1..1 
        float horz = Input.GetAxis("Horizontal"); // -1..1

        //controlling which animation plays
        if (Mathf.Abs(vert) != 0.0f)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        //move and turn
        this.transform.Translate(0.0f, 0.0f, vert * WalkSpeed * Time.deltaTime);
        this.transform.Rotate(0.0f, horz * TurnSpeed * Time.deltaTime, 0.0f);
    }
}
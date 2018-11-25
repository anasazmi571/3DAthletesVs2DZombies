using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Animator anim;
    private float HealthPoint = 100;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // movement using root motion or not?
        if (Input.GetKey(KeyCode.W))
        {
            // forward
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // backward
        }

        if (Input.GetKey(KeyCode.A))
        {
            // left
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // right
        }

        // mouse
        if (Input.GetMouseButton(1))
        {
            // 2nd mode attack ready
            if (Input.GetMouseButtonDown(0))
            {
                // 2nd mode attack initiate
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            // normal attack
        }
    }

	public void Movement()
    {

    }

    public void AttackPrimary()
    {

    }

    public void AttackSecondary()
    {

    }

    public void ApplyDamage()
    {

    }

    public void Dead()
    {

    }
}

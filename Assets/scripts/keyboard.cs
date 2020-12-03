using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private string BoolToPressed(bool state)
    {
        return state ? "Pressed" : "Released";
    }

    private void PlayKey(KeyCode keyCode, bool state)
    {
        animator.SetBool(keyCode + BoolToPressed(!state), false);
        animator.SetBool(keyCode + BoolToPressed(state), true);
    }

    private void animations()
    {
        for (KeyCode a = KeyCode.Backspace; a <= KeyCode.Menu; a++)
        {
            if (Input.GetKeyDown(a))
            {
                PlayKey(a, true);
            }
            else if (Input.GetKeyUp(a))
            {
                PlayKey(a, false);
            }
        }
    }
    void Update()
    {
        animations();
    }
}

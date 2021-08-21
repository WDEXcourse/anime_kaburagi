using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))// もしWSADキーのいずれかが押されたら、

        {
            anim.SetBool("isStanding", true);// AnimatorのisRunningをtrueにする
        }

        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))// もしWSADキーのいずれかが離されたら、
        {
            anim.SetBool("isStanding", false);// AnimatorのisRunningをfalseにする
        }

        if (Input.GetKeyDown(KeyCode.Space))// もし、スペースキーが押されたら、
        {
            anim.SetBool("isShoved", true);// AnimatorのAttackをtrueにする
        }

        else if (Input.GetKeyUp(KeyCode.Space))// もし、スペースキーが離されたら、
        {
            anim.SetBool("isShoved", false);// Attackをfalseにする
        }
    }
}

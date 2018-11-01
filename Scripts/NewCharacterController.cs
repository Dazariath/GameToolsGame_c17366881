using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterController : MonoBehaviour {

    private Animator _animator;

    float m_sprint;

    // Use this for initialization
    void Start () {
        _animator = GetComponent<Animator>();
	}    

    public void Move(float turn,float forward, bool jump, float sprint)
    {
        _animator.SetFloat("turn", turn);
        _animator.SetFloat("forward", forward);
        _animator.SetFloat("sprint", sprint);

        if (jump)
        {
            _animator.SetTrigger("jump");            
        }

        //Sprinting();
    }

    /*void Sprinting()
    {
        if (Input.GetKey("Fire1"))
        {
            m_sprint = 0.2f;
        }
        else
        {
            m_sprint = 0.0f;
        }
    }*/
}

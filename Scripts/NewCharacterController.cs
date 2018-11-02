using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewCharacterController : MonoBehaviour {

    private Animator m_animator;

    float m_sprint;   

    private bool m_enableIK;
    private float m_weightIK;
    private Vector3 m_positionIK;

    // Use this for initialization
    void Start () {
        m_animator = GetComponent<Animator>();
	}    

    public void Move(float turn,float forward, bool jump, float sprint)
    {
        m_animator.SetFloat("turn", turn);
        m_animator.SetFloat("forward", forward);
        m_animator.SetFloat("sprint", sprint);        

        if (jump)
        {
            m_animator.SetTrigger("jump");
            m_animator.SetFloat("turn", turn);
            m_animator.SetFloat("forward", forward);
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

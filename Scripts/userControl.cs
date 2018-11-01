using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userControl : MonoBehaviour {

    private NewCharacterController m_character;
    public CharacterController m_controller;

    private float m_turn;
    private float m_forward;
    private bool m_jump;
    private bool m_pick;

    private float m_sprint;

    private Vector3 m_moveD;
    public float m_moveS;

    //public Rigidbody m_rb;
    public float JumpForce;

    public float gravityScale;

    // Use this for initialization
    void Start () {
        //m_rb = GetComponent<Rigidbody>();
        m_character = GetComponent<NewCharacterController>();
        m_controller = GetComponent<CharacterController>();
	}

    // Update is called once per frame
    void FixedUpdate () {

        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_pick = Input.GetKeyDown(KeyCode.C);

        m_jump = Input.GetButtonDown("Jump");

        //m_moveD = new Vector3(Input.GetAxis("Horizontal"), m_moveD.y, Input.GetAxis("Vertical"));

        if (Input.GetButton("Fire1"))
        {
            m_sprint = 0.2f;
        }
        else
        {
            m_sprint = 0.0f;
        }

        if (m_controller.isGrounded)
        {            
            if (Input.GetButtonDown("Jump"))
            {
                m_moveD.y = JumpForce;
                //m_moveD.x = JumpForce / 2;
                //m_moveD.z = JumpForce / 2;
            }
        }

        //Sprinting();

        m_moveD.y = m_moveD.y + (Physics.gravity.y * Time.deltaTime * gravityScale);
        m_character.Move(m_turn,m_forward,m_jump,m_sprint);
        m_controller.Move(m_moveD*Time.deltaTime);
    }

    /*void Sprinting()
    {
        if (Input.GetButton("Fire1"))
        {
            m_sprint = 0.2f;
        }
        else
        {
            m_sprint = 0.0f;
        }
    }*/
}

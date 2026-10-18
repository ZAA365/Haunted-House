using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction MoveAction;
    AudioSource m_AudioSource;

    public float walkSpeed = 1.0f;

    private Animator m_Animator;
    private Rigidbody m_Rigidbody;
    private Vector3 m_Movement;

    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Animator = GetComponent<Animator>();
        MoveAction.Enable();
    }

    void FixedUpdate()
    {
        Vector2 pos = MoveAction.ReadValue<Vector2>();

        float horizontal = pos.x;
        float vertical = pos.y;

        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize();

        bool isWalking = m_Movement != Vector3.zero;
        m_Animator.SetBool("IsWalking", isWalking);

        if (isWalking)
        {
            m_Rigidbody.MoveRotation(
                Quaternion.LookRotation(m_Movement)
            );
        }

        m_Rigidbody.MovePosition(
            m_Rigidbody.position +
            m_Movement * walkSpeed * Time.deltaTime
        );

        if (isWalking)
{
    if (!m_AudioSource.isPlaying)
    {
        m_AudioSource.Play();
    }
}
else
{
    m_AudioSource.Stop();
}
    }
    
}
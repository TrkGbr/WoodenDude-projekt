using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float speed;
    public Animator animator;
    private Vector2 moveInputValue;
    public AudioSource footsteps;

    private void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
        Debug.Log(moveInputValue);
        footsteps.enabled = true;

    }

    private void MoveLogicMethod()
    {
        Vector2 result = moveInputValue * speed * Time.fixedDeltaTime;
        rb2D.velocity = result;
    }

    private void FixedUpdate()
    {
        MoveLogicMethod();
        rb2D.MovePosition(rb2D.position + moveInputValue * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        //Irányzatok hozzárendelése a movementhez
        moveInputValue.x = Input.GetAxisRaw("Horizontal");
        moveInputValue.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", moveInputValue.x);
        animator.SetFloat("Vertical", moveInputValue.y);
        animator.SetFloat("Speed", moveInputValue.sqrMagnitude);

        moveInputValue = new Vector2(moveInputValue.x, moveInputValue.y).normalized;

        if (rb2D.velocity.x == 0 && rb2D.velocity.y == 0)
        {
            footsteps.enabled = false;
        }
    }
}
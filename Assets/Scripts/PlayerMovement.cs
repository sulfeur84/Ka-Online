using Mirror;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    private bool jump = false;
    public Animator animator;
    
    private void Update()
    {
        if (!isLocalPlayer) return;
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    
}

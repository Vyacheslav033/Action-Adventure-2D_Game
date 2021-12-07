using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float slideForce = 20f;
    public Animator animator;
    public Collider2D mainColider, slideColider;
    public TextMeshProUGUI gameOverText;
    public GameObject restartLevel;

    bool isGrounded;
    bool P_facingRight = true;
    bool jumpKeyDown;
    bool isSliding = false;
    bool slideKeyDown;
    float movement;

    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //getting the rigidBody.
        slideColider.enabled = false;
    }

    private void FixedUpdate()
    {
        //all physics related work done here.
        moveHorizontal();
        jump();
        slide();

    }

    private void Update()
    {
        
            //all input related work done here.
            movement = Input.GetAxisRaw("Horizontal");   //geting the input on horizontal axis.

            if (!jumpKeyDown && isGrounded)
            {
                jumpKeyDown = Input.GetButtonDown("Jump");   //checking for jump key down.
            }

            if (!slideKeyDown && isGrounded && Mathf.Abs(rb.velocity.x) > 0.05)
            {
                slideKeyDown = Input.GetKeyDown(KeyCode.S);   //checking for slide key down. 
            }
        

        if (movement > 0 && !P_facingRight)   //checking for player faceing direction.
        {
            Flip();
        }
        else if (movement < 0 && P_facingRight)
        {
            Flip();
        }

        if (!isGrounded && !isSliding)   //checking if the player is drooping
        {
            animator.SetBool("IsJumping", true);
        }


    }

    private void slide()
    {
        if (slideKeyDown)
        {
            isSliding = true;
            animator.SetBool("IsSliding", true);
            if (P_facingRight)
            {
                rb.velocity = new Vector2(slideForce, 0f);
            }
            else if (!P_facingRight)
            {
                rb.velocity = new Vector2(-slideForce, 0f);
            }
            slideColider.enabled = true;
            mainColider.enabled = false;
            StartCoroutine("stopSliding");
        }
    }

    private IEnumerator stopSliding()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("IsSliding", false);
        slideKeyDown = false;
        mainColider.enabled = true;
        slideColider.enabled = false;
        isSliding = false;
    }

    private void jump()
    {
        if (jumpKeyDown && isGrounded)
        {
            // Adding force to rigidBody.
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

            // Enabling the jump animation.
            animator.SetBool("IsJumping", true);   

            isGrounded = false;
            jumpKeyDown = false;
        }
    }

    private void moveHorizontal()
    {
        // Adding the velocity to the rigidBody
        rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);

        // Enabling or disabling run animation.
        animator.SetFloat("Speed", Mathf.Abs(movement));   
    }

    /// <summary>
    /// Checking the player it is grounded or not.
    /// </summary>
    /// <param name="collision"> Collider2D. </param>
    private void OnTriggerStay2D(Collider2D collision)  
    {
        if (collision != null && collision != cameraCollider.getCollider())
        {
            isGrounded = true;
            animator.SetBool("IsJumping", false);  //if player is grounded disabling the jump animation.
        }
    }

    private void OnTriggerExit2D(Collider2D collision)   //checking for player to exit the ground.
    {
        isGrounded = false;
    }

    /// <summary>
    /// Fliping the player direction.
    /// </summary>
    private void Flip() 
    {
        // Switch the way the player is labelled as facing.
        P_facingRight = !P_facingRight;   

        transform.Rotate(0f, 180f, 0f);
    }

    /// <summary>
    /// Calling through animation event(at end frame)
    /// </summary>
    private void dead() 
    {
        Destroy(gameObject);
        enablingUI();
    }

    private void preDeath()  //calling through animation event(at end frame)
    {
        Destroy(gameObject, 1f);
        enablingUI();
    }

    private void enablingUI()
    {
        gameOverText.enabled = true; //enabling the game over text
        restartLevel.SetActive(true); //enabling restart button
    }

}

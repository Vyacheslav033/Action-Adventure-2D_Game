using UnityEngine;

public class EnemyAttack : MonoBehaviour
{    
    private Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        animator = collision.gameObject.GetComponent<Animator>();
        animator.SetBool("IsDead", true);
    }
}

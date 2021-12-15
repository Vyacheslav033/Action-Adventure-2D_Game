using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePosition;
    public Animator animator;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Equipment.BulletsCount > 0)
        {
            animator.Play("Player_Fire");
            Fire();         
        }
    }

    private void Fire()
    {
        Instantiate(bullet, firePosition.position, firePosition.rotation);
        Equipment.BulletsCount -= 1;
    }
}
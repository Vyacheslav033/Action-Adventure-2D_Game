using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePosition;
    public Animator animator;
    private static int bulletsCount;

    private void Start()
    {
        bulletsCount = 20;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && bulletsCount > 0)
        {
            animator.Play("Player_Fire");
            Fire();         
        }
    }

    private void Fire()
    {
        Instantiate(bullet, firePosition.position, firePosition.rotation);
        bulletsCount -= 1;
    }

    public static int GetBulletsCount()
    {
        return bulletsCount;
    }
}
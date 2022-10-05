using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damage;
    public float canfire = 1f;
    public float firerate = 1f;

    public Transform firepoint;
    public GameObject bulletPrefab;
    //public Animator weaponAnimation;
    bool fireAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > canfire)
        {
            //fireAnimation = !fireAnimation;
            //weaponAnimation.SetBool("isFiring", fireAnimation);
            Shoot();
            canfire = Time.time + firerate;
        }
    }

    public void Shoot()
    {
        AudioManager audioManager = FindObjectOfType<AudioManager>();

        //fireAnimation = !fireAnimation;
        //weaponAnimation.SetBool("isFiring", fireAnimation);
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);

        Animator animator = gameObject.GetComponent<Animator>();
        animator.SetBool("shoot", true);

        audioManager.playSound("gunShot");

        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fire"))
        //{
        //    animator.SetBool("shoot", false);

        //}
        //else
        //{

        //}
        //FindObjectOfType<AudioManager>().playSound("gunShot");
    }

    public void cancelAnimation()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.SetBool("shoot", false);
    }
}

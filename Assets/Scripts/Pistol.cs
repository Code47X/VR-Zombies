using UnityEngine;
using VRTK;
using System.Collections;

public class Pistol : VRTK_InteractableObject
{
    // Handling
    public float bulletSpeed = 1000f;
    public float bulletLife = 5f;

    // Component
    private GameObject bullet;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        FireBullet();
    }

    protected override void Start()
    {
        base.Start();
        bullet = transform.Find("Bullet").gameObject;
        bullet.SetActive(false);
    }

    private void FireBullet()
    {
        GameObject bulletClone = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
        bulletClone.SetActive(true);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.AddForce(bullet.transform.forward * bulletSpeed);
        Destroy(bulletClone, bulletLife);
    }
}
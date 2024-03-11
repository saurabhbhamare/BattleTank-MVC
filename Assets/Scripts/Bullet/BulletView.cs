using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    private BulletController bulletcontroller;
    public  Rigidbody rb;

    void Start()
    {
        bulletcontroller.FireBullet();
    }
    public void SetBulletController(BulletController _bulletController)
    {
        bulletcontroller = _bulletController;

    }
    private void OnCollisionEnter(Collision collision)
    {
        bulletcontroller.BulletCollision(collision);
    }
}

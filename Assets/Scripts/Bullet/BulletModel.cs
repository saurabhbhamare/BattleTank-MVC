using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel 
{
    public BulletController bulletController;
    public BulletSpawner bulletSpawner;
    public BulletModel(BulletSpawner _bulletSpawner)
    {

        this.bulletSpawner = _bulletSpawner;
      
    }
    public void SetBulletController(BulletController _bulletController)
    {
        this.bulletController = _bulletController;
    }


}

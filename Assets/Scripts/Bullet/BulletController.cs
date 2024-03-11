using UnityEngine;

public class BulletController 
{
    public BulletModel bulletModel;
    public BulletView bulletView;
    private Transform bulletSpawnPoint;
 
    public BulletController(BulletSpawner bulletSpawner, Transform transform)
    {
        this.bulletModel = new BulletModel(bulletSpawner);
        this.bulletModel.SetBulletController(this);
        this.bulletView = GameObject.Instantiate<BulletView>(bulletSpawner.bulletView, transform);
        this.bulletView.SetBulletController(this);
        this.bulletSpawnPoint = transform;
    }
    public void FireBullet()
    {
        bulletView.rb.AddForce(bulletSpawnPoint.forward * bulletModel.bulletSpawner.bulletSpeed, ForceMode.Impulse);
    }
    public void BulletCollision(Collision collision)
    {
        GameObject.Destroy(bulletView.gameObject);
    }
}

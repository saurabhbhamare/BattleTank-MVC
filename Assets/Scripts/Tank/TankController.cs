
using UnityEngine;

public class TankController 
{
    private BulletSpawner bullet;
    public TankModel tankModel;
    public TankView tankView;
    private Rigidbody rb; 
    public TankController(TankModel _tankModel , TankView _tankView , BulletSpawner _bullet )
    {
        this.bullet = _bullet;
        tankModel = _tankModel;
       tankView = GameObject.Instantiate<TankView>(_tankView);
       rb = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.color);
    }
    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotate , float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
    public TankModel GetTankModel()
    {
        return tankModel;
    } 
    public void FireBullet(Transform fireTransform)
    {
        BulletController bulletController = new BulletController(bullet,fireTransform);
    }

}

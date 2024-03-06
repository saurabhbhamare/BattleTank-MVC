
using UnityEngine;
public class TankModel 
{
    public  float movementSpeed;
    public float rotateSpeed;

    public TankController tankController;
    public TankModel(float _movementSpeed, float _rotateSpeed)
    {
        movementSpeed = _movementSpeed;
        rotateSpeed = _rotateSpeed; 
    }
  public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}

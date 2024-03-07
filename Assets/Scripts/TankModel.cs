using UnityEngine;
public class TankModel 
{
    public  float movementSpeed;
    public float rotateSpeed;
    public TankTypes tankType;
    public Material color;

    public TankController tankController;
    public TankModel(float _movementSpeed, float _rotateSpeed,TankTypes tank, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotateSpeed = _rotateSpeed;
        tankType = tank;
        color = _color; 

    }
  public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}

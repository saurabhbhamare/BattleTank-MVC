using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
   public  TankController tankController;   
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}

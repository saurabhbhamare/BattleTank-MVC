using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
   public TankSpawner tankSpawner;
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.blue);
        this.gameObject.SetActive(false);
        Debug.Log("blue tank selected");
    }
    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.green);
        this.gameObject.SetActive(false);
    }
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.red);
        this.gameObject.SetActive(false);
    }


}

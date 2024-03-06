using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    void Start()
    {
        CreateTank();
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
    }
    public void CreateTank()
    {
        TankModel tankModel = new TankModel(20,30);
        TankController tankController = new TankController(tankModel, tankView);
    }
}

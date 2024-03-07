using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    [System.Serializable]
    public class Tank
    { 
        public float  movementSpeed;
        public float rotateSpeed;
        public TankTypes tankType;
        public Material color; 
    }
    public List<Tank> tankList;

    public void CreateTank(TankTypes tankType)
    {
        if(tankType == TankTypes.blue)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotateSpeed, tankList[0].tankType, tankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankTypes.green)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotateSpeed, tankList[1].tankType, tankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankTypes.red)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotateSpeed, tankList[2].tankType, tankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        
    }
}

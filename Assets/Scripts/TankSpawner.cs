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

    void Start()
    {
        CreateTank();
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
    }
    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotateSpeed, tankList[1].tankType,tankList[1].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}

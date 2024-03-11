using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public TankController tankController;
    private float movement;
    private float rotate;
    public Rigidbody rb;
    public MeshRenderer[] childs;
    public Transform shellSpawnPoint;
 
    public void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }
    public void Update()
    {
        Movement();
        if(movement != 0 )
        {
            tankController.Move(movement,tankController.GetTankModel().movementSpeed);
        }
        if(rotate != 0 )
        {
            tankController.Rotate(rotate, tankController.GetTankModel().rotateSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
         tankController.FireBullet(shellSpawnPoint);
        }     
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
        Debug.Log("bullet fired");
    }
    void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void ChangeColor(Material color)
    {
        for(int i = 0; i < childs.Length; i++)
        {
            childs[i].material = color;
        }
    }
}

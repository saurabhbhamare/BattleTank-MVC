
using UnityEngine;

public class TankController 
{
    public TankModel tankModel;
    public TankView tankView; 
   
    public TankController(TankModel _tankModel , TankView _tankView )
    {
        tankModel = _tankModel;
        tankView = _tankView;

        GameObject.Instantiate(tankView.gameObject);
    }

}

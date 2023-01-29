using System;
using UnityEngine;

//test for interfaces, not using
public class UserInput : MonoBehaviour
{
    public CharBase characterObj;
    private IMove moveObj;


    private void Awake()
    {
        moveObj = characterObj as IMove;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveObj.Move();
        }
    }

    public void ChangeToVehicle(VehicleBase vehicleObj)
    {
        moveObj = vehicleObj;
    }
}

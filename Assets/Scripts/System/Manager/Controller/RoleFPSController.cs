using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 角色控制
/// </summary>
public class RoleFPSController : MonoBehaviour{

    public RoleFPSMotor motor;

    void Start(){
    }

    void Update(){
        float horizontal = InputSystem.instance.GetAxis("Horizontal");
        float vertical = InputSystem.instance.GetAxis("Vertical");

        float mouseY = InputSystem.instance.GetAxis("Mouse Y");
        float mouseX = InputSystem.instance.GetAxis("Mouse X");

        //传递移动方向参数
        motor.SetMoveDir(new Vector3(horizontal, 0 ,vertical));
        motor.SetRotateY(mouseX);
        motor.SetCamRotateX(mouseY);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 角色发动机
/// </summary>
public class RoleFPSMotor : MonoBehaviour{

    [Header("=============== 角色相关 ===============")]
    [Tooltip("角色控制器组件")]
    public CharacterController controller;
    [Tooltip("鼠标水平灵敏度")]
    public float mouseSensitive;
    [Tooltip("移动方向")]
    private Vector3 moveDir = Vector2.zero;
    [Tooltip("旋转方向")]
    private float rotateX;
    [Tooltip("移动速度")]
    public float moveSpeed;
    [Tooltip("跳跃力度")]
    public float jumpPower = 5;
    [Tooltip("重力")]
    public float gravity = 9.8f;

    [Header("=============== 相机相关 ===============")]
    [Tooltip("相机组件")]
    public Camera cam;
    [Tooltip("相机灵敏度")]
    public float camSensitive;
    [Tooltip("相机限制角度")]
    public float camRotateLimit = 80f;
    [Tooltip("相机视角方向")]
    private float camRotateX;

    [Header("=============== 角色配置相关 ===============")]
    [Tooltip("角色配置")]
    public SORoleBase sORoleBase;

    public void OnUpdate() {
        if (CheckGround()) {
            if (InputSystem.instance.KeyPressDown(KeyCode.Space)) {
                isJump = true;
            }
        }

        if (InputSystem.instance.MousePressDown(0)) {
            Debug.Log("开火");
            PerformFire();
        }
    }

    public void OnFixedUpdate() {
        //移动
        PerformMove();
        //相机视角
        PerformRotate();
        //跳跃
        PerformJump();
    }

    //设置移动方向
    public void SetMoveDir(Vector3 _moveDir) {
        moveDir = _moveDir;
    }

    //设置旋转方向
    public void SetRotateY(float _rotateX) {
        rotateX = _rotateX;
    }

    //设置相机视角方向
    public void SetCamRotateX(float _camRotateX) {
        camRotateX = _camRotateX;
    }


    //预演移动
    public void PerformMove() {
        if(controller == null) {
            return;
        }

        moveDir = transform.TransformDirection(moveDir);
        transform.position += new Vector3(moveDir.x, 0, moveDir.z) * moveSpeed * Time.deltaTime;
    }

    public bool isJump = false;
    public bool isGround = false;

    [Tooltip("跳跃速度")]
    public float jumpSpeed = 10;
    [Tooltip("跳跃时间")]
    public float jumpTime = 2f;
    private float jumpCurTime = 0f;

    private bool CheckGround() {
        Debug.DrawLine(transform.position, transform.position + new Vector3(0, -sORoleBase.roleGroundHeight, 0), Color.green);
        bool ret = Physics.Raycast(transform.position,transform.TransformDirection(Vector3.down),sORoleBase.roleGroundHeight, 1 << LayerMask.NameToLayer("Envirment") );
        return ret;
    }   

    //预演跳跃
    public void PerformJump() {
        if (!CheckGround()) {
            transform.position -= new Vector3(0, 9.8f,0) * Time.deltaTime;
        }
        
        if (isJump) {
            if(jumpCurTime < jumpTime) {
                transform.position += new Vector3(0, jumpSpeed, 0) * Time.deltaTime;
                jumpCurTime += Time.deltaTime;
            }else {
                jumpCurTime = 0;
                isJump = false;
            }
        }
    }

    private float currentCamRotateX = 0;

    //预演相机视角
    public void PerformRotate() {
        Vector3 rotateDir = new Vector3(0, rotateX, 0) * mouseSensitive * Time.deltaTime;
        transform.rotation = transform.rotation * Quaternion.Euler(rotateDir);
        if(cam != null) {
            currentCamRotateX -= camRotateX;
            currentCamRotateX = Mathf.Clamp(currentCamRotateX, -camRotateLimit, camRotateLimit);
            cam.transform.localEulerAngles = new Vector3(currentCamRotateX, 0, 0) * camSensitive * Time.deltaTime;
        }
    }

    //预演发射子弹
    public void PerformFire() {
        //创建子弹

        //发射子弹
    }

    public void CreateBullet() {

    }
}

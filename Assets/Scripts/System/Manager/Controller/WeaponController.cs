using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController{

    private Vector3 Muzzle;
    private MainSystem mainSystem;

    public void Init(MainSystem parent) {
        mainSystem = parent;
    }

    public void OnUpdate() {

    }

    public void Fire(){//射击
        if (InputSystem.instance.MousePressDown(0)) {
            if (Muzzle != null) {
                //获取弹药，设置弹药位置为枪口，获取目标位置 相机正前方500米，触发弹药行为发射。
            }
        }
    }
}

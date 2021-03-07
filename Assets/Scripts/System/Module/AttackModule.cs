using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackModule{

    public BulletManager bulletManager;
    public WeaponManager weaponManager;

    public MainSystem mainSystem;
    public void Init(MainSystem parent) {

        bulletManager = new BulletManager();
        weaponManager = new WeaponManager();

        bulletManager.Init(mainSystem);
        weaponManager.Init(mainSystem);
    }

    public void OnUpdate() {

    }
}

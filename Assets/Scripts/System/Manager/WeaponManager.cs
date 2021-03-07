using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager{
    public AttackModule attackModule;
    private WeaponController weaponController;
    private SOWeaponBase sOWeaponBase;

    public MainSystem mainSystem;
    public void Init(MainSystem parent) {
        this.mainSystem = parent;

        weaponController = new WeaponController();
        weaponController.Init(mainSystem);

        sOWeaponBase = (SOWeaponBase)LoadAssetManager.LoadAsset("Scriptables/SOWeaponBase", AssetType.Asset);
        CreateWeapon();
    }

    public void OnUpdate() {

    }

    public void CreateWeapon() {
        //初始化武器
        Weapon weapon = new Weapon();
        weapon.Init(sOWeaponBase);
        GameDataSystem.localWeapon = weapon;
    }
}

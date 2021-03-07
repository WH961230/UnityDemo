using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType{
    Melee,//近战
    Rifle,//步枪
    Pistol,//手枪
}

public class Weapon{
    string weaponName;//武器名称
    WeaponType weaponType;//武器类型
    BulletType bulletType;//弹药类型
    Vector3 muzzle;//枪口
    public GameObject weaponObj;
    public SOWeaponBase sOWeaponBase;

    public void Init(SOWeaponBase sOWeaponBase) {
        this.sOWeaponBase = sOWeaponBase;
        InitObject();
    }

    public GameObject InitObject() {//创建物体
        GameObject weapon = (GameObject)Object.Instantiate(LoadAssetManager.LoadAsset("Prefabs/WeaponAsset/Gun", AssetType.Prefab));//生成武器
        this.weaponObj = weapon;
        weapon.transform.SetParent(GameDataSystem.localRole.roleObj.transform.Find("Camera/WeaponPoint").transform);
        weapon.transform.localPosition = weapon.transform.position;
        weapon.transform.localRotation = weapon.transform.rotation;
        weapon.transform.localScale = weapon.transform.lossyScale;
        return weapon;
    }
}

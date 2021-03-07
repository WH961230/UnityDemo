using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOWeaponBase", menuName = "Weapon", order = 1)]

public class SOWeaponBase : ScriptableObject{
    public WeaponType weaponType;//武器类型
    public BulletType bulletType;//弹药类型
    public string weaponAssetPath;//武器路径
}

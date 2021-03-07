using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 角色配置
/// </summary>
[CreateAssetMenu(fileName = "SOBulletBase",menuName = "Bullet",order = 1)]
public class SOBulletBase : ScriptableObject{
    [Header("子弹类型")]
    [Tooltip("子弹类型")]
    public BulletType BulletType;
    [Header("子弹初始数量")]
    [Tooltip("子弹初始数量")]
    public int BulletInitNum;
}

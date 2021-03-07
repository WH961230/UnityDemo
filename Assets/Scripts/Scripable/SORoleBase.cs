using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 角色配置
/// </summary>
[CreateAssetMenu(fileName = "SORoleBase",menuName = "Role",order = 1)]
public class SORoleBase : ScriptableObject{
    [Header("角色模型")]
    [Tooltip("角色地面检测高度")]
    public float roleGroundHeight;

    [Header("角色属性")]
    [Tooltip("角色血量最大值")]
    public int maxHp;
}

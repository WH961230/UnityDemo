using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// 主系统
/// </summary>
public class MainSystem : MonoBehaviour{

    public EnvironmentSystem environmentSystem;
    public RoleSystem roleSystem;
    public AISystem aISystem;
    public EventSystem eventSystem;
    public FunctionSystem functionSystem;
    public UISystem uISystem;
    public InputSystem inputSystem;
    public GameDataSystem gameDataSystem;

    [SerializeField] public bool roleSystemSwitch = false;
    [SerializeField] public bool environmentSystemSwitch = false;

    private void Start(){
        InitializeSystem();
    }

    /// <summary>
    /// 初始化系统
    /// </summary>
    private void InitializeSystem(){
        CreateSystem();//创建系统
        InitSystem();//初始化系统
    }

    private void CreateSystem(){
        environmentSystem = new EnvironmentSystem();//环境
        roleSystem = new RoleSystem();//角色系统
        aISystem = new AISystem();//AI
        eventSystem = new EventSystem();//事件系统
        functionSystem = new FunctionSystem();//功能系统
        uISystem = new UISystem();//UI系统
        inputSystem = new InputSystem();//输入系统
        gameDataSystem = new GameDataSystem();//游戏数据系统
    }

    private void InitSystem(){
        environmentSystem.Init(this);
        roleSystem.Init(this);
        aISystem.Init(this);
        eventSystem.Init(this);
        functionSystem.Init(this);
        uISystem.Init(this);

        inputSystem.Init();
    }
    
    private void Update(){
        if (roleSystemSwitch){
            roleSystem.OnUpdate();
        }
    }

    private void FixedUpdate(){
        if (roleSystemSwitch){
            roleSystem.OnFixedUpdate();
        }
    }
}


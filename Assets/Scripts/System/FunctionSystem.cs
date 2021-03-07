using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionSystem{
    public AttackModule attackModule;
    public SurviveModule surviveModule;

    MainSystem mainSystem;
    public void Init(MainSystem parent){
        mainSystem = parent;

        attackModule = new AttackModule();
        surviveModule = new SurviveModule();

        attackModule.Init(mainSystem);
        surviveModule.Init(mainSystem);
    }

    public void OnUpdate(){
        
    }
}

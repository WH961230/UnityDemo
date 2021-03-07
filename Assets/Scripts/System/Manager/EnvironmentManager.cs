using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager{

    public List<Environment> environments = new List<Environment>();

    public EnvironmentController environmentController;
    public SOEnvironmentBase sOEnvironmentBase;

    public MainSystem mainSystem;

    public void Init(MainSystem parent){
        mainSystem = parent;

        sOEnvironmentBase = (SOEnvironmentBase)LoadAssetManager.LoadAsset("Scriptables/SOEnvironmentBase", AssetType.Asset);
        CreateEnvironment();
    }

    public void OnUpdate(){
        
    }

    public void CreateEnvironment() {
        Environment environment = new Environment();
        environment.Init(sOEnvironmentBase);
        environments.Add(environment);
    }
}

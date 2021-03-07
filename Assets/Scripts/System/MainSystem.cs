using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour{

    public EnvironmentSystem environmentSystem;
    public RoleSystem roleSystem;
    public AISystem aISystem;
    public EventSystem eventSystem;
    public FunctionSystem functionSystem;
    public UISystem uISystem;

    public InputSystem inputSystem;
    public GameDataSystem gameDataSystem;

    private void Start() {
        environmentSystem = new EnvironmentSystem();
        roleSystem = new RoleSystem();
        aISystem = new AISystem();
        eventSystem = new EventSystem();
        functionSystem = new FunctionSystem();
        uISystem = new UISystem();
        inputSystem = new InputSystem();
        gameDataSystem = new GameDataSystem();

        environmentSystem.Init(this);
        roleSystem.Init(this);
        aISystem.Init(this);
        eventSystem.Init(this);
        functionSystem.Init(this);
        uISystem.Init(this);

        inputSystem.Init();
    }

    private void Update() {
        
    }
}

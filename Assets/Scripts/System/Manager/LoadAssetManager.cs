using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum AssetType {
    Prefab,
    Asset
}
public class LoadAssetManager{
    public static Object LoadAsset(string assetName,AssetType type) {
        switch (type) {
            case AssetType.Prefab:
                return Resources.Load<GameObject>(assetName);
            case AssetType.Asset:
                return Resources.Load<ScriptableObject>(assetName) ;
        }
        return null;
    }
}

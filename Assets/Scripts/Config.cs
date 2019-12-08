using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Type;

public class Config : MonoBehaviour
{
    public Dictionary<FileType, GameObject> models = new Dictionary<FileType, GameObject>();

    void Awake()
    {
        models.Add(FileType.Any, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Any.prefab"));
        models.Add(FileType.Directory, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Directory.prefab"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

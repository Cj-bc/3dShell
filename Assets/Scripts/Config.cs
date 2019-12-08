using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Type;

public class Config : MonoBehaviour
{
    public Dictionary<FileType, GameObject> models = new Dictionary<FileType, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        models.Add(FileType.Any, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Any.prefab"));
        models.Add(FileType.Directory, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Directory.prefab"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

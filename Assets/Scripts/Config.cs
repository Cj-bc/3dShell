using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Type;

public class Config : MonoBehaviour
{
    public Dictionary<FileType, GameObject> models;

    // Start is called before the first frame update
    void Start()
    {
        models.Add(FileType.Any, PrefabUtility.LoadPrefabContents("Assets/Prefab/models/Any"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
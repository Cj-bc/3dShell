using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Type;

namespace ThreeDShell {
    public class Config : MonoBehaviour
    {
	public static Config Instance;
	public Dictionary<FileType, GameObject> models = new Dictionary<FileType, GameObject>();
	
	void Awake()
	{
	    if (Config.Instance != null) {
		Destroy(this);
		return;
	    }
	    Config.Instance = this;
	    
	    models.Add(FileType.Any, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Any.prefab"));
	    models.Add(FileType.Directory, PrefabUtility.LoadPrefabContents(Application.dataPath + "/Prefab/models/Directory.prefab"));
	}
	
	// Update is called once per frame
	void Update()
	{
	    
	}
    }
}

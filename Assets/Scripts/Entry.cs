using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

using Type;

namespace ThreeDShell {
    public class Entry<InfoType>: MonoBehaviour where InfoType : FileSystemInfo
    {
	public InfoType info; // Holds either 'DirectoryInfo' or 'FileInfo'
	public Type.FileType fileType;
	public GameObject model;
	
	protected Shell shell;
	
	public virtual void Initialize(InfoType info, Shell sh) {
	    this.info = info;
	    model = Config.Instance.models[Type.FileType.Any];
	    shell = sh;
	    
	    name = info.Name;
	    GetComponent<MeshRenderer>()?.material.SetColor(
		"_BaseColor",
		new Color(Random.value, Random.value, Random.value));
	    
	    var nameText = gameObject.GetComponentInChildren<Text>();
	    if (nameText != null)
		nameText.text = name;
	    
	}
	
	//public void OnDestroyAnimation
	//public void OnPwdChanged
	//public void OnCreateAnimation
	
	public virtual void OnClicked() {
	    Debug.Log($"Clicked!: {info.Name.ToString()}");
	}
    }
}

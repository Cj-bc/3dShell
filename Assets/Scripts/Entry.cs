using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using Type;

public class Entry<InfoType>: MonoBehaviour where InfoType : FileSystemInfo
{
    public InfoType info; // Holds either 'DirectoryInfo' or 'FileInfo'
    public Type.FileType fileType;
    public GameObject model;

    protected Config config;
    protected Shell shell;

    public virtual void Initialize(InfoType info, Config cfg, Shell sh) {
        this.info = info;
        config = cfg;
        model = cfg.models[Type.FileType.Any];
	shell = sh;

	name = info.Name;
	GetComponent<MeshRenderer>()?.material.SetColor(
	    "_BaseColor",
	    new Color(Random.value, Random.value, Random.value));
    }

    //public void OnDestroyAnimation
    //public void OnPwdChanged
    //public void OnCreateAnimation

    public virtual void OnClicked() {
		Debug.Log($"Clicked!: {info.Name.ToString()}");
    }
}

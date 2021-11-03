using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

using Type;

namespace ThreeDShell {
    public class Entry: MonoBehaviour
    {
	public string Name;
	public string URI;
	public Type.FileType fileType;
	public GameObject prefab;
	
	protected Shell shell;
	
	public virtual void Initialize(string _name, string uri
				      , Shell sh) {
	    Name = _name;
	    URI = uri;
	    Owner = owner;
	    fileType = Type.FileType.Any;
	    prefab = Config.Instance.models[fileType];
	    shell = sh;
	    
	    // Name of GameObject
	    gameObject.name = _name;
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

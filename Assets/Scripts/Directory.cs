using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Dir = System.IO.Directory;

namespace ThreeDShell {
    public class Directory : Entry<DirectoryInfo>
    {
	public List<GameObject> children;
	
	public void SpawnChildren() {
	    if (children.Count != 0)
		return;
	    
	    foreach(DirectoryInfo d in info.EnumerateDirectories()) {
		GameObject m = Instantiate(Config.Instance.models[Type.FileType.Directory]);
		m.GetComponent<Directory>().Initialize(d, shell);
		children.Add(m);
	    }
	    
	    
	    foreach(FileInfo i in info.EnumerateFiles()) {
		GameObject m = Instantiate(Config.Instance.models[Type.FileType.Any]);
		m.GetComponent<File>().Initialize(i, shell);
		children.Add(m);
	    }
	}
	
	public void RespawnChildren() {
	    KillChildren();
	    SpawnChildren();
	}
	
	public override void Initialize(DirectoryInfo info, Shell sh) {
	    base.Initialize(info, sh);
	    model = Config.Instance.models[Type.FileType.Directory];
	}
	
	public override void OnClicked() {
	    Debug.Log($"Now Move to {info.Name}");
	    shell.Cd(info);
	}
	
	public void KillChildren() {
	    // Kill all children here
	    foreach(GameObject m in children)
		Destroy(m);
	    
	}
	
	public void OnDestroy() {
		KillChildren();
	}
}

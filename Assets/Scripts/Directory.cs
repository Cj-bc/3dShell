using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Dir = System.IO.Directory;

public class Directory : Entry<DirectoryInfo>
{
	public List<GameObject> children;

    public void SpawnChildren() {
		if (children.Count != 0)
			return;
		
		foreach(DirectoryInfo d in info.EnumerateDirectories()) {
			GameObject m = Instantiate(config.models[Type.FileType.Directory]);
			m.GetComponent<Directory>().Initialize(d, config, shell);
			children.Add(m);
		}
		
		foreach(FileInfo i in info.EnumerateFiles()) {
			GameObject m = Instantiate(config.models[Type.FileType.Any]);
			m.GetComponent<File>().Initialize(i, config, shell);
			children.Add(m);
		}
    }

    public void RespawnChildren() {
		KillChildren();
		SpawnChildren();
    }

    public override void Initialize(DirectoryInfo info, Config cfg, Shell sh) {
		base.Initialize(info, cfg, sh);
		model = cfg.models[Type.FileType.Directory];
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Dir = System.IO.Directory;
using System;

public class Directory : Entry
{
    private List<Directory> childDirectories;
    private List<File> childFiles;
    public Directory(DirectoryInfo di, Config cfg): base (di, cfg) {
        model = cfg.models[Type.FileType.Directory];
    }

    public void SpawnChildren() {
		childDirectories = new List<Directory>();
		childFiles = new List<File>();
			
		foreach(DirectoryInfo d in ((DirectoryInfo)info).EnumerateDirectories()) {
			var child = new Directory(d, config, shell);
			child.Spawn();
			childDirectories.Add(child);
		}

		foreach(FileInfo i in ((DirectoryInfo)info).EnumerateFiles()) {
			var child = new File(i, config, shell);
			child.Spawn();
			childFiles.Add(child);
		}
    }

    public void forEachChild(Action<Entry> f) {
		if (childDirectories == null || childFiles == null)
			SpawnChildren();

        foreach(Directory d in childDirectories)
			f(d);

        foreach(File file in childFiles)
			f(file);
    }

}

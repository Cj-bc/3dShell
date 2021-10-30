using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Dir = System.IO.Directory;
using System;

public class Directory : Entry
{
    private List<Entry> children;
    public Directory(DirectoryInfo di, Config cfg): base (di, cfg) {
        model = cfg.models[Type.FileType.Directory];
    }

    public void SpawnChildren() {
      foreach(DirectoryInfo d in ((DirectoryInfo)info).EnumerateDirectories()) {
        var child = new Directory(d, config);
        child.Spawn();
        children.Add(child);
      }

      foreach(FileInfo i in ((DirectoryInfo)info).EnumerateFiles()) {
        var child = new File(i, config);
        child.Spawn();
        children.Add(child);
      }
    }

    public void forEachChild(Action<Entry> f) {
        foreach(DirectoryInfo d in ((DirectoryInfo)info).EnumerateDirectories())
          f(new Directory(d, config));

        foreach(FileInfo i in ((DirectoryInfo)info).EnumerateFiles())
          f(new File(i, config));
    }

}

using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using Type;

public class Entry
{
    public FileSystemInfo info; // Holds either 'DirectoryInfo' or 'FileInfo'
    public Type.FileType fileType;
    public GameObject model;

    protected Config config;

    public Entry(FileSystemInfo info, Config cfg) {
        this.info = info;
        config = cfg;
        model = cfg.models[Type.FileType.Any];
    }

    // public Entry(DirectoryInfo di, Config cfg) {
    //     info = di;
    //     fileType = Type.FileType.Directory;
    //     config = cfg;
    // }

    // Spawn GameObject
    public void Spawn() {
        GameObject m = Object.Instantiate(model);
        m.GetComponent<EntryHolder>().entry = this;
        m.name = info.Name;
    }


    //public void OnDestroyAnimation
    //public void OnPwdChanged
    //public void OnCreateAnimation
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dir = System.IO.Directory;
using Type;
using System.IO;
using System;

public class Shell : MonoBehaviour
{
    public Directory pwd;
    // User currentUser;
    RuntimePlatform os;

    public Config config;

    void Start()
    {
        config = GetComponent<Config>();
        // currentUser = System.Environment.UserName;
        pwd = new Directory(new DirectoryInfo(Environment.CurrentDirectory), config);
        UpdateEntryObjects();
    }

    void UpdateEntryObjects() {
        pwd.forEachChild((entry) => entry.Spawn());
    }

    void Cd(DirectoryInfo di) {
        if (!di.Exists)
          return;

        Dir.SetCurrentDirectory(di.FullName);
        UpdateEntryObjects();
    }
}

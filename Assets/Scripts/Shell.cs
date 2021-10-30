using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
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

    public UnityEvent OnPwdChanged;

    void Start()
    {
        config = GetComponent<Config>();
        // currentUser = System.Environment.UserName;
        pwd = new Directory(new DirectoryInfo(Environment.CurrentDirectory), config, this);
        UpdateEntryObjects();
	OnPwdChanged.AddListener(OnPwdChangedFunc);
    }

    void UpdateEntryObjects() {
        pwd.forEachChild((entry) => entry.Spawn());
    }

    public void Cd(DirectoryInfo di) {
        if (!di.Exists)
          return;

        Dir.SetCurrentDirectory(di.FullName);
	OnPwdChanged.Invoke();
        UpdateEntryObjects();
    }

    void OnPwdChangedFunc() {
	pwd = new Directory(new DirectoryInfo(Environment.CurrentDirectory), config, this);
    }
}

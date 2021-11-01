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
    private string InitialPwd;
    public Directory pwd;
    // User currentUser;
    RuntimePlatform os;

    void Start()
    {
	InitialPwd = Environment.CurrentDirectory;
        // currentUser = System.Environment.UserName;
	pwd = Instantiate(Config.Instance.models[Type.FileType.Directory]).GetComponent<Directory>();
        pwd.Initialize(new DirectoryInfo(Environment.CurrentDirectory), this);
	pwd.SpawnChildren();
    }

    public void Cd(DirectoryInfo di) {
        if (!di.Exists)
          return;

        Dir.SetCurrentDirectory(di.FullName);
	OnPwdChanged();
    }

    void OnPwdChanged() {
	Destroy(pwd.gameObject);
	pwd = Instantiate(Config.Instance.models[Type.FileType.Directory]).GetComponent<Directory>();
	pwd.Initialize(new DirectoryInfo(Environment.CurrentDirectory), this);
	pwd.SpawnChildren();
    }

    public void OnDestroy() {
	// Make sure to reset current working directory.
	// Otherwise UnityEditor will complain about this.
	Dir.SetCurrentDirectory(InitialPwd);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dir = System.IO.Directory;
using Type;

public class Shell : MonoBehaviour
{
    Directory pwd;
    List<GameObject> entries = new List<GameObject>();
    // User currentUser;
    RuntimePlatform os;

    Config config;

    void Awake()
    {
        config = FindObjectOfType<Config>();
        // currentUser = System.Environment.UserName;
        pwd = new Directory(Dir.GetCurrentDirectory(), config);
        updateEntryObjects();
    }

    void updateEntryObjects() {
        if (entries.Count != 0)
            foreach (GameObject obj in entries) {Destroy(obj);}

        foreach (Entry e in pwd.children()) {
            GameObject newObj = Instantiate(e.model);
            newObj.AddComponent<EntryHolder>();
            newObj.GetComponent<EntryHolder>().entry = e;
            entries.Add(newObj);
        }
    }
}

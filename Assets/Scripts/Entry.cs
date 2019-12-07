using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

using Type;

public class Entry : MonoBehaviour
{
    public string path;
    public string name;
    public Entry  parent;
    public int permission;
    public System.DateTime lastTouched;
    public GameObject model;

    public Entry(string _path) {
        path = _path;
        name = _path.Split('/').Last();
        parent = null;
        permission = 0b111000000; // TODO: get this from data
        lastTouched = System.DateTime.FromFileTime(0); // TODO: get this from data
        model = Config.Models[FileType.Normal];
    }
}

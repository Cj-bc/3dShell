using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

using Type;

public class Entry
{
    public string path;
    public string entryName;
    public Entry  parent;
    public int permission;
    public System.DateTime lastTouched;
    public GameObject model;

    protected Config config;

    public Entry() {
        path = "";
        entryName = "";
        parent = null;
        permission = 0;
        lastTouched = System.DateTime.FromFileTime(0);
        model = null;

        config = null;
    }

    public Entry(string _path, Config _config) {
        path = _path;
        entryName = _path.Split('/').Last();
        parent = null;
        permission = 0b111000000; // TODO: get this from data
        lastTouched = System.DateTime.FromFileTime(0); // TODO: get this from data
        model = _config.models[Type.FileType.Any];

        config = _config;
    }
}

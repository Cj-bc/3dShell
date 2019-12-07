using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : Entry
{
    public Type.FileType type;

    public File(string _path) : base (_path) {
        type = ftdetect();
    }

    private Type.FileType ftdetect() {
      return Type.FileType.Normal;
    }
}

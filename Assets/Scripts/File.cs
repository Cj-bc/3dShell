using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class File : Entry
{
    public File(FileInfo fi, Config cfg): base (fi, cfg) {
        fileType = ftdetect();
    }

    private Type.FileType ftdetect() {
      return Type.FileType.Any;
    }
}

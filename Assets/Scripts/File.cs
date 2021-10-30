using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class File : Entry
{
    public File(FileInfo fi, Config cfg, Shell sh): base (fi, cfg, sh) {
        fileType = ftdetect();
    }

    private Type.FileType ftdetect() {
      return Type.FileType.Any;
    }
}

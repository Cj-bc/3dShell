using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class File : Entry<FileInfo>
{
    public override void Initialize(FileInfo info, Config cfg, Shell sh) {
	base.Initialize(info, cfg, sh);
        fileType = ftdetect();
    }

    private Type.FileType ftdetect() {
      return Type.FileType.Any;
    }
}

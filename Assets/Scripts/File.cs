using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace ThreeDShell {
    public class File : Entry<FileInfo>
    {
	public override void Initialize(FileInfo info, Shell sh) {
	    base.Initialize(info, sh);
	    fileType = ftdetect();
	}
	
	private Type.FileType ftdetect() {
	    return Type.FileType.Any;
	}
    }
}

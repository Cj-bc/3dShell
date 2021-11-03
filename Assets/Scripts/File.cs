using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace ThreeDShell {
    public class File : Entry<FileInfo>
    {
	public override void Initialize(string _name, string uri
					, Shell sh) {
	    base.Initialize(_name, uri, sh);
	    fileType = ftdetect();
	}
	
	private Type.FileType ftdetect() {
	    return Type.FileType.Any;
	}
    }
}

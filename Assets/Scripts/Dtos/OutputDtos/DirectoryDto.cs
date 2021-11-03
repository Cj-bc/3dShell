using System.Collections.Generic;
namespace ThreeDShell {
    public class DirectoryDto: FSDto {
	public List<FSDto> Children { get; protected set; }

	public DirectoryData(string name, string uri,
			     User owner, FileType filetype,
			     List<FSDto> children) {
	    base(name, uri, owner, filetype);
	    Children = children;
	}
    }
}

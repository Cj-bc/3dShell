using System.Collections.Generic;
namespace ThreeDShell {
    public interface IThreeDShellFS {
	private DirectoryData InitialPwd;
	public DirectoryData Current { get; }
	public List<FSDto> Children { get; }

	public void RestoreInitialPwd();
	public void SetCurrentDirectory(DirectoryDto newPwd);
    }
}

// Repository data structure
public class FSDto {
    public string Name { get; protected set; }
    public string URI { get; protected set; }
    // public Permission Permission { get; protected set; }
    public User Owner { get; protected set; }
    public FileType FileType { get; protected set; }

    public FSDto(string name, string uri,
		  User owner, FileType filetype) {
	Name = name;
	URI = uri;
	Permission = permission;
	Owner = owner;
	FileType = filetype;
    }

}

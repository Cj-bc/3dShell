using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dir = System.IO.Directory;

public class Directory : Entry
{
    private List<Entry> _children = new List<Entry>();

    // Use this instead of _children so that 'stubbed' children are pulled
    public List<Entry> children() {
        if (_children.Count != 0)
            return _children;

        return getActualChildren();
    }

    private List<Entry> getActualChildren() {
        IEnumerable<string> files       = Dir.EnumerateFiles(path);
        IEnumerable<string> directories = Dir.EnumerateDirectories(path);
        List<Entry> ret = new List<Entry>();

        foreach (string f in files) { ret.Add(new File(f, config)); }
        foreach (string d in directories) { ret.Add(getDirectoryStub(d, config)); }

        return ret;
    }

    public Directory(string _path, Config _config) : base (_path, _config) {
            _children = this.getActualChildren();
        }

    // Create stub directory instance that doesn't hold children
    // This is required so that parent Directory holds only child dirs/files,
    // not grandchildren /great-grandchildren, ...
    public static Directory getDirectoryStub(string d, Config _config)  {
      return (Directory) (new Entry(d, _config));
    }
}

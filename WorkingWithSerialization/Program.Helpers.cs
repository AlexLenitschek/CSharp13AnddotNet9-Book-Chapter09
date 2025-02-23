#region Serializing as XML
partial class Program
{
    private static void SectionTitle(string title)
    {
        ConsoleColor previouscolor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine($"*** {title} ***");
        ForegroundColor = previouscolor;
    }

    private static void OutputFileInfo(string path)
    {
        WriteLine("**** File Info ****");
        WriteLine($"File: {GetFileName(path)}");
        WriteLine($"Path: {GetDirectoryName(path)}");
        WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
        WriteLine("/------------------");
        WriteLine(File.ReadAllText(path));
        WriteLine("------------------/");
    }
}

#endregion
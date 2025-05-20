namespace SimRacingManager.Miscellaneous;

public static class DotEnv
{
    public static bool SearchForEnvironmentFiles()
    {
        var root = Directory.GetCurrentDirectory();
        var envFiles = Directory.GetFiles(root, "*.env");
        var envFileName = "";
        
        if (envFiles.Length == 0)
        {
            Console.WriteLine("No Environment file found.");
            return false;
        }
        
        if (envFiles.Length > 1)
        {
            Console.WriteLine("Unable load more than one Environment file!");
            return false;
        }

        foreach (var envFile in envFiles)
        {
            envFileName = Path.GetFileName(envFile);
        }
        
        LoadEnvironmentFile(Path.Combine(root, envFileName));
        return true;
    }
    
    private static void LoadEnvironmentFile(string filePath)
    {
        if (!File.Exists(filePath))
            return;

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split("=", StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
                continue;
            
            Environment.SetEnvironmentVariable(parts[0], parts[1]);
        }
    }
}
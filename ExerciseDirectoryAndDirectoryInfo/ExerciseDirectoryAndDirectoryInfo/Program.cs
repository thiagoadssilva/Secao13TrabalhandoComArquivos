string path =  @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\ExerciseTrainingDirectoryAndDirectoryInfo";

try
{
    //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders");
    foreach (string folder in folders) {
        Console.WriteLine(folder);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files");
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + @"\thiagoNow");

}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}
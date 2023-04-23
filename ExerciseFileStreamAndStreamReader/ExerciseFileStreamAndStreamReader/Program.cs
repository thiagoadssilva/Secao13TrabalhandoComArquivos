string path = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\README.md";
//FileStream fs = null;
StreamReader sr = null;

try
{
    //fs = new FileStream(path, FileMode.Open);
    //sr = new StreamReader(fs);
    sr = File.OpenText(path);

    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
    //if (fs != null) fs.Close();
}
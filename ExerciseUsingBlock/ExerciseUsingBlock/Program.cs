string path = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\README.md";

try
{
    //using (FileStream fs = new FileStream(path, FileMode.Open))
    //{
        using (StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    //}
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}

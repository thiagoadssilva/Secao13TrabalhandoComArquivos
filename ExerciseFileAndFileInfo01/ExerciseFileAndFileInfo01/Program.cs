// Colocando o @ para poder colocar o caminho do arquivo sem a necessidade de colocar duas //
string sourcePath = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\README.md";
string targetPath = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\READMENew.md";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    //FileInfo fileInfo = new FileInfo(targetPath);
    //fileInfo.Delete();

    string[] lines = File.ReadAllLines(targetPath);

    foreach (string line in lines) {
        Console.WriteLine(line);
    }

}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
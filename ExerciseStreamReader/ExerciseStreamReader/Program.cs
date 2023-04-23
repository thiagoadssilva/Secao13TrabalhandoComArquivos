string sourcePath = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\README.md";
string targetPath = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\READMENew.md";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath)) {
        foreach (string line in lines) { 
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
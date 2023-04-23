﻿string path = @"C:\Users\thiag\OneDrive\Documentos\ProjetosGit\Secao13TrabalhandoComArquivos\arquivos.pdf";

Console.WriteLine("DirectorySeparatorChar -->> " + Path.DirectorySeparatorChar);
Console.WriteLine("PathSeparator -->> " + Path.PathSeparator);
Console.WriteLine("GetDirectoryName -->> " + Path.GetDirectoryName(path));
Console.WriteLine("GetFileName -->> " + Path.GetFileName(path));
Console.WriteLine("GetExtension -->> " + Path.GetExtension(path));
Console.WriteLine("GetFileNameWithoutExtension -->> " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetFullPath -->> " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath -->> " + Path.GetTempPath());


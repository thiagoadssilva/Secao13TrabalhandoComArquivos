# File e FileInfo

### Em C#, as classes File e FileInfo são usadas para trabalhar com arquivos. Ambas permitem que você execute operações de leitura e gravação em arquivos, mas existem algumas diferenças importantes entre elas.

### A classe File fornece métodos estáticos que permitem que você crie, leia, escreva e exclua arquivos. Esses métodos podem ser acessados diretamente a partir da classe sem a necessidade de criar uma instância dela. Por exemplo, File.WriteAllText escreve um texto em um arquivo, e File.Delete exclui um arquivo.

### Já a classe FileInfo fornece informações detalhadas sobre um arquivo específico, como nome, caminho, tamanho, data de criação, data de modificação, permissões, entre outros. Para usar esta classe, é necessário criar uma instância dela, passando o caminho do arquivo como parâmetro.

### A partir daí, você pode usar os métodos e propriedades para executar operações nesse arquivo específico.

    Um exemplo de uso da classe FileInfo é mostrado abaixo:

    FileInfo fileInfo = new FileInfo(@"C:\meuArquivo.txt");
    Console.WriteLine("Nome do arquivo: " + fileInfo.Name);
    Console.WriteLine("Caminho completo do arquivo: " + fileInfo.FullName);
    Console.WriteLine("Tamanho do arquivo: " + fileInfo.Length + " bytes");
    Console.WriteLine("Data de criação do arquivo: " + fileInfo.CreationTime);


    Já um exemplo de uso da classe File é mostrado abaixo:

    string caminhoArquivo = @"C:\meuArquivo.txt";
    File.WriteAllText(caminhoArquivo, "Conteúdo do arquivo.");
    string conteudo = File.ReadAllText(caminhoArquivo);
    Console.WriteLine(conteudo);

### Nesse exemplo, o método File.WriteAllText é usado para escrever o conteúdo "Conteúdo do arquivo." no arquivo "meuArquivo.txt". Em seguida, o método File.ReadAllText é usado para ler o conteúdo do arquivo e imprimir no console.

### Em resumo, File é usado para executar operações simples em arquivos, enquanto FileInfo é usado para obter informações detalhadas sobre um arquivo específico. Ambas são úteis e devem ser escolhidas de acordo com a necessidade do desenvolvedor.

<hr>

# FileStream e StreamReader

### Em C#, as classes FileStream e StreamReader são usadas para ler e escrever arquivos de forma mais avançada, permitindo o controle de bytes e caracteres em níveis mais baixos.

### A classe FileStream é usada para ler e gravar dados binários em um arquivo. Ela permite o controle total sobre o posicionamento do ponteiro de leitura/gravação dentro do arquivo, permitindo que você leia ou escreva em qualquer posição do arquivo. Além disso, ela permite especificar opções como compartilhamento de acesso, tamanho do buffer e opções de segurança.

    Um exemplo de uso da classe FileStream é mostrado abaixo:

    string caminhoArquivo = @"C:\meuArquivo.bin";
    byte[] dados = new byte[] { 1, 2, 3, 4, 5 };
    using (FileStream arquivo = new FileStream(caminhoArquivo, FileMode.Create))
    {
        arquivo.Write(dados, 0, dados.Length);
    }

### Nesse exemplo, um array de bytes dados é criado e, em seguida, a classe FileStream é usada para criar um novo arquivo chamado "meuArquivo.bin" no diretório raiz do disco C:. O método Write é usado para escrever os dados no arquivo.

### Já a classe StreamReader é usada para ler dados de um arquivo de texto. Ela permite que você leia um arquivo de texto linha por linha, ou até mesmo caractere por caractere. Além disso, ela oferece várias opções para controlar a codificação de caracteres, detecção automática de codificação e outros recursos.

    Um exemplo de uso da classe StreamReader é mostrado abaixo:

    string caminhoArquivo = @"C:\meuArquivo.txt";
    using (StreamReader arquivo = new StreamReader(caminhoArquivo))
    {
        string linha;
        while ((linha = arquivo.ReadLine()) != null)
        {
            Console.WriteLine(linha);
        }
    }

### Nesse exemplo, a classe StreamReader é usada para ler o arquivo "meuArquivo.txt" linha por linha, e o método ReadLine é usado para obter cada linha do arquivo e imprimir no console.

### Em resumo, FileStream é usado para ler e escrever dados binários em arquivos, enquanto StreamReader é usado para ler dados de um arquivo de texto. Ambas são úteis e devem ser escolhidas de acordo com a necessidade do desenvolvedor.

<hr>

# Using block

### O using block é uma construção da linguagem C# que é usada para garantir que um objeto que implementa a interface IDisposable seja liberado corretamente após o uso, independentemente de como o bloco de código é encerrado.

### A interface IDisposable é usada para permitir que os objetos liberem recursos não gerenciados, como conexões de banco de dados, arquivos abertos, sockets, etc. Esses recursos não são gerenciados pelo coletor de lixo do .NET Framework e, portanto, devem ser liberados explicitamente para evitar vazamentos de memória e outros problemas.

### O bloco using é usado para criar um escopo no qual o objeto IDisposable é usado. Quando o escopo é encerrado, o objeto é liberado automaticamente, mesmo se uma exceção for lançada. A sintaxe do bloco using é a seguinte:

    using (objeto)
    {
        // código que usa o objeto
    }

### Aqui, objeto é uma variável que implementa a interface IDisposable. Quando o escopo do bloco using é encerrado, o método Dispose do objeto é chamado automaticamente, o que libera os recursos não gerenciados.


    Um exemplo de uso do bloco using é mostrado abaixo:

    string caminhoArquivo = @"C:\meuArquivo.txt";
    using (FileStream arquivo = new FileStream(caminhoArquivo, FileMode.Create))
    {
        byte[] dados = new byte[] { 1, 2, 3, 4, 5 };
        arquivo.Write(dados, 0, dados.Length);
    }


### Nesse exemplo, o bloco using é usado com a classe FileStream, que implementa a interface IDisposable. O escopo do bloco using é definido pelas chaves { }. Dentro desse escopo, os dados são escritos no arquivo usando o método Write da classe FileStream. Quando o escopo é encerrado, o método Dispose é chamado automaticamente, o que libera os recursos não gerenciados.

### Em resumo, o bloco using é uma construção útil em C# para garantir que objetos IDisposable sejam liberados corretamente após o uso, evitando problemas de vazamento de memória e outros. Ele é usado em conjunto com a interface IDisposable para garantir a liberação de recursos não gerenciados.

<hr>

# Directory e DirectoryInfo


### Em C#, as classes Directory e DirectoryInfo são usadas para trabalhar com diretórios, permitindo que você crie, liste e remova diretórios e arquivos.

### A classe Directory fornece métodos estáticos para interagir com diretórios, enquanto a classe DirectoryInfo fornece uma interface orientada a objetos para manipulação de diretórios. Ambas as classes oferecem funcionalidades semelhantes, mas a classe DirectoryInfo é mais flexível, permitindo que você acesse informações adicionais sobre um diretório, como permissões, datas de criação e modificação, etc.

    Um exemplo de uso da classe Directory é mostrado abaixo:

    string caminhoDiretorio = @"C:\meuDiretorio";
    if (!Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);
    }

### Nesse exemplo, o método Directory.CreateDirectory é usado para criar um novo diretório chamado "meuDiretorio" no diretório raiz do disco C:. Antes de criar o diretório, o método Directory.Exists é usado para verificar se o diretório já existe.

    Já um exemplo de uso da classe DirectoryInfo é mostrado abaixo:


    string caminhoDiretorio = @"C:\meuDiretorio";
    DirectoryInfo infoDiretorio = new DirectoryInfo(caminhoDiretorio);
    Console.WriteLine(infoDiretorio.Name);
    Console.WriteLine(infoDiretorio.CreationTime);


### Nesse exemplo, um objeto DirectoryInfo é criado para representar o diretório "meuDiretorio". O nome do diretório e a data de criação são impressos no console usando as propriedades Name e CreationTime da classe DirectoryInfo.

### Em resumo, a classe Directory fornece métodos estáticos para interagir com diretórios, enquanto a classe DirectoryInfo fornece uma interface orientada a objetos para manipulação de diretórios. Ambas as classes são úteis e devem ser escolhidas de acordo com a necessidade do desenvolvedor.

<hr>

# Classe Path

### A classe Path em C# é usada para trabalhar com caminhos de arquivo e diretório, permitindo que você manipule caminhos, extraia informações de caminhos e combine caminhos para criar novos caminhos.

### A classe Path é estática e fornece métodos para várias operações comuns com caminhos de arquivo e diretório, como extrair o nome do arquivo de um caminho, extrair o nome do diretório pai, combinar caminhos, obter a extensão do arquivo e muito mais.

    Alguns exemplos de uso da classe Path são:

    string caminhoArquivo = @"C:\meuDiretorio\meuArquivo.txt";
    string nomeArquivo = Path.GetFileName(caminhoArquivo); // retorna "meuArquivo.txt"
    string extensaoArquivo = Path.GetExtension(caminhoArquivo); // retorna ".txt"
    string diretorioPai = Path.GetDirectoryName(caminhoArquivo); // retorna "C:\meuDiretorio"
    string novoCaminho = Path.Combine(diretorioPai, "novoArquivo.txt"); // retorna "C:\meuDiretorio\novoArquivo.txt"

### Nesse exemplo, o caminho do arquivo "C:\meuDiretorio\meuArquivo.txt" é usado para demonstrar alguns métodos da classe Path. O método GetFileName retorna apenas o nome do arquivo ("meuArquivo.txt"), enquanto o método GetExtension retorna apenas a extensão do arquivo (".txt"). O método GetDirectoryName retorna o nome do diretório pai ("C:\meuDiretorio") e o método Combine é usado para criar um novo caminho combinando o diretório pai com um novo nome de arquivo ("C:\meuDiretorio\novoArquivo.txt").

### A classe Path é muito útil para trabalhar com caminhos de arquivo e diretório de forma segura e portável em diferentes sistemas operacionais. É importante lembrar que a classe Path não trabalha com o sistema de arquivos diretamente, mas sim com strings que representam caminhos.

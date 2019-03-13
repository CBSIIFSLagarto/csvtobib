# Sobre o projeto

Ferramenta criada para converter o resultado de uma busca realizada no [IEEExplore](http://ieeexplore.ieee.org/) e que contém mais de 100 entradas.

## Atenção
A ferramenta foi criada com um exercício da disciplina de introdução ao dotnet (C#), desta forma não foram realizadas maiores implementações/validações.

# Como Usar
Para usar a ferramenta é necessário instalar o `dotnet core`. Uma vez instalado execute a `dll` na linha de comando 

`dotnet run csvToBib.dll arquivoOrigem.csv arquivoDestino.bib`

Sendo:

1. o primeiro parâmetro utilizado para obter o arquivo contendo os dados do csv obtido no site do IEEE;
2. o segundo parâmetro utilizado para escrever o arquivo contendo o  arquivo de saída. Caso não seja fornecido o arquivo será escrito no diretório onde foi executado com o nome de saida.bib.

# Agradecimentos / Referências

* [BibTeXLibrary](https://github.com/BERef/BibTeXLibrary)
* [CsvHelper](https://joshclose.github.io/CsvHelper/)

# Pendências

* [ ] Adicionar parser de linha de comandos;
* [ ] Ajustar as entradas bib para que fiquem de acordo com o tipo do evento e não `MISC`
* [ ] Refatorar o código para suportar mais de uma fonte de pesquisa;
* [ ] Suporte ao teste automatizado
* [ ] Adição a compilação automática
* [ ] Integrar com a [betterbib](https://github.com/nschloe/betterbib) para completar os dados ausentes no arquivo .bib

Veja mais nas Issues do [repositório].

# Contribuição

* Registre seu pedido/erro no nosso [repositório].
* Você também pode contribuir colaborando com novos templates, reportando erros ou sugerindo atualizações. 
  * Clone o [repositório] e crie seu *Pull request*.

[repositório]: https://github.com/CBSIIFSLagarto/csvtobib

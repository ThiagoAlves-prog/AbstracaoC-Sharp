using Atv_01;
using System.Security.Cryptography;

Livro l1 = new Livro("A sabedoria de Sêneca","Sêneca","Excelsior", 2022);
Livro l2 = new Livro("Kami Lendário", "Kamikat", "Caras e Zeras", 2017);
Livro l3 = new Livro("Pequeno Principe", "Saint-Exupéry", "HarperCollins Brasil", 1943 );


Console.WriteLine($"O primeiro livro é: {l1.Titulo} \n Do autor: {l1.Autor} \nLançado pela editora: {l1.Editora} \n No ano de: {l1.Ano} ");
Console.WriteLine($"\nO segundo livro é: {l2.Titulo} \n Do autor: {l2.Autor} \nLançado pela editora: {l2.Editora} \n No ano de: {l2.Ano} ");
Console.WriteLine($"\nO terceiro livro é: {l3.Titulo} \n Do autor: {l3.Autor} \nLançado pela editora: {l3.Editora} \n No ano de: {l3.Ano} ");


Console.ReadKey();
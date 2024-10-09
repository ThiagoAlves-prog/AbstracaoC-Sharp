using Atv_03;

Produto p1 = new Produto("A15B1", " Fita Isolante ", 5.00 , 12);
Produto p2 = new Produto("A16B2", " Bobina De Cobre ",78.50 , 500);
Produto p3 = new Produto("A17B3", " Imã ", 200.00, 200);





Console.WriteLine($"Código: {p1.Codigo} \n Produto: {p1.Nome} \n Valor: {p1.Preco}");
p1.qtndEstoque();


Console.WriteLine($"\nCódigo: {p2.Codigo} \n Produto: {p2.Nome} \n Valor: {p2.Preco}");
p2.qtndEstoque();


Console.WriteLine($"\nCódigo: {p3.Codigo} \n Produto: {p3.Nome} \n Valor: {p3.Preco}");
p3.qtndEstoque();

Console.ReadKey();
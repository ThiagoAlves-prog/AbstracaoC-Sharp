using Atv_02;

Aluno a1 = new Aluno (1796, "Cauã Leite Ferreira", new DateTime (2006, 09, 07), "Caua.ferreira@portalsesisp.org.br");
Aluno a2 = new Aluno(1983, "Thomas Corrêa", new DateTime (2007, 09, 18) , "Thomas.Correa@portalsesisp.org.br");
Aluno a3 = new Aluno(2490, "Victor Hugo De Jesus Dos Santos",new DateTime (2007, 07, 20) , "Vic.hugo@portalsesisp.org.br");


Console.WriteLine($"O RM: {a1.RM} \n Pertecence ao aluno: {a1.Nome} \nNascido em: {a1.Nascimento} \n Com o e-mail: {a1.Email} ");
Console.WriteLine($"\n O RM: {a2.RM} \n Pertecence ao aluno: {a2.Nome} \nNascido em: {a2.Nascimento} \n Com o e-mail: {a2.Email} ");
Console.WriteLine($"\n O RM: {a3.RM} \n Pertecence ao aluno: {a3.Nome} \nNascido em: {a3.Nascimento} \n Com o e-mail: {a3.Email} ");



Console.ReadKey();
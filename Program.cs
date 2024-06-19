Autor autor1 = new Autor ("Mauricio de Souza","Brasileiro");
Livro livro1 = new Livro ("Turma da Mônica", autor1, 100);

autor1.MostrarInfo();
livro1.MostrarInfo();

livro1.Desconto(10.00);
livro1.MostrarInfo();
livro1.Desconto(5);
livro1.MostrarInfo();
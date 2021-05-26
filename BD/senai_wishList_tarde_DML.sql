USE WishList;
GO

INSERT INTO usuarios(email, senha)
VALUES				('johnny@gmail.com', 'j123456'),
					('robert@gmail.com', 'r123456'),
					('fernando@gmail.com' ,'f123456'),
					('caique@gmail.com', 'c123456');
GO

INSERT INTO desejos(descricao, idUsuario)
VALUES			   ('Ganhar tanto dinheiro quanto o Caique', 1),
				   ('Ter vários dogs', 1),
				   ('Trabalhar no SENAI', 1),
				   ('Ter a sabedoria do Saulo', 2),
				   ('Comprar um carro', 2);
GO

INSERT INTO desejos(descricao, idUsuario)
VALUES			   ('Ter uma boa vida financeira', 4),
				   ('Comprar um pc top, preferencial RTX 3090', 4),
				   ('Morar no exterior', 4);
GO

INSERT INTO desejos(descricao, idUsuario)
VALUES			   ('Comprar uma casa', 3),
				   ('Ter um carro', 3);
GO
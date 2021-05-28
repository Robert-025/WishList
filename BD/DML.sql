USE WishList;

INSERT INTO usuarios(email, senha)
VALUES	('johnny@gmail.com', 'j123456'),
		('robert@gmail.com', 'r123456'),
		('fernando@gmail.com' ,'f123456'),
		('caique@gmail.com', 'c123456');	
GO

INSERT INTO desejos(descricao, idUsuario)
VALUES			   ('Ganhar tanto dinheiro quanto o Caique', 1),
				   ('Ter vários dogs', 1),
				   ('Trabalhar no SENAI', 1),
				   ('Ter a sabedoria do Saulo', 2),
				   ('Comprar um carro', 2),
				   ('Casar com minha namorada', 3),
				   ('Dar uma casa pra minha mãe', 3),
				   ('Ganhar na Mega-Sena', 3),
				   ('Ter uma boa vida financeira', 4),
				   ('Comprar um pc top, preferencial RTX 3090', 4),
				   ('Morar no exterior', 4);
GO
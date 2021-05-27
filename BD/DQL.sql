USE WishList;
GO

-- Mostra a tabela de usuarios
SELECT * FROM usuarios;

-- Mostra a tabela de desejos
SELECT * FROM desejos;

-- Verifica um usuário
SELECT * FROM usuarios U
WHERE U.email = 'robert@gmail.com' AND U.senha = 'r123456';
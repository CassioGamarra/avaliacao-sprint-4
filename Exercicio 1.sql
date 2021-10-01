-- 1 - Listar nome do dependente, idade do dependente, nome do cliente, idade do cliente para todos os clientes que possuam tp_cliente como 'FIDELIZADO'.
SELECT COALESCE(D.NOME, 'Não Possui') AS 'Nome Dependente', COALESCE(D.IDADE, 0) AS 'Idade', C.NOME AS 'Nome Cliente', C.IDADE AS 'Idade'
FROM CLIENTE C
    LEFT JOIN DEPENDENTE D ON C.ID = D.ID_CLIENTE
WHERE C.TP_CLIENTE = (SELECT TP.ID FROM TIPO_CLIENTE TP WHERE TP.DESCRICAO = 'FIDELIZADO');
-- 2 - Listar Nome e Id de todos os clientes que não possuam dependente.
SELECT C.NOME AS 'Nome', C.ID AS 'Id'
FROM CLIENTE C
WHERE C.ID NOT IN (
    SELECT D.ID_CLIENTE
    FROM DEPENDENTE D
);
-- 3 - Listar todos os dependentes que possuam um cliente que, em seu nome tenha a substring 'AR'. EX: Nesse caso seriam todos os dependentes da 'MARIA'.
SELECT D.NOME as 'Dependente', C.NOME AS 'Cliente'
FROM DEPENDENTE D
    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
WHERE C.NOME LIKE '%AR%';


/*Consultas SQL do exercício 'A volta dos que não foram'*/

/*SQL A*/
SELECT veiculo.placa, motorista.nome, motorista.cpf, motorista.idade
FROM ((viagem
INNER JOIN veiculo ON veiculo.veiculoid = viagem.veiculoid)
INNER JOIN motorista ON motorista.motoristaid = viagem.motoristaid)
WHERE viagem.viagemid = 2; 

/*SQL B*/
SELECT motorista.nome, motorista.cpf
FROM motorista
INNER JOIN viagem ON viagem.motoristaid = motorista.motoristaid
ORDER BY motorista.nome ASC; 

/*SQL C*/
SELECT motorista.nome
FROM ((viagem
INNER JOIN veiculo ON veiculo.veiculoid = viagem.veiculoid)
INNER JOIN motorista ON motorista.motoristaid = viagem.motoristaid)
WHERE veiculo.cor REGEXP '^V';
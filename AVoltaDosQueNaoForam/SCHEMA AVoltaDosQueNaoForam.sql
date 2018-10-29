create table viagem (
viagemid int primary key,
motoristaid int ,
veiculoid int 
);
INSERT INTO viagem ( viagemid, motoristaid, veiculoid) VALUES (1, 1, 1);
INSERT INTO viagem ( viagemid, motoristaid, veiculoid) VALUES (2, 3, 2);
INSERT INTO viagem ( viagemid, motoristaid, veiculoid) VALUES (3, 4, 3);
INSERT INTO viagem ( viagemid, motoristaid, veiculoid) VALUES (4, 2, 4);
INSERT INTO viagem ( viagemid, motoristaid, veiculoid) VALUES (5, 1, 2);


create table veiculo (
veiculoid int primary key,
placa varchar(255),
cor varchar(255)
);

INSERT INTO veiculo ( veiculoid, placa, cor) VALUES (1, 'QAD1234', 'Verde');
INSERT INTO veiculo ( veiculoid, placa, cor) VALUES (2, 'DED2341', 'Branco');
INSERT INTO veiculo ( veiculoid, placa, cor) VALUES (3, 'QAD4567', 'Branco');
INSERT INTO veiculo ( veiculoid, placa, cor) VALUES (4, 'DSD4213', 'Vermelho');

create table motorista (
motoristaid int primary key ,
nome varchar(255),
idade int,
cpf bigint,
celular bigint
);

INSERT INTO motorista ( motoristaid, nome, idade, cpf, celular ) values (1, 'Jossan', 26, 68045465042, 65999400521 );
INSERT INTO motorista ( motoristaid, nome, idade, cpf, celular ) values (2, 'Allan', 40, 08849949022, 65994562345 );
INSERT INTO motorista ( motoristaid, nome, idade, cpf, celular ) values (3, 'Luan', 30, 70204536006, 65994563456 );
INSERT INTO motorista ( motoristaid, nome, idade, cpf, celular ) values (4, 'Luciano', 33, 74465873000, 65987656574 );
INSERT INTO motorista ( motoristaid, nome, idade, cpf, celular ) values (5, 'Wagner', 32, 80834431076, 65986757875 );
create table if not exists cliente (
nome varchar(40) not null,
telefone varchar(11) not null,
email varchar(30) not null,
cpf int primary key not null 

);

create table if not exists OrdemDeServico(
data_abertura date not null,
data_fechamento date not null,
status_servico enum ('ABERTA', 'EM_ANDAMENTO', 'CONCLUIDA', 'CANCELADA'),

);

# WebCoreAP
Sistema da empresa AP - Arquitetura de Integração
Cenário de Estudo
Uma empresa do ramo de energia elétrica denominada Acme Producer (AP) tem um processo de negócio em comum onde é necessária uma integração entre seus sistemas.
O sistema da empresa AP produz as seguintes informações:
	Dados de cliente: CPF, nome, data de nascimento, endereço de cobrança;
	Dados de instalação: código da instalação, endereço da instalação;
	Dados de Fatura: código da fatura, código da instalação, CPF do cliente, data de vencimento, data de leitura, valor da leitura, valor da conta;
 
Todas as informações acima são disponibilizadas através de uma API Rest pela empresa AP. 
Os clientes da empresa AP precisam registrar as informações de suas contas de energia. Para tal, realiza uma integração com a empresa AP onde recupera as informações consumindo a API e importa para seu banco de dados para auditoria posterior.
Os serviços oferecidos pela empresa AP estão listados abaixo:
Cliente:
	Consultar a lista de clientes cadastrados;
	Consultar cliente cadastrado pelo seu CPF;
	Cadastrar um cliente.
Instalações
	Consultar a lista de instalações cadastradas;
	Consultar uma instalação pelo seu código;
	Consultar instalações de um cliente pelo CPF;
	Cadastrar uma instalação.
Faturas:
	Consultar a lista de faturas geradas;
	Consultar fatura cadastrado pelo seu código;
	Consultar faturas de um cliente pelo CPF;
	Gerar uma fatura.

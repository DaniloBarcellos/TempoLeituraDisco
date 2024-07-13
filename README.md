# Tempo de Leitura de Disco
## Contexto do Projeto
O projeto desse repositório foi desenvolvido para calcular o tempo de leitura
de um disco rígido. Conforme aprendi em aula, pode-se representar o disco por
uma tabela, contendo divisões horizontais e verticais.

[Imagem disco -> retângulo -> tabela]

A leitura do disco é realizada pelo braço e, no caso do projeto, considera-se
que o seu movimento é limitado, podendo se mover em apenas três direções 
(na tabela): *para cima*, *para baixo* e *para a direita*. 
Assim, considera-se que o disco rígido gira para apenas uma direção.

## O Problema
O braço de leitura pode estar em qualquer quadrado da tabela, e o quadrado
de destino pode ser qualquer um (exceto o que já está sendo ocupado pelo
braço). Assim, deve-se calcular o custo de tempo para se mover até o
destino, considerando as restrições acima. Para esse custo, considera-se
um peso para movimentos na vertical e outro para movimentos na horizontal.

Por exemplo:
[tabela 1]

[tabela 2]

Assim, por tentativa e erro, cheguei às seguintes fórmulas:


## O Programa
O programa contém apenas uma página, e nela, o usuário deve digitar a
*origem*, o *destino*, o número de *trilhas* (o número de colunas da
tabela), o *peso horizontal* (custo em uma unidade de tempo para esse
movimento) e *peso vertical* (custo em uma unidade de tempo para esse
movimento).

[Imagem]

O programa reconhece entradas incorretas e exibe uma mensagem alertando
o erro. 

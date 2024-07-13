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
![Tabuleiro](https://github.com/user-attachments/assets/98331430-c9f9-43a3-80da-e981c903b787)
Acabei representando essa tabela parecendo um tabuleiro, mas tudo bem. Ela possui 10 colunas e 4
linhas. Vamos considerar que o peso para movimentos horizontais é *2*, e para os verticais
é *3*.

Exemplo A:
![ExemploAMovimento](https://github.com/user-attachments/assets/935a9a3c-3645-47ec-92e9-5a9fd00cb5eb)
O moviemento incia no quadrado 1 e vai até o 27. São 6 movimentos na horizontal e 2 na vertical. Tem-se:
6x2 + 2x3 = 12 + 6 = 18.

Exemplo B:
![ExemploBMovimento](https://github.com/user-attachments/assets/fe4a10ab-6287-4ba8-9138-6deebe9b5aa4)
O movimento, agora, inicia-se no quadrado 36 e termina no 23. Como o movimento, na horizontal, só pode
ser para a direita e não para a esquerda, são 7 movimentos na horizontal e 1 na vertical. Tem-se:
7x2 + 1x3 = 14 + 3 = 17.

Assim, por tentativa e erro, cheguei nas fórmulas que estão na classe *Operacoes*.


## O Programa
O programa contém apenas uma página, e nela, o usuário deve digitar a
*origem*, o *destino*, o número de *trilhas* (o número de colunas da
tabela), o *peso horizontal* (custo em uma unidade de tempo para esse
movimento) e *peso vertical* (custo em uma unidade de tempo para esse
movimento).

[Imagem]

O programa reconhece entradas incorretas e exibe uma mensagem alertando
o erro. Os campos de entrada são limitados a 10 caracteres. E as restrições
são:
- Os valores de início e fim e o número de trilhas deve ser um inteiro positivo.
- Os valores para os pesos devem ser do tipo float, positivos.
- Os valores de início e fim devem ser diferentes.

[Imagens de erros]

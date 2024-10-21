Desafio: Diagnósticos - Submarino

Tecnologias envolvidas:
.Net Core 6
FluentAssertions
XUnit

Padrão de Projeto:
O projeto em questão foi desenvolvido utilizando o padrão arquitetural Clean Architecture.
A motivação para tal foi a simplicidade em separar o código desenvolvido em pequenas partes, fazendo-o fácil de se manutenir.

Na estrutura do projeto utilizamos as seguintes camadas:
Domain: Centralizando a lógica do negócio.
Application: Não se fez necessário nenhuma evolução nela pela simplicidade do contexto.
Infrastructure: Responsável pela separação da entrada de dados, que hoje é um arquivo, mas poderia ser uma fonte externa.
Presentation: Foi utilizado um Console App como interface da applicação.
Tests: Foram criados dois testes para o core da applicação sendo um caminho feliz e um alternativo

Algoritmos:
Para o core da solução foi utilizada uma matriz de 2 dimensões para armazenar cada uma das posições possíveis
do binário e, a partir disso, ao realizar um loop na matriz, cria-se os dois novos binários para utilização no
cálculo do consumo energético do submarino.
Por ser uma aplicação com um escopo simples, não se fez necessário a utilização de ID, mas poderia ser um ponto a ser evoluído, mas a ideia era manter a solução mais simples.

API disponível em: https://audaces-backend-test.herokuapp.com/

Projeto de avaliação para a vaga de Backend Developer na Audaces.

O applicativo consiste em uma API em C# e GraphQL, com front opcional em .NetCore Blazor.
A API, no endpoint "/api", recebe uma lista de números, chamada de Sequence, e um número alvo, chamado de Target, 
como no exemplo: { "Sequence": [5, 20, 2, 1], "Target": 47 }. A API então checa se é possível atingir o número alvo com uma combinação dos números da sequência e, se for possível, ela retorna a combinação.

A aplicação possui o(s) seguinte(s) endpoint(s):
mutation 
{
  combination
  (
    input:
    {
      target : 232,
      range : [11,111]
    }
  )
}
<ul>Para o envio dos números, retorna uma sequência com resultado da combinação, se existir</ul>
 </li>
</ol>
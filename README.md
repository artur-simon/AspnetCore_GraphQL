API disponível em: https://audaces-backend-test.herokuapp.com/

Projeto de avaliação para a vaga de Backend Developer na Audaces.

O applicativo consiste em uma API em C# e GraphQL, com front opcional em .NetCore Blazor.
A API, no endpoint "/api", recebe uma lista de números, chamada de Sequence, e um número alvo, chamado de Target, 
como no exemplo: { "range": [5, 20, 2, 1], "target": 47 }. A API então checa se é possível atingir o número alvo com uma combinação dos números da sequência e, se for possível, ela retorna a combinação.

<ol>A aplicação possui os seguintes endpoints:</ol>
 <li>combination</li>
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
<li>logs</li>
mutation{
  logs(
    input:{
      startDate :  "2021-04-15",
      endDate :  "2021-04-20"
    }
  )
  {
    type
    date
    
  }
}
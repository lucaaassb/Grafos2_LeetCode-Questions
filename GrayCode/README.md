# Gray Code 🔢

## Nome
Gray Code

## Descrição
Um algoritmo para gerar uma sequência numérica única onde números adjacentes diferem em apenas um bit binário.

## Funcionalidades
- Gerar sequências de código Gray para `n` bits
- Garantir que cada número apareça apenas uma vez
- Criar sequências onde números adjacentes diferem em um único bit
- Suporta geração para 1 a 16 bits

## Detalhes Técnicos
- Utiliza operações bit a bit para geração eficiente
- Implementa algoritmo de geração de código Gray
- Resolve o problema com complexidade O(2^n)
- Usa manipulação de bits para transformação

## Principais Métodos

### `GrayCode(int n)`
- **Objetivo:** Gerar sequência de código Gray para `n` bits
- **Parâmetros:**
    - `n`: Número de bits (1 ≤ n ≤ 16)
- **Retorno:**
    - Lista de inteiros representando sequência de código Gray
    - Cada número aparece uma única vez
function mostrarParcelas(preco, botao) {
    // Calcular o valor da parcela com uma taxa de juros fixa (5% ao mês)
    const taxaJuros = 0.05;  // Taxa de juros mensal
    function mostrarParcelas(preco, botao) {
        console.log('Função chamada!');  // Verifique se isso aparece no console do navegador

        const taxaJuros = 0.05;  // Taxa de juros mensal
        const numeroParcelas = 12; // Número de parcelas (12 meses)
        const valorParcela = (preco * (1 + taxaJuros)) / numeroParcelas;

        const divParcelas = botao.nextElementSibling;

        divParcelas.style.display = 'block';
        divParcelas.innerHTML = `Parcelas de R$ ${valorParcela.toFixed(2)} por mês.`;
    }

    console.log("Função mostrarParcelas foi chamada!");
}

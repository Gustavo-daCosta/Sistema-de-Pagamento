// Import de classes
using ClasseFuncionalidades;
using ClasseBoleto;
using CartaoCredito;
using CartaoDebito;

// Métodos principais
static int Menu(string titulo, string descricao) {
    menu:
    Funcionalidades.Titulo(titulo);
    Console.WriteLine(descricao);
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        Funcionalidades.Mensagem($"Opção inválida digitada! Tente novamente.");
        goto menu;
    }
    return opcao;
}

bool desejaContinuar = true;

// Instâncias das classes
Boleto boleto = new Boleto();

while (desejaContinuar) {
    int opcao = Menu(
        $"Sistema de pagamento",
        @$"
Selecione a forma de pagamento:

[1] - Boleto
[2] - Cartão

[0] - Sair do programa
    "
    );

    switch (opcao) {
        case 1:
            menuBoleto:
            int opcaoBoleto = Menu(
                $"Sistema de pagamento",
                @$"
Selecione uma opção:

[1] - Registrar novo boleto
[2] - Ver boletos registrados

[0] - Voltar ao menu
    ");
            if (opcaoBoleto == 1) {
                boleto.Registrar();
            } else if (opcaoBoleto == 2) {
                boleto.VerBoletos();
            } else {
                break;
            }
            goto menuBoleto;
        case 2:
            menuCartao:
            int opcaoCartao = Menu(
                $"Sistema de cartão",
                @$"
Selecione o tipo do cartão:

[1] - Pagar no Crédito
[2] - Pagar no Débito

[0] - Voltar ao menu
    "
            );
            if (opcaoCartao == 1) {
                Credito cartaoCredito = new Credito();

                // Definir limite do cartão de crédito
                cartaoCredito.DefinirLimite();
                // Pagar conta
                bool transacaoConcluida = cartaoCredito.Pagar();
                
                Funcionalidades.Mensagem(transacaoConcluida ? $"\nTransação concluída!" : $"Transação inválida! O valor da parcela é maior que o limite do cartão.", transacaoConcluida? ConsoleColor.Green : ConsoleColor.Red);

            } else if (opcaoCartao == 2) {
                Debito cartaoDebito = new Debito();

                // Definir saldo da conta
                cartaoDebito.DefinirSaldo();
                // Pagar conta
                bool transacaoConcluida = cartaoDebito.Pagar();

                Funcionalidades.Mensagem(transacaoConcluida ? $"\nTransação concluída!" : $"Transação inválida! Você não tem saldo suficiente na conta para concluir a transação.", transacaoConcluida? ConsoleColor.Green : ConsoleColor.Red);
            } else {
                break;
            }
            goto menuCartao;
        default:
            Funcionalidades.Mensagem($"Saindo do programa...");
            desejaContinuar = false;
            break;
    }
}

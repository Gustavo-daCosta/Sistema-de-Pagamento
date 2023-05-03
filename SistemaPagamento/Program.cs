// Import de classes
using GlobalVariables;
using ClasseFuncionalidades;
using ClasseBoleto;
using CartaoCredito;
using CartaoDebito;

// Métodos principais
static int Menu() {
    menu:
    Funcionalidades.Titulo($"Sistema de pagamento");
    Console.WriteLine(@$"
    Selecione a forma de pagamento:

    [1] - Boleto
    [2] - Cartão
    
    [0] - Sair do programa
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        Funcionalidades.Mensagem($"Opção inválida digitada! Tente novamente.");
        goto menu;
    }
    return opcao;
}

static int MenuBoleto() {
    menu:
    Funcionalidades.Titulo($"Sistema de cartão");
    Console.WriteLine(@$"
    Selecione o tipo do cartão:

    [1] - Registrar novo boleto
    [2] - Ver boletos registrados

    [0] - Voltar ao menu
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 0) {
        Menu();
    } else if (opcao != 1 && opcao != 2) {
        Funcionalidades.Mensagem($"Opção inválida digitada! Tente novamente.");
        goto menu;
    }
    return opcao;
}

static char MenuCartao() {
    menu:
    Funcionalidades.Titulo($"Sistema de cartão");
    Console.WriteLine(@$"
    Selecione o tipo do cartão:

    [1] - Crédito
    [2] - Débito

    [0] - Voltar ao menu
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 0) {
        Menu();
    } else if (opcao != 1 && opcao != 2) {
        Funcionalidades.Mensagem($"Opção inválida digitada! Tente novamente.");
        goto menu;
    }
    return opcao == 1 ? 'C' : 'D';
}

bool desejaContinuar = true;

// Instâncias das classes
Boleto boleto = new Boleto();

while (desejaContinuar) {
    int opcao = Menu();

    switch (opcao) {
        case 1:
            int opcaoBoleto = MenuBoleto();
            if (opcao == 1) {
                boleto.Registrar();
            } else {
                boleto.VerBoletos();
            }
            break;
        case 2:
            char opcaoCartao = MenuCartao();
            if (opcaoCartao == 'C') {
                Credito cartaoCredito = new Credito();
                cartaoCredito.Pagar();
            } else if (opcaoCartao == 'D') {
                Debito cartaoDebito = new Debito();
                cartaoDebito.Pagar();
            }
            break;
        default:
            Funcionalidades.Mensagem($"Saindo do programa...");
            Environment.Exit(1);
            break;
    }
}

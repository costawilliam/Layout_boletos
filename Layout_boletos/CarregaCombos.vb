Module CarregaCombos

    Public Sub observacoes()
        With Layout_boletos.obs
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preendha o formato para data e/ou hora. Ex.: dd/MM/aaaa HH:mm.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preendha o formato para data e/ou hora. Ex.: dd/MM/aaaa HH:mm.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Digite o texto que aparecerá fixo nas linhas do arquivo. Ex.: TEXTO FIXO.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a configuração com 0 (zeros a esquerda), E (alinhado a esquerda) ou D (alinhado a direita) para a quantidade de dígitos. Ex.: 000000.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
            .Add("Preencha a quantidade de caracteres para o campo. Ex.: 50.")
        End With
    End Sub



    Public Sub carregaCombosTipos()

        With Layout_boletos.tipo
            .Add("Banco - Nome do Banco")
            .Add("Banco - Número do Banco")
            .Add("Conta a Receber - Módulo 11 do Número")
            .Add("Conta a Receber - Número")
            .Add("Conta a Receber - Valor Decimal")
            .Add("Conta a Receber - Valor Inteiro")
            .Add("Conta a Receber - Vencimento Título")
            .Add("Conta Corrente - Agência")
            .Add("Conta Corrente - Agênca Dígito")
            .Add("Conta Corrente - Carteira")
            .Add("Conta Corrente - Código do Cedente")
            .Add("Conta Corrente - Código do Cedente Dígito")
            .Add("Conta Corrente - Instruções Boleto")
            .Add("Conta Corrente - Modalidade")
            .Add("Conta Corrente - Número Conta")
            .Add("Conta Corrente - Número Conta Dígito")
            .Add("Conta Corrente - Número do Convênio")
            .Add("Conta Corrente - Variação da Carteira")
            .Add("Empresa - Nome da Empresa Principal")
            .Add("Geral - Contador")
            .Add("Geral - Contador Detalhe")
            .Add("Geral - Data e Hora")
            .Add("Geral - Espaços")
            .Add("Geral - Lote Remesa")
            .Add("Geral - Quantidade do Lote")
            .Add("Geral - Quebra de Linha")
            .Add("Geral - Soma Total Decimal")
            .Add("Geral - Soma Total Inteiro")
            .Add("Geral - Texto Fixo")
            .Add("Geral - Total de Linhas")
            .Add("Pessoa - Agência")
            .Add("Pessoa - Agência Dígito")
            .Add("Pessoa - Bairro")
            .Add("Pessoa - CEP")
            .Add("Pessoa - Cidade")
            .Add("Pessoa - CPF")
            .Add("Pessoa - Endereço")
            .Add("Pessoa - Nº Ficha")
            .Add("Pessoa - Nome")
            .Add("Pessoa - Nome Banco")
            .Add("Pessoa - Número Banco")
            .Add("Pessoa - Número Conta")
            .Add("Pessoa - Número Conta Dígito")
            .Add("Pessoa - UF")
        End With
        Layout_boletos.cbTipo.DataSource = Layout_boletos.tipo
        Layout_boletos.cbTipo.SelectedIndex = 0
    End Sub

    Public Sub carregaCombosSecoes()

        With Layout_boletos.secoes
            .Add("Cabeçalho")
            .Add("Detalhe")
            .Add("Rodapé")
        End With

        Layout_boletos.cbSecao.DataSource = Layout_boletos.secoes
        Layout_boletos.cbSecao.SelectedIndex = 0
    End Sub
End Module

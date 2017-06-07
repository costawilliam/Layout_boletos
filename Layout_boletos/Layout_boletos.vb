Imports System
Imports System.IO
Imports System.Security
Imports System.Text
Public Class Layout_boletos

    Public arquivo As String
    Public path As String = Directory.GetCurrentDirectory()

    Public obs As New ArrayList
    Public tipo As New ArrayList()
    Public secoes As New ArrayList()

    Public itemAlterar_Global As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        observacoes()
        carregaCombosTipos()
        carregaCombosSecoes()
        lbQtCaracteres.Text = tbValor.TextLength
        tbLayout.Text = "Layout_Boletos"


        ListCampos.Scrollable = True
        ListCampos.View = View.Details

        Dim header = New ColumnHeader()
            header.Text = ""
            header.Name = "col1"
        ListCampos.Columns.Add(header)

        For Each col As ColumnHeader In ListCampos.Columns
            col.Width = 800
        Next




    End Sub

    Public Sub autoSave()
        arquivo = Directory.GetCurrentDirectory() + "\Layout_autosave.txt"
        Dim salvar = New IO.StreamWriter(arquivo, False, Encoding.ASCII)
        Dim texto As String
        Dim tamanho As Integer = ListCampos.Items.Count

        Try
            salvar.WriteLine(tbLayout.Text)
            salvar.WriteLine("0")
            For index As Integer = 0 To tamanho - 1
                texto = ListCampos.Items(index).Text
                salvar.WriteLine(texto)
            Next

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar automaticamente!" & vbCrLf & "   Verifique se o usuário possui permissões", "Erro ao salver", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        salvar.Close()
        salvar.Dispose()
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim a As String = ""
        If tbValor.TextLength = 0 Then
            MessageBox.Show("Preencha o valor corretamente", "Incluir item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            AdicionaItemLista()
            tbValor.Clear()
            'cbTipo.Focus()

            If ListCampos.Items.Count Mod 5 = 0 Then
                autoSave()
            End If
        End If
    End Sub

    Public Sub AdicionaItemLista()

        Dim item As String
        Try
            item = cbSecao.SelectedIndex.ToString + cbTipo.SelectedItem.ToString + "=" + tbValor.Text
            ListCampos.Items.Add(item)
        Catch ex As Exception
            MessageBox.Show("Nenhum item foi adicionar o item!!", "Erro ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        If MessageBox.Show("Deseja limpar o arquivo?", "Limpar arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            ListCampos.Items.Clear()
            tbLayout.Text = ""
        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim itemSelecionado As Integer
        Try
            itemSelecionado = ListCampos.SelectedIndices(0)
            ListCampos.Items.RemoveAt(itemSelecionado)
        Catch ex As Exception
            MessageBox.Show("Nenhum item foi selecionado para remoção!!", "Erro ao remover", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCima_Click(sender As Object, e As EventArgs) Handles btnCima.Click
        Dim valorAtual As String
        Dim valorNovo As String
        Dim itemAlterar As Integer
        Dim itemSelecionado As Integer

        Try
            itemSelecionado = ListCampos.SelectedIndices(0)
            itemAlterar = itemSelecionado - 1


            valorAtual = ListCampos.Items(itemAlterar).Text
            valorNovo = ListCampos.Items(itemSelecionado).Text

            ListCampos.Items(itemAlterar).Text = valorNovo
            ListCampos.Items(itemSelecionado).Text = valorAtual

            ListCampos.Items(itemSelecionado).Selected = False
            ListCampos.Items(itemAlterar).Selected = True
            ListCampos.Select()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub bntBaixo_Click(sender As Object, e As EventArgs) Handles bntBaixo.Click
        Dim valorAtual As String
        Dim valorNovo As String
        Dim itemAlterar As Integer
        Dim itemSelecionado As Integer

        Try
            itemSelecionado = ListCampos.SelectedIndices(0)
            itemAlterar = itemSelecionado + 1

            valorAtual = ListCampos.Items(itemAlterar).Text
            valorNovo = ListCampos.Items(itemSelecionado).Text

            ListCampos.Items(itemAlterar).Text = valorNovo
            ListCampos.Items(itemSelecionado).Text = valorAtual

            ListCampos.Items(itemSelecionado).Selected = False
            ListCampos.Items(itemAlterar).Selected = True
            ListCampos.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim tamanho As Integer = ListCampos.Items.Count
        Dim texto As String

        saveFileDialog1.Filter = "Documento de texto|*.txt"
        saveFileDialog1.Title = "Save a txt File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            arquivo = saveFileDialog1.FileName
            Dim salvar = New IO.StreamWriter(arquivo, False, Encoding.Default)

            Try
                salvar.WriteLine(tbLayout.Text)
                salvar.WriteLine("0")
                For index As Integer = 0 To tamanho - 1
                    texto = ListCampos.Items(index).Text
                    salvar.WriteLine(texto)
                Next
                MessageBox.Show("Arquivo salvo com êxito!")
            Catch ex As Exception
                MessageBox.Show("Não foi possível salvar o arquivo!" & vbCrLf & "   Verifique se o usuário possui permissões", "Erro ao salver", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            salvar.Close()
            salvar.Dispose()
        End If
    End Sub

    Private Sub tbValor_TextChanged(sender As Object, e As EventArgs) Handles tbValor.TextChanged
        lbQtCaracteres.Text = tbValor.TextLength
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        tbObs.Text = obs.Item(cbTipo.SelectedIndex)
    End Sub

    Private Sub ListCampos_Click(sender As Object, e As EventArgs) Handles ListCampos.Click

        Dim texto As String
        Dim valor As String()
        Dim separador() As Char = "="

        Try
            itemAlterar_Global = ListCampos.SelectedIndices(0)

            texto = ListCampos.Items(itemAlterar_Global).Text 'recebe o texto do item selecionado com o mouse
            cbSecao.SelectedIndex = CType(texto.Substring(0, 1), Integer) ' seleciona o item correto da combo seção

            'cria uma lista com o restante da string, sendo que na primeira posição será armazenado a OPÇÃO e na segunda o valor
            valor = texto.Split("=")

            'atribui o valor do campo selecionado ao valor do campo
            tbValor.Text = valor(1)

            Dim localizaArray As Integer
            For i = 0 To tipo.Count - 1
                If tipo(i) = valor(0).Substring(1) Then
                    localizaArray = i
                    Exit For
                End If
            Next

            cbTipo.SelectedIndex = localizaArray

        Catch ex As Exception

        End Try
    End Sub

    Public Sub alteraItem()
        Dim item As String
        Try
            item = cbSecao.SelectedIndex.ToString + cbTipo.SelectedItem.ToString + "=" + tbValor.Text
            ListCampos.Items(itemAlterar_Global).Text = item
        Catch ex As Exception
            MessageBox.Show("Nenhum item foi selecionado para alteração", "Alterar item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub





    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "Documento de texto|*.txt"
        openFileDialog1.Title = "Select a txt File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            arquivo = openFileDialog1.FileName

            Try
                ListCampos.Items.Clear()
                Dim importar As New IO.StreamReader(arquivo, Encoding.Default)
                Dim count As Integer = 0
                Dim texto As String

                While Not importar.EndOfStream
                    count = count + 1
                    If count = 1 Then
                        texto = importar.ReadLine
                        tbLayout.Text = texto
                    ElseIf count = 2 Then
                        texto = importar.ReadLine
                    Else
                        texto = importar.ReadLine
                        ListCampos.Items.Add(texto)
                        texto = ""
                    End If
                End While


                importar.Close()
                importar.Dispose()
            Catch ex As Exception
                MessageBox.Show("Não foi possível abrir o arquivo!" & vbCrLf & "   Verifique se o usuário possui permissões", "Erro ao importar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If tbValor.TextLength = 0 Then
            MessageBox.Show("Preencha o valor corretamente", "Incluir item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            alteraItem()
        End If

    End Sub






End Class

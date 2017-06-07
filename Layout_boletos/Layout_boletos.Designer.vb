<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Layout_boletos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Layout_boletos))
        Me.tbLayout = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnCima = New System.Windows.Forms.Button()
        Me.bntBaixo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.tbValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.cbSecao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbQtCaracteres = New System.Windows.Forms.Label()
        Me.tbObs = New System.Windows.Forms.TextBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.ListCampos = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'tbLayout
        '
        Me.tbLayout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLayout.Location = New System.Drawing.Point(104, 15)
        Me.tbLayout.Name = "tbLayout"
        Me.tbLayout.Size = New System.Drawing.Size(427, 20)
        Me.tbLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Layout"
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Location = New System.Drawing.Point(537, 12)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.Location = New System.Drawing.Point(537, 49)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 2
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.Location = New System.Drawing.Point(537, 78)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 3
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnCima
        '
        Me.btnCima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCima.Image = CType(resources.GetObject("btnCima.Image"), System.Drawing.Image)
        Me.btnCima.Location = New System.Drawing.Point(537, 107)
        Me.btnCima.Name = "btnCima"
        Me.btnCima.Size = New System.Drawing.Size(75, 23)
        Me.btnCima.TabIndex = 4
        Me.btnCima.UseVisualStyleBackColor = True
        '
        'bntBaixo
        '
        Me.bntBaixo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bntBaixo.Image = CType(resources.GetObject("bntBaixo.Image"), System.Drawing.Image)
        Me.bntBaixo.Location = New System.Drawing.Point(537, 136)
        Me.bntBaixo.Name = "bntBaixo"
        Me.bntBaixo.Size = New System.Drawing.Size(75, 23)
        Me.bntBaixo.TabIndex = 5
        Me.bntBaixo.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Location = New System.Drawing.Point(537, 279)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'tbValor
        '
        Me.tbValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbValor.Location = New System.Drawing.Point(288, 371)
        Me.tbValor.MaxLength = 100
        Me.tbValor.Name = "tbValor"
        Me.tbValor.Size = New System.Drawing.Size(243, 20)
        Me.tbValor.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(16, 371)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(252, 21)
        Me.cbTipo.TabIndex = 7
        '
        'btnIncluir
        '
        Me.btnIncluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIncluir.Location = New System.Drawing.Point(537, 396)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 23)
        Me.btnIncluir.TabIndex = 9
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'cbSecao
        '
        Me.cbSecao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSecao.FormattingEnabled = True
        Me.cbSecao.Items.AddRange(New Object() {"Cabeçalho", "Detalhe", "Rodapé"})
        Me.cbSecao.Location = New System.Drawing.Point(16, 323)
        Me.cbSecao.Name = "cbSecao"
        Me.cbSecao.Size = New System.Drawing.Size(252, 21)
        Me.cbSecao.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Seção:"
        '
        'lbQtCaracteres
        '
        Me.lbQtCaracteres.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbQtCaracteres.AutoSize = True
        Me.lbQtCaracteres.Location = New System.Drawing.Point(537, 375)
        Me.lbQtCaracteres.Name = "lbQtCaracteres"
        Me.lbQtCaracteres.Size = New System.Drawing.Size(73, 13)
        Me.lbQtCaracteres.TabIndex = 17
        Me.lbQtCaracteres.Text = "qtdCaracteres"
        '
        'tbObs
        '
        Me.tbObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbObs.Enabled = False
        Me.tbObs.Location = New System.Drawing.Point(16, 398)
        Me.tbObs.Multiline = True
        Me.tbObs.Name = "tbObs"
        Me.tbObs.ReadOnly = True
        Me.tbObs.Size = New System.Drawing.Size(515, 52)
        Me.tbObs.TabIndex = 18
        '
        'btnAlterar
        '
        Me.btnAlterar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAlterar.Location = New System.Drawing.Point(537, 427)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 19
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ListCampos
        '
        Me.ListCampos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListCampos.HideSelection = False
        Me.ListCampos.Location = New System.Drawing.Point(16, 41)
        Me.ListCampos.Name = "ListCampos"
        Me.ListCampos.Size = New System.Drawing.Size(515, 261)
        Me.ListCampos.TabIndex = 20
        Me.ListCampos.UseCompatibleStateImageBehavior = False
        Me.ListCampos.View = System.Windows.Forms.View.List
        '
        'Layout_boletos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 461)
        Me.Controls.Add(Me.ListCampos)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.tbObs)
        Me.Controls.Add(Me.lbQtCaracteres)
        Me.Controls.Add(Me.cbSecao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbValor)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.bntBaixo)
        Me.Controls.Add(Me.btnCima)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLayout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Layout_boletos"
        Me.Text = "Layout de Boletos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbLayout As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnCima As Button
    Friend WithEvents bntBaixo As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents tbValor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents cbSecao As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbQtCaracteres As Label
    Friend WithEvents tbObs As TextBox
    Friend WithEvents btnAlterar As Button
    Friend WithEvents ListCampos As ListView
End Class

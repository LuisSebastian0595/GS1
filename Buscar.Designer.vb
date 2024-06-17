<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        btnConsulta = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblCodigo = New Label()
        lbldesc = New Label()
        lblfecha = New Label()
        lblest = New Label()
        lblori = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(-1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 21)
        Label2.TabIndex = 5
        Label2.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(266, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 28)
        Label1.TabIndex = 4
        Label1.Text = "PRUEBA TÉCNICA GS1" & vbCrLf & "ADMINISTRACIÓN DE INVENTARIO" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 14)
        Label3.TabIndex = 6
        Label3.Text = "BUSCAR REGISTRO"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(179, 23)
        TextBox1.TabIndex = 7
        ' 
        ' btnConsulta
        ' 
        btnConsulta.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnConsulta.FlatAppearance.BorderColor = Color.Silver
        btnConsulta.FlatAppearance.MouseDownBackColor = Color.Gray
        btnConsulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnConsulta.FlatStyle = FlatStyle.Flat
        btnConsulta.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConsulta.Location = New Point(219, 90)
        btnConsulta.Name = "btnConsulta"
        btnConsulta.Size = New Size(100, 23)
        btnConsulta.TabIndex = 8
        btnConsulta.Text = "CONSULTAR"
        btnConsulta.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 14)
        Label4.TabIndex = 9
        Label4.Text = "Código de Activo"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 14)
        Label5.TabIndex = 10
        Label5.Text = "Descripción"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 14)
        Label6.TabIndex = 11
        Label6.Text = "Fecha de Ingreso"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 258)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 14)
        Label7.TabIndex = 12
        Label7.Text = "Estatus"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 14)
        Label8.TabIndex = 13
        Label8.Text = "Origen"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New Point(219, 136)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(41, 15)
        lblCodigo.TabIndex = 14
        lblCodigo.Text = "Label9"
        ' 
        ' lbldesc
        ' 
        lbldesc.AutoSize = True
        lbldesc.Location = New Point(219, 181)
        lbldesc.Name = "lbldesc"
        lbldesc.Size = New Size(47, 15)
        lbldesc.TabIndex = 15
        lbldesc.Text = "Label10"
        ' 
        ' lblfecha
        ' 
        lblfecha.AutoSize = True
        lblfecha.Location = New Point(219, 220)
        lblfecha.Name = "lblfecha"
        lblfecha.Size = New Size(47, 15)
        lblfecha.TabIndex = 16
        lblfecha.Text = "Label11"
        ' 
        ' lblest
        ' 
        lblest.AutoSize = True
        lblest.Location = New Point(219, 258)
        lblest.Name = "lblest"
        lblest.Size = New Size(47, 15)
        lblest.TabIndex = 17
        lblest.Text = "Label12"
        ' 
        ' lblori
        ' 
        lblori.AutoSize = True
        lblori.Location = New Point(219, 295)
        lblori.Name = "lblori"
        lblori.Size = New Size(47, 15)
        lblori.TabIndex = 18
        lblori.Text = "Label13"
        ' 
        ' Buscar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 450)
        Controls.Add(lblori)
        Controls.Add(lblest)
        Controls.Add(lblfecha)
        Controls.Add(lbldesc)
        Controls.Add(lblCodigo)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnConsulta)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Buscar"
        Text = "Buscar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConsulta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lbldesc As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblest As Label
    Friend WithEvents lblori As Label
End Class

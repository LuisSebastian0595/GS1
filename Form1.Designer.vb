<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        PanelCabecera = New Panel()
        Button1 = New Button()
        PanelMenu = New Panel()
        Button5 = New Button()
        btnAct = New Button()
        Button3 = New Button()
        btnNuevo = New Button()
        PictureBox1 = New PictureBox()
        btnMenu = New PictureBox()
        PanelContenedor = New Panel()
        timOcultarMenu = New Timer(components)
        timMostrarMenu = New Timer(components)
        PanelCabecera.SuspendLayout()
        PanelMenu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.MidnightBlue
        PanelCabecera.Controls.Add(Button1)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(0, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(800, 40)
        PanelCabecera.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Gray
        Button1.FlatAppearance.MouseOverBackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.Icono_cerrar_FN
        Button1.Location = New Point(757, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 40)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.DarkOrange
        PanelMenu.Controls.Add(Button5)
        PanelMenu.Controls.Add(btnAct)
        PanelMenu.Controls.Add(Button3)
        PanelMenu.Controls.Add(btnNuevo)
        PanelMenu.Controls.Add(PictureBox1)
        PanelMenu.Controls.Add(btnMenu)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(200, 410)
        PanelMenu.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Gray
        Button5.FlatAppearance.MouseOverBackColor = Color.DarkBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Image = My.Resources.Resources.producto
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(3, 251)
        Button5.Name = "Button5"
        Button5.Size = New Size(191, 40)
        Button5.TabIndex = 4
        Button5.Text = "Eliminar Registro"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btnAct
        ' 
        btnAct.FlatAppearance.BorderSize = 0
        btnAct.FlatAppearance.MouseDownBackColor = Color.Gray
        btnAct.FlatAppearance.MouseOverBackColor = Color.DarkBlue
        btnAct.FlatStyle = FlatStyle.Flat
        btnAct.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAct.Image = My.Resources.Resources.producto
        btnAct.ImageAlign = ContentAlignment.MiddleLeft
        btnAct.Location = New Point(3, 205)
        btnAct.Name = "btnAct"
        btnAct.Size = New Size(191, 40)
        btnAct.TabIndex = 3
        btnAct.Text = "Actualizar Registro"
        btnAct.TextAlign = ContentAlignment.MiddleRight
        btnAct.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Gray
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Image = My.Resources.Resources.producto
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(3, 159)
        Button3.Name = "Button3"
        Button3.Size = New Size(191, 40)
        Button3.TabIndex = 2
        Button3.Text = "Buscar Registro"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatAppearance.MouseDownBackColor = Color.Gray
        btnNuevo.FlatAppearance.MouseOverBackColor = Color.DarkBlue
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNuevo.Image = My.Resources.Resources.producto
        btnNuevo.ImageAlign = ContentAlignment.MiddleLeft
        btnNuevo.Location = New Point(3, 113)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 40)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo Registro"
        btnNuevo.TextAlign = ContentAlignment.MiddleRight
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.GS1_Guatemala
        PictureBox1.Location = New Point(3, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(97, 63)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnMenu
        ' 
        btnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMenu.Image = My.Resources.Resources.Mobile_Menu_Icon
        btnMenu.Location = New Point(151, 0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(49, 38)
        btnMenu.SizeMode = PictureBoxSizeMode.Zoom
        btnMenu.TabIndex = 0
        btnMenu.TabStop = False
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(200, 40)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(600, 410)
        PanelContenedor.TabIndex = 2
        ' 
        ' timOcultarMenu
        ' 
        ' 
        ' timMostrarMenu
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelMenu)
        Controls.Add(PanelCabecera)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "GS1 - INVENTARIO"
        PanelCabecera.ResumeLayout(False)
        PanelMenu.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMenu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents timOcultarMenu As Timer
    Friend WithEvents timMostrarMenu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnAct As Button
    Friend WithEvents Button3 As Button

End Class

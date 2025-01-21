<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarBBDD
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
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.DirectorLabel = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBDirector = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(82, 49)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(50, 13)
        Me.NombreLabel.TabIndex = 0
        Me.NombreLabel.Text = "Nombre: "
        '
        'DirectorLabel
        '
        Me.DirectorLabel.AutoSize = True
        Me.DirectorLabel.Location = New System.Drawing.Point(306, 49)
        Me.DirectorLabel.Name = "DirectorLabel"
        Me.DirectorLabel.Size = New System.Drawing.Size(50, 13)
        Me.DirectorLabel.TabIndex = 1
        Me.DirectorLabel.Text = "Director: "
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(138, 42)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 2
        '
        'TBDirector
        '
        Me.TBDirector.Location = New System.Drawing.Point(362, 42)
        Me.TBDirector.Name = "TBDirector"
        Me.TBDirector.Size = New System.Drawing.Size(100, 20)
        Me.TBDirector.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(529, 39)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'AgregarBBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TBDirector)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.DirectorLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "AgregarBBDD"
        Me.Text = "AgregarBBDD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreLabel As Label
    Friend WithEvents DirectorLabel As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBDirector As TextBox
    Friend WithEvents btnAgregar As Button
End Class

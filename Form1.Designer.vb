<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textresultado = New System.Windows.Forms.TextBox()
        Me.TextN2 = New System.Windows.Forms.TextBox()
        Me.TextN1 = New System.Windows.Forms.TextBox()
        Me.lnlresuldado = New System.Windows.Forms.Label()
        Me.Lnln2 = New System.Windows.Forms.Label()
        Me.Lnln1 = New System.Windows.Forms.Label()
        Me.Bntresta = New System.Windows.Forms.Button()
        Me.Mult = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnSUMA = New System.Windows.Forms.Button()
        Me.EJEMPLO = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 21
        '
        'Textresultado
        '
        Me.Textresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textresultado.Location = New System.Drawing.Point(479, 85)
        Me.Textresultado.Name = "Textresultado"
        Me.Textresultado.Size = New System.Drawing.Size(208, 30)
        Me.Textresultado.TabIndex = 20
        '
        'TextN2
        '
        Me.TextN2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextN2.Location = New System.Drawing.Point(237, 88)
        Me.TextN2.Name = "TextN2"
        Me.TextN2.Size = New System.Drawing.Size(145, 30)
        Me.TextN2.TabIndex = 19
        '
        'TextN1
        '
        Me.TextN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextN1.Location = New System.Drawing.Point(27, 85)
        Me.TextN1.Name = "TextN1"
        Me.TextN1.Size = New System.Drawing.Size(143, 30)
        Me.TextN1.TabIndex = 18
        '
        'lnlresuldado
        '
        Me.lnlresuldado.AutoSize = True
        Me.lnlresuldado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlresuldado.Location = New System.Drawing.Point(598, 38)
        Me.lnlresuldado.Name = "lnlresuldado"
        Me.lnlresuldado.Size = New System.Drawing.Size(55, 25)
        Me.lnlresuldado.TabIndex = 17
        Me.lnlresuldado.Text = "RES"
        '
        'Lnln2
        '
        Me.Lnln2.AutoSize = True
        Me.Lnln2.BackColor = System.Drawing.Color.White
        Me.Lnln2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnln2.ForeColor = System.Drawing.Color.Black
        Me.Lnln2.Location = New System.Drawing.Point(287, 38)
        Me.Lnln2.Name = "Lnln2"
        Me.Lnln2.Size = New System.Drawing.Size(39, 25)
        Me.Lnln2.TabIndex = 16
        Me.Lnln2.Text = "N2"
        '
        'Lnln1
        '
        Me.Lnln1.AutoSize = True
        Me.Lnln1.BackColor = System.Drawing.Color.White
        Me.Lnln1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnln1.ForeColor = System.Drawing.Color.Black
        Me.Lnln1.Location = New System.Drawing.Point(50, 38)
        Me.Lnln1.Name = "Lnln1"
        Me.Lnln1.Size = New System.Drawing.Size(39, 25)
        Me.Lnln1.TabIndex = 15
        Me.Lnln1.Text = "N1"
        '
        'Bntresta
        '
        Me.Bntresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bntresta.Location = New System.Drawing.Point(227, 153)
        Me.Bntresta.Name = "Bntresta"
        Me.Bntresta.Size = New System.Drawing.Size(155, 63)
        Me.Bntresta.TabIndex = 14
        Me.Bntresta.Text = "-"
        Me.Bntresta.UseVisualStyleBackColor = True
        '
        'Mult
        '
        Me.Mult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mult.Location = New System.Drawing.Point(29, 251)
        Me.Mult.Name = "Mult"
        Me.Mult.Size = New System.Drawing.Size(141, 63)
        Me.Mult.TabIndex = 13
        Me.Mult.Text = "*"
        Me.Mult.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndiv.Location = New System.Drawing.Point(227, 251)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(155, 63)
        Me.btndiv.TabIndex = 12
        Me.btndiv.Text = "/"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnSUMA
        '
        Me.btnSUMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSUMA.Location = New System.Drawing.Point(27, 162)
        Me.btnSUMA.Name = "btnSUMA"
        Me.btnSUMA.Size = New System.Drawing.Size(148, 63)
        Me.btnSUMA.TabIndex = 11
        Me.btnSUMA.Text = "+"
        Me.btnSUMA.UseVisualStyleBackColor = True
        '
        'EJEMPLO
        '
        Me.EJEMPLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EJEMPLO.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EJEMPLO.FormattingEnabled = True
        Me.EJEMPLO.ItemHeight = 23
        Me.EJEMPLO.Location = New System.Drawing.Point(466, 118)
        Me.EJEMPLO.Name = "EJEMPLO"
        Me.EJEMPLO.Size = New System.Drawing.Size(381, 303)
        Me.EJEMPLO.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(915, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 55)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Suma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(915, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 55)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Multiplicación"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(915, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 55)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Resta"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(915, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 55)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Divición"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(936, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Mini Prueba"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1105, 525)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EJEMPLO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textresultado)
        Me.Controls.Add(Me.TextN2)
        Me.Controls.Add(Me.TextN1)
        Me.Controls.Add(Me.lnlresuldado)
        Me.Controls.Add(Me.Lnln2)
        Me.Controls.Add(Me.Lnln1)
        Me.Controls.Add(Me.Bntresta)
        Me.Controls.Add(Me.Mult)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnSUMA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Textresultado As TextBox
    Friend WithEvents TextN2 As TextBox
    Friend WithEvents TextN1 As TextBox
    Friend WithEvents lnlresuldado As Label
    Friend WithEvents Lnln2 As Label
    Friend WithEvents Lnln1 As Label
    Friend WithEvents Bntresta As Button
    Friend WithEvents Mult As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnSUMA As Button
    Friend WithEvents EJEMPLO As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
End Class

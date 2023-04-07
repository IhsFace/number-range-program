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
        Label1 = New Label()
        Label2 = New Label()
        txtInputNbr = New TextBox()
        btnGo = New Button()
        Label3 = New Label()
        txtOutputResult = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(50, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 26)
        Label1.TabIndex = 0
        Label1.Text = "Number Range Identifier"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(50, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(399, 24)
        Label2.TabIndex = 1
        Label2.Text = "Enter a Whole Number to Determine its Range"' 
        ' txtInputNbr
        ' 
        txtInputNbr.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtInputNbr.Location = New Point(470, 75)
        txtInputNbr.Name = "txtInputNbr"
        txtInputNbr.Size = New Size(100, 29)
        txtInputNbr.TabIndex = 2
        ' 
        ' btnGo
        ' 
        btnGo.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnGo.Location = New Point(50, 150)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(60, 35)
        btnGo.TabIndex = 3
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(50, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 24)
        Label3.TabIndex = 4
        Label3.Text = "Range Result:"' 
        ' txtOutputResult
        ' 
        txtOutputResult.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtOutputResult.Location = New Point(200, 225)
        txtOutputResult.Name = "txtOutputResult"
        txtOutputResult.Size = New Size(370, 29)
        txtOutputResult.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(584, 361)
        Controls.Add(txtOutputResult)
        Controls.Add(Label3)
        Controls.Add(btnGo)
        Controls.Add(txtInputNbr)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Case Statement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputNbr As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOutputResult As TextBox
End Class

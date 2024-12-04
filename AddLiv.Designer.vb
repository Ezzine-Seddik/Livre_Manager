<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddLiv
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
        Label3 = New Label()
        BTN2 = New Button()
        BTN1 = New Button()
        TB1 = New TextBox()
        TB2 = New TextBox()
        TB3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' BTN2
        ' 
        BTN2.Location = New Point(466, 330)
        BTN2.Name = "BTN2"
        BTN2.Size = New Size(94, 29)
        BTN2.TabIndex = 3
        BTN2.Text = "Afficher"
        BTN2.UseVisualStyleBackColor = True
        ' 
        ' BTN1
        ' 
        BTN1.Location = New Point(247, 330)
        BTN1.Name = "BTN1"
        BTN1.Size = New Size(94, 29)
        BTN1.TabIndex = 4
        BTN1.Text = "Ajouter"
        BTN1.UseVisualStyleBackColor = True
        ' 
        ' TB1
        ' 
        TB1.Location = New Point(135, 58)
        TB1.Name = "TB1"
        TB1.Size = New Size(125, 27)
        TB1.TabIndex = 5
        ' 
        ' TB2
        ' 
        TB2.Location = New Point(135, 135)
        TB2.Name = "TB2"
        TB2.Size = New Size(125, 27)
        TB2.TabIndex = 6
        ' 
        ' TB3
        ' 
        TB3.Location = New Point(135, 222)
        TB3.Name = "TB3"
        TB3.Size = New Size(125, 27)
        TB3.TabIndex = 7
        ' 
        ' AddLiv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TB3)
        Controls.Add(TB2)
        Controls.Add(TB1)
        Controls.Add(BTN1)
        Controls.Add(BTN2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddLiv"
        Text = "Ajout Livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN2 As Button
    Friend WithEvents BTN1 As Button
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents TB3 As TextBox

End Class

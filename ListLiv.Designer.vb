<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListLiv
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
        LB1 = New ListBox()
        LB2 = New ListBox()
        LB3 = New ListBox()
        BTN = New Button()
        Label3 = New Label()
        Label2 = New Label()
        ISBN = New Label()
        SuspendLayout()
        ' 
        ' LB1
        ' 
        LB1.FormattingEnabled = True
        LB1.Location = New Point(83, 87)
        LB1.Name = "LB1"
        LB1.Size = New Size(150, 264)
        LB1.TabIndex = 13
        ' 
        ' LB2
        ' 
        LB2.FormattingEnabled = True
        LB2.Location = New Point(318, 87)
        LB2.Name = "LB2"
        LB2.Size = New Size(150, 264)
        LB2.TabIndex = 12
        ' 
        ' LB3
        ' 
        LB3.FormattingEnabled = True
        LB3.Location = New Point(568, 87)
        LB3.Name = "LB3"
        LB3.Size = New Size(150, 264)
        LB3.TabIndex = 11
        ' 
        ' BTN
        ' 
        BTN.Location = New Point(361, 389)
        BTN.Name = "BTN"
        BTN.Size = New Size(94, 29)
        BTN.TabIndex = 10
        BTN.Text = "ADD"
        BTN.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(611, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 9
        Label3.Text = "Auteur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(361, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 8
        Label2.Text = "Titre"
        ' 
        ' ISBN
        ' 
        ISBN.AutoSize = True
        ISBN.Location = New Point(124, 37)
        ISBN.Name = "ISBN"
        ISBN.Size = New Size(41, 20)
        ISBN.TabIndex = 7
        ISBN.Text = "ISBN"
        ' 
        ' ListLiv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LB1)
        Controls.Add(LB2)
        Controls.Add(LB3)
        Controls.Add(BTN)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ISBN)
        Name = "ListLiv"
        Text = "Liste des livres"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BTN As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ISBN As Label
    Friend WithEvents LB1 As ListBox
    Friend WithEvents LB2 As ListBox
    Friend WithEvents LB3 As ListBox

End Class

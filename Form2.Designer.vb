<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        Liste1ToolStripMenuItem = New ToolStripMenuItem()
        Liste2ToolStripMenuItem = New ToolStripMenuItem()
        AjoutToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {Liste1ToolStripMenuItem, Liste2ToolStripMenuItem, AjoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1184, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Liste1ToolStripMenuItem
        ' 
        Liste1ToolStripMenuItem.Name = "Liste1ToolStripMenuItem"
        Liste1ToolStripMenuItem.Size = New Size(61, 24)
        Liste1ToolStripMenuItem.Text = "Liste1"
        ' 
        ' Liste2ToolStripMenuItem
        ' 
        Liste2ToolStripMenuItem.Name = "Liste2ToolStripMenuItem"
        Liste2ToolStripMenuItem.Size = New Size(61, 24)
        Liste2ToolStripMenuItem.Text = "Liste2"
        ' 
        ' AjoutToolStripMenuItem
        ' 
        AjoutToolStripMenuItem.Name = "AjoutToolStripMenuItem"
        AjoutToolStripMenuItem.Size = New Size(59, 24)
        AjoutToolStripMenuItem.Text = "Ajout"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1184, 426)
        Panel1.TabIndex = 1
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 452)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Liste1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Liste2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class

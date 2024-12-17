<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List2
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
        DGV_Livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        Titre = New DataGridViewTextBoxColumn()
        Atuteur = New DataGridViewTextBoxColumn()
        CType(DGV_Livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV_Livre
        ' 
        DGV_Livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_Livre.Columns.AddRange(New DataGridViewColumn() {ISBN, Titre, Atuteur})
        DGV_Livre.Dock = DockStyle.Fill
        DGV_Livre.Location = New Point(0, 0)
        DGV_Livre.Name = "DGV_Livre"
        DGV_Livre.RowHeadersWidth = 51
        DGV_Livre.Size = New Size(800, 450)
        DGV_Livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "ISBN"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' Titre
        ' 
        Titre.HeaderText = "Titre"
        Titre.MinimumWidth = 6
        Titre.Name = "Titre"
        Titre.Width = 125
        ' 
        ' Atuteur
        ' 
        Atuteur.HeaderText = "Auteur"
        Atuteur.MinimumWidth = 6
        Atuteur.Name = "Atuteur"
        Atuteur.Width = 125
        ' 
        ' List2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DGV_Livre)
        Name = "List2"
        Text = "Form1"
        CType(DGV_Livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV_Livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Titre As DataGridViewTextBoxColumn
    Friend WithEvents Atuteur As DataGridViewTextBoxColumn
End Class

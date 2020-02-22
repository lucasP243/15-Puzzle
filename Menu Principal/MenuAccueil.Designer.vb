<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAccueil
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
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ComboBoxJoueurs = New System.Windows.Forms.ComboBox()
        Me.BoutonJouer = New System.Windows.Forms.Button()
        Me.BoutonQuitter = New System.Windows.Forms.Button()
        Me.BoutonScores = New System.Windows.Forms.Button()
        Me.BoutonParam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(9, 2)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(93, 13)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Entrez votre nom :"
        '
        'ComboBoxJoueurs
        '
        Me.ComboBoxJoueurs.FormattingEnabled = True
        Me.ComboBoxJoueurs.Location = New System.Drawing.Point(9, 19)
        Me.ComboBoxJoueurs.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxJoueurs.MaxLength = 20
        Me.ComboBoxJoueurs.Name = "ComboBoxJoueurs"
        Me.ComboBoxJoueurs.Size = New System.Drawing.Size(135, 21)
        Me.ComboBoxJoueurs.TabIndex = 1
        '
        'BoutonJouer
        '
        Me.BoutonJouer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BoutonJouer.Location = New System.Drawing.Point(148, 19)
        Me.BoutonJouer.Margin = New System.Windows.Forms.Padding(2)
        Me.BoutonJouer.Name = "BoutonJouer"
        Me.BoutonJouer.Size = New System.Drawing.Size(56, 20)
        Me.BoutonJouer.TabIndex = 2
        Me.BoutonJouer.Text = "Jouer"
        Me.BoutonJouer.UseVisualStyleBackColor = True
        '
        'BoutonQuitter
        '
        Me.BoutonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BoutonQuitter.Location = New System.Drawing.Point(208, 19)
        Me.BoutonQuitter.Margin = New System.Windows.Forms.Padding(2)
        Me.BoutonQuitter.Name = "BoutonQuitter"
        Me.BoutonQuitter.Size = New System.Drawing.Size(56, 20)
        Me.BoutonQuitter.TabIndex = 3
        Me.BoutonQuitter.Text = "Quitter"
        Me.BoutonQuitter.UseVisualStyleBackColor = True
        '
        'BoutonScores
        '
        Me.BoutonScores.Location = New System.Drawing.Point(12, 45)
        Me.BoutonScores.Name = "BoutonScores"
        Me.BoutonScores.Size = New System.Drawing.Size(132, 23)
        Me.BoutonScores.TabIndex = 4
        Me.BoutonScores.Text = "Table des scores"
        Me.BoutonScores.UseVisualStyleBackColor = True
        '
        'BoutonParam
        '
        Me.BoutonParam.Location = New System.Drawing.Point(150, 45)
        Me.BoutonParam.Name = "BoutonParam"
        Me.BoutonParam.Size = New System.Drawing.Size(114, 23)
        Me.BoutonParam.TabIndex = 5
        Me.BoutonParam.Text = "Paramètres"
        Me.BoutonParam.UseVisualStyleBackColor = True
        '
        'MenuAccueil
        '
        Me.AcceptButton = Me.BoutonJouer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BoutonQuitter
        Me.ClientSize = New System.Drawing.Size(276, 72)
        Me.ControlBox = False
        Me.Controls.Add(Me.BoutonParam)
        Me.Controls.Add(Me.BoutonScores)
        Me.Controls.Add(Me.BoutonQuitter)
        Me.Controls.Add(Me.BoutonJouer)
        Me.Controls.Add(Me.ComboBoxJoueurs)
        Me.Controls.Add(Me.LabelNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(292, 111)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(292, 111)
        Me.Name = "MenuAccueil"
        Me.Text = "Taquin - Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents ComboBoxJoueurs As ComboBox
    Friend WithEvents BoutonJouer As Button
    Friend WithEvents BoutonQuitter As Button
    Friend WithEvents BoutonScores As Button
    Friend WithEvents BoutonParam As Button
End Class

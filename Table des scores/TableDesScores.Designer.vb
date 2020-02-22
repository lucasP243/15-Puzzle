<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TableDesScores
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.LabelMeilleurTemps = New System.Windows.Forms.Label()
        Me.ComboBoxMeilleurTemps = New System.Windows.Forms.ComboBox()
        Me.LabelMeilleurTemps_ = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelNbParties = New System.Windows.Forms.Label()
        Me.LabelTempsTotal = New System.Windows.Forms.Label()
        Me.ButtonSupprimerJoueur = New System.Windows.Forms.Button()
        Me.ButtonSupprimerTousJoueurs = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.TextBoxTempsTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxNbParties = New System.Windows.Forms.TextBox()
        Me.BoutonAlpha = New System.Windows.Forms.Button()
        Me.BoutonMeilleurScore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(12, 9)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(35, 13)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom :"
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(53, 6)
        Me.ComboBoxNom.MaxLength = 20
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxNom.TabIndex = 1
        '
        'LabelMeilleurTemps
        '
        Me.LabelMeilleurTemps.AutoSize = True
        Me.LabelMeilleurTemps.Location = New System.Drawing.Point(215, 9)
        Me.LabelMeilleurTemps.Name = "LabelMeilleurTemps"
        Me.LabelMeilleurTemps.Size = New System.Drawing.Size(87, 13)
        Me.LabelMeilleurTemps.TabIndex = 2
        Me.LabelMeilleurTemps.Text = "Meilleur Temps : "
        '
        'ComboBoxMeilleurTemps
        '
        Me.ComboBoxMeilleurTemps.FormattingEnabled = True
        Me.ComboBoxMeilleurTemps.Location = New System.Drawing.Point(308, 6)
        Me.ComboBoxMeilleurTemps.Name = "ComboBoxMeilleurTemps"
        Me.ComboBoxMeilleurTemps.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxMeilleurTemps.TabIndex = 3
        '
        'LabelMeilleurTemps_
        '
        Me.LabelMeilleurTemps_.AutoSize = True
        Me.LabelMeilleurTemps_.Location = New System.Drawing.Point(370, 9)
        Me.LabelMeilleurTemps_.Name = "LabelMeilleurTemps_"
        Me.LabelMeilleurTemps_.Size = New System.Drawing.Size(53, 13)
        Me.LabelMeilleurTemps_.TabIndex = 4
        Me.LabelMeilleurTemps_.Text = "secondes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 10)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(12, 76)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(92, 13)
        Me.LabelDate.TabIndex = 6
        Me.LabelDate.Text = "Date de création :"
        '
        'LabelNbParties
        '
        Me.LabelNbParties.AutoSize = True
        Me.LabelNbParties.Location = New System.Drawing.Point(202, 101)
        Me.LabelNbParties.Name = "LabelNbParties"
        Me.LabelNbParties.Size = New System.Drawing.Size(133, 13)
        Me.LabelNbParties.TabIndex = 7
        Me.LabelNbParties.Text = "Nombre de parties jouées :"
        '
        'LabelTempsTotal
        '
        Me.LabelTempsTotal.AutoSize = True
        Me.LabelTempsTotal.Location = New System.Drawing.Point(202, 76)
        Me.LabelTempsTotal.Name = "LabelTempsTotal"
        Me.LabelTempsTotal.Size = New System.Drawing.Size(100, 13)
        Me.LabelTempsTotal.TabIndex = 8
        Me.LabelTempsTotal.Text = "Temps de jeu total :"
        '
        'ButtonSupprimerJoueur
        '
        Me.ButtonSupprimerJoueur.Location = New System.Drawing.Point(12, 101)
        Me.ButtonSupprimerJoueur.Name = "ButtonSupprimerJoueur"
        Me.ButtonSupprimerJoueur.Size = New System.Drawing.Size(162, 23)
        Me.ButtonSupprimerJoueur.TabIndex = 9
        Me.ButtonSupprimerJoueur.Text = "Supprimer le joueur"
        Me.ButtonSupprimerJoueur.UseVisualStyleBackColor = True
        '
        'ButtonSupprimerTousJoueurs
        '
        Me.ButtonSupprimerTousJoueurs.Location = New System.Drawing.Point(12, 130)
        Me.ButtonSupprimerTousJoueurs.Name = "ButtonSupprimerTousJoueurs"
        Me.ButtonSupprimerTousJoueurs.Size = New System.Drawing.Size(162, 23)
        Me.ButtonSupprimerTousJoueurs.TabIndex = 10
        Me.ButtonSupprimerTousJoueurs.Text = "Supprimer tous les joueurs"
        Me.ButtonSupprimerTousJoueurs.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(295, 130)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(127, 23)
        Me.ButtonMenu.TabIndex = 11
        Me.ButtonMenu.Text = "Retour au menu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'TextBoxTempsTotal
        '
        Me.TextBoxTempsTotal.Enabled = False
        Me.TextBoxTempsTotal.Location = New System.Drawing.Point(308, 73)
        Me.TextBoxTempsTotal.Name = "TextBoxTempsTotal"
        Me.TextBoxTempsTotal.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxTempsTotal.TabIndex = 12
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Enabled = False
        Me.TextBoxDate.Location = New System.Drawing.Point(110, 73)
        Me.TextBoxDate.MaxLength = 10
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxDate.TabIndex = 13
        '
        'TextBoxNbParties
        '
        Me.TextBoxNbParties.Enabled = False
        Me.TextBoxNbParties.Location = New System.Drawing.Point(341, 98)
        Me.TextBoxNbParties.Name = "TextBoxNbParties"
        Me.TextBoxNbParties.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxNbParties.TabIndex = 14
        '
        'BoutonAlpha
        '
        Me.BoutonAlpha.Location = New System.Drawing.Point(12, 33)
        Me.BoutonAlpha.Name = "BoutonAlpha"
        Me.BoutonAlpha.Size = New System.Drawing.Size(203, 23)
        Me.BoutonAlpha.TabIndex = 15
        Me.BoutonAlpha.Text = "Ordre Alphabétique"
        Me.BoutonAlpha.UseVisualStyleBackColor = True
        '
        'BoutonMeilleurScore
        '
        Me.BoutonMeilleurScore.Location = New System.Drawing.Point(221, 33)
        Me.BoutonMeilleurScore.Name = "BoutonMeilleurScore"
        Me.BoutonMeilleurScore.Size = New System.Drawing.Size(201, 23)
        Me.BoutonMeilleurScore.TabIndex = 16
        Me.BoutonMeilleurScore.Text = "Meilleur Score"
        Me.BoutonMeilleurScore.UseVisualStyleBackColor = True
        '
        'TableDesScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(434, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.BoutonMeilleurScore)
        Me.Controls.Add(Me.BoutonAlpha)
        Me.Controls.Add(Me.TextBoxNbParties)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxTempsTotal)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.ButtonSupprimerTousJoueurs)
        Me.Controls.Add(Me.ButtonSupprimerJoueur)
        Me.Controls.Add(Me.LabelTempsTotal)
        Me.Controls.Add(Me.LabelNbParties)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelMeilleurTemps_)
        Me.Controls.Add(Me.ComboBoxMeilleurTemps)
        Me.Controls.Add(Me.LabelMeilleurTemps)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabelNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TableDesScores"
        Me.Text = "TableDesScores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNom As Label
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents LabelMeilleurTemps As Label
    Friend WithEvents ComboBoxMeilleurTemps As ComboBox
    Friend WithEvents LabelMeilleurTemps_ As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelNbParties As Label
    Friend WithEvents LabelTempsTotal As Label
    Friend WithEvents ButtonSupprimerJoueur As Button
    Friend WithEvents ButtonSupprimerTousJoueurs As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents TextBoxTempsTotal As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents TextBoxNbParties As TextBox
    Friend WithEvents BoutonAlpha As Button
    Friend WithEvents BoutonMeilleurScore As Button
End Class

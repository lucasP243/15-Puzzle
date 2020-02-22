<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.GroupBoxJoueur = New System.Windows.Forms.GroupBox()
        Me.LabelMeilleurTemps_ = New System.Windows.Forms.Label()
        Me.LabelMeilleurTemps = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.GroupBoxTempsRestant = New System.Windows.Forms.GroupBox()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelTemps_ = New System.Windows.Forms.Label()
        Me.BoutonExit = New System.Windows.Forms.Button()
        Me.TimerJeu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTaquin = New System.Windows.Forms.Panel()
        Me.BoutonRésoudre = New System.Windows.Forms.Button()
        Me.GroupBoxJoueur.SuspendLayout()
        Me.GroupBoxTempsRestant.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxJoueur
        '
        Me.GroupBoxJoueur.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxJoueur.Controls.Add(Me.LabelMeilleurTemps_)
        Me.GroupBoxJoueur.Controls.Add(Me.LabelMeilleurTemps)
        Me.GroupBoxJoueur.Controls.Add(Me.LabelNom)
        Me.GroupBoxJoueur.Font = New System.Drawing.Font("Brush Script MT", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxJoueur.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxJoueur.Name = "GroupBoxJoueur"
        Me.GroupBoxJoueur.Size = New System.Drawing.Size(600, 71)
        Me.GroupBoxJoueur.TabIndex = 1
        Me.GroupBoxJoueur.TabStop = False
        Me.GroupBoxJoueur.Text = "Joueur :"
        '
        'LabelMeilleurTemps_
        '
        Me.LabelMeilleurTemps_.AutoSize = True
        Me.LabelMeilleurTemps_.Font = New System.Drawing.Font("Brush Script MT", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMeilleurTemps_.Location = New System.Drawing.Point(361, 29)
        Me.LabelMeilleurTemps_.Name = "LabelMeilleurTemps_"
        Me.LabelMeilleurTemps_.Size = New System.Drawing.Size(151, 26)
        Me.LabelMeilleurTemps_.TabIndex = 2
        Me.LabelMeilleurTemps_.Text = "Meilleur Temps :"
        '
        'LabelMeilleurTemps
        '
        Me.LabelMeilleurTemps.AutoSize = True
        Me.LabelMeilleurTemps.Location = New System.Drawing.Point(518, 24)
        Me.LabelMeilleurTemps.Name = "LabelMeilleurTemps"
        Me.LabelMeilleurTemps.Size = New System.Drawing.Size(54, 33)
        Me.LabelMeilleurTemps.TabIndex = 1
        Me.LabelMeilleurTemps.Text = "000"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Brush Script MT", 20.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(69, 24)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(286, 33)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "NomNomNomNomNomNomNo"
        Me.LabelNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxTempsRestant
        '
        Me.GroupBoxTempsRestant.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTempsRestant.Controls.Add(Me.LabelTemps)
        Me.GroupBoxTempsRestant.Controls.Add(Me.LabelTemps_)
        Me.GroupBoxTempsRestant.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTempsRestant.Location = New System.Drawing.Point(400, 90)
        Me.GroupBoxTempsRestant.Name = "GroupBoxTempsRestant"
        Me.GroupBoxTempsRestant.Size = New System.Drawing.Size(200, 271)
        Me.GroupBoxTempsRestant.TabIndex = 0
        Me.GroupBoxTempsRestant.TabStop = False
        Me.GroupBoxTempsRestant.Text = "Temps Restant :"
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps.Location = New System.Drawing.Point(70, 127)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(57, 39)
        Me.LabelTemps.TabIndex = 3
        Me.LabelTemps.Text = "XX"
        '
        'LabelTemps_
        '
        Me.LabelTemps_.AutoSize = True
        Me.LabelTemps_.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps_.Location = New System.Drawing.Point(46, 166)
        Me.LabelTemps_.Name = "LabelTemps_"
        Me.LabelTemps_.Size = New System.Drawing.Size(107, 39)
        Me.LabelTemps_.TabIndex = 4
        Me.LabelTemps_.Text = "secondes"
        '
        'BoutonExit
        '
        Me.BoutonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BoutonExit.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonExit.Location = New System.Drawing.Point(400, 421)
        Me.BoutonExit.Name = "BoutonExit"
        Me.BoutonExit.Size = New System.Drawing.Size(212, 48)
        Me.BoutonExit.TabIndex = 0
        Me.BoutonExit.Text = "Abandonner"
        Me.BoutonExit.UseVisualStyleBackColor = True
        '
        'TimerJeu
        '
        Me.TimerJeu.Enabled = True
        Me.TimerJeu.Interval = 1000
        '
        'PanelTaquin
        '
        Me.PanelTaquin.BackgroundImage = CType(resources.GetObject("PanelTaquin.BackgroundImage"), System.Drawing.Image)
        Me.PanelTaquin.Location = New System.Drawing.Point(12, 89)
        Me.PanelTaquin.Name = "PanelTaquin"
        Me.PanelTaquin.Size = New System.Drawing.Size(380, 380)
        Me.PanelTaquin.TabIndex = 2
        '
        'BoutonRésoudre
        '
        Me.BoutonRésoudre.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BoutonRésoudre.Font = New System.Drawing.Font("Brush Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoutonRésoudre.Location = New System.Drawing.Point(400, 367)
        Me.BoutonRésoudre.Name = "BoutonRésoudre"
        Me.BoutonRésoudre.Size = New System.Drawing.Size(212, 48)
        Me.BoutonRésoudre.TabIndex = 3
        Me.BoutonRésoudre.Text = "Résoudre"
        Me.BoutonRésoudre.UseVisualStyleBackColor = True
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.BoutonExit
        Me.ClientSize = New System.Drawing.Size(624, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.BoutonRésoudre)
        Me.Controls.Add(Me.PanelTaquin)
        Me.Controls.Add(Me.BoutonExit)
        Me.Controls.Add(Me.GroupBoxTempsRestant)
        Me.Controls.Add(Me.GroupBoxJoueur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 520)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 520)
        Me.Name = "Jeu"
        Me.Text = "Taquin"
        Me.GroupBoxJoueur.ResumeLayout(False)
        Me.GroupBoxJoueur.PerformLayout()
        Me.GroupBoxTempsRestant.ResumeLayout(False)
        Me.GroupBoxTempsRestant.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxJoueur As GroupBox
    Friend WithEvents GroupBoxTempsRestant As GroupBox
    Friend WithEvents BoutonExit As Button
    Friend WithEvents LabelMeilleurTemps As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelMeilleurTemps_ As Label
    Friend WithEvents TimerJeu As Timer
    Friend WithEvents PanelTaquin As Panel
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelTemps_ As Label
    Friend WithEvents BoutonRésoudre As Button
End Class

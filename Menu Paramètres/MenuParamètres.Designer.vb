<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuParamètres
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
        Me.BoutonValider = New System.Windows.Forms.Button()
        Me.BoutonAnnuler = New System.Windows.Forms.Button()
        Me.LabelTaille = New System.Windows.Forms.Label()
        Me.LabelTailleWarning = New System.Windows.Forms.Label()
        Me.savePathBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.TextBoxTemps = New System.Windows.Forms.TextBox()
        Me.LabelTaille_ = New System.Windows.Forms.Label()
        Me.TrackBarTaille = New System.Windows.Forms.TrackBar()
        Me.LabelTemps_ = New System.Windows.Forms.Label()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.BoutonParcourir = New System.Windows.Forms.Button()
        Me.LabelPath = New System.Windows.Forms.Label()
        CType(Me.TrackBarTaille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoutonValider
        '
        Me.BoutonValider.Location = New System.Drawing.Point(212, 122)
        Me.BoutonValider.Name = "BoutonValider"
        Me.BoutonValider.Size = New System.Drawing.Size(75, 23)
        Me.BoutonValider.TabIndex = 0
        Me.BoutonValider.Text = "Valider"
        Me.BoutonValider.UseVisualStyleBackColor = True
        '
        'BoutonAnnuler
        '
        Me.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BoutonAnnuler.Location = New System.Drawing.Point(293, 122)
        Me.BoutonAnnuler.Name = "BoutonAnnuler"
        Me.BoutonAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BoutonAnnuler.TabIndex = 1
        Me.BoutonAnnuler.Text = "Annuler"
        Me.BoutonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelTaille
        '
        Me.LabelTaille.AutoSize = True
        Me.LabelTaille.Location = New System.Drawing.Point(193, 12)
        Me.LabelTaille.Name = "LabelTaille"
        Me.LabelTaille.Size = New System.Drawing.Size(85, 13)
        Me.LabelTaille.TabIndex = 2
        Me.LabelTaille.Text = "Taille du taquin :"
        '
        'LabelTailleWarning
        '
        Me.LabelTailleWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTailleWarning.Location = New System.Drawing.Point(12, 102)
        Me.LabelTailleWarning.Name = "LabelTailleWarning"
        Me.LabelTailleWarning.Size = New System.Drawing.Size(194, 46)
        Me.LabelTailleWarning.TabIndex = 5
        Me.LabelTailleWarning.Text = "Attention : Le solveur ne sera pas utilisable pour des taquins d'une taille supér" &
    "ieure à 4x4"
        Me.LabelTailleWarning.Visible = False
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Location = New System.Drawing.Point(12, 9)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(87, 13)
        Me.LabelTemps.TabIndex = 7
        Me.LabelTemps.Text = "Temps accordé :"
        '
        'TextBoxTemps
        '
        Me.TextBoxTemps.Location = New System.Drawing.Point(103, 9)
        Me.TextBoxTemps.MaxLength = 3
        Me.TextBoxTemps.Name = "TextBoxTemps"
        Me.TextBoxTemps.Size = New System.Drawing.Size(58, 20)
        Me.TextBoxTemps.TabIndex = 0
        Me.TextBoxTemps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelTaille_
        '
        Me.LabelTaille_.AutoSize = True
        Me.LabelTaille_.Location = New System.Drawing.Point(284, 12)
        Me.LabelTaille_.Name = "LabelTaille_"
        Me.LabelTaille_.Size = New System.Drawing.Size(28, 13)
        Me.LabelTaille_.TabIndex = 8
        Me.LabelTaille_.Text = "taille"
        '
        'TrackBarTaille
        '
        Me.TrackBarTaille.LargeChange = 1
        Me.TrackBarTaille.Location = New System.Drawing.Point(323, 9)
        Me.TrackBarTaille.Maximum = 8
        Me.TrackBarTaille.Minimum = 3
        Me.TrackBarTaille.Name = "TrackBarTaille"
        Me.TrackBarTaille.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBarTaille.Size = New System.Drawing.Size(45, 107)
        Me.TrackBarTaille.TabIndex = 9
        Me.TrackBarTaille.Value = 4
        '
        'LabelTemps_
        '
        Me.LabelTemps_.AutoSize = True
        Me.LabelTemps_.Location = New System.Drawing.Point(159, 12)
        Me.LabelTemps_.Name = "LabelTemps_"
        Me.LabelTemps_.Size = New System.Drawing.Size(12, 13)
        Me.LabelTemps_.TabIndex = 10
        Me.LabelTemps_.Text = "s"
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Enabled = False
        Me.TextBoxPath.Location = New System.Drawing.Point(12, 67)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxPath.TabIndex = 11
        '
        'BoutonParcourir
        '
        Me.BoutonParcourir.Location = New System.Drawing.Point(212, 67)
        Me.BoutonParcourir.Name = "BoutonParcourir"
        Me.BoutonParcourir.Size = New System.Drawing.Size(75, 20)
        Me.BoutonParcourir.TabIndex = 12
        Me.BoutonParcourir.Text = "Parcourir"
        Me.BoutonParcourir.UseVisualStyleBackColor = True
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(12, 51)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(179, 13)
        Me.LabelPath.TabIndex = 13
        Me.LabelPath.Text = "Chemin de sauvegarde des joueurs :"
        '
        'MenuParamètres
        '
        Me.AcceptButton = Me.BoutonValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.CancelButton = Me.BoutonAnnuler
        Me.ClientSize = New System.Drawing.Size(380, 157)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.BoutonParcourir)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.LabelTemps_)
        Me.Controls.Add(Me.TrackBarTaille)
        Me.Controls.Add(Me.LabelTaille_)
        Me.Controls.Add(Me.TextBoxTemps)
        Me.Controls.Add(Me.LabelTemps)
        Me.Controls.Add(Me.LabelTailleWarning)
        Me.Controls.Add(Me.LabelTaille)
        Me.Controls.Add(Me.BoutonAnnuler)
        Me.Controls.Add(Me.BoutonValider)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MenuParamètres"
        Me.Text = "Paramètres"
        CType(Me.TrackBarTaille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BoutonValider As Button
    Friend WithEvents BoutonAnnuler As Button
    Friend WithEvents LabelTaille As Label
    Friend WithEvents LabelTailleWarning As Label
    Friend WithEvents savePathBrowser As FolderBrowserDialog
    Friend WithEvents LabelTemps As Label
    Friend WithEvents TextBoxTemps As TextBox
    Friend WithEvents LabelTaille_ As Label
    Friend WithEvents TrackBarTaille As TrackBar
    Friend WithEvents LabelTemps_ As Label
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents BoutonParcourir As Button
    Friend WithEvents LabelPath As Label
End Class

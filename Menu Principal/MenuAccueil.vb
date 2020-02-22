
Public Class MenuAccueil

    Private Sub MenuAccueil_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load, Me.VisibleChanged
        ComboBoxJoueurs.Items.Clear()
        ComboBoxJoueurs.Items.AddRange(GetJoueurs)
        ComboBoxJoueurs.Text = ""
    End Sub

    Private Sub BoutonJouer_Click(sender As Object, e As EventArgs) _
        Handles BoutonJouer.Click
        If Not String.IsNullOrEmpty(ComboBoxJoueurs.Text) Then
            If Not Existe(ComboBoxJoueurs.Text) Then
                AjouterJoueur(ComboBoxJoueurs.Text)
            End If
            Appli.GetJoueur(ComboBoxJoueurs.Text).Joue()
            Jeu.Show()
            Me.Hide()
        Else
            MsgBox("Veuillez saisir un nom",, "Ereur")
        End If
    End Sub
    Private Sub BoutonQuitter_Click(sender As Object, e As EventArgs) _
        Handles MyBase.FormClosing, BoutonQuitter.Click
        If MsgBox(
        "Voulez-vous vraiment quitter?",
        vbYesNo,
        "Quitter") = vbYes Then
            Sauvegarder()
            Environment.Exit(0)
        End If

    End Sub

    Private Sub BoutonScores_Click(sender As Object, e As EventArgs) _
        Handles BoutonScores.Click
        TableDesScores.Show()
        Hide()
    End Sub

    Private Sub BoutonParam_Click(sender As Object, e As EventArgs) _
        Handles BoutonParam.Click
        MenuParamètres.Show()
        Hide()
    End Sub

End Class
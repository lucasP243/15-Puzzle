Public Class TableDesScores

    Private joueur As Joueur
    Private Function MeilleursTemps(joueurs As Joueur()) As String()
        Dim temps As List(Of String) = New List(Of String)
        For Each j As Joueur In joueurs
            temps.Add(j.GetMeilleurTemps)
        Next
        Return temps.ToArray
    End Function
    Private Sub TableDesScores_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load, Me.VisibleChanged
        ComboBoxNom.Items.Clear()
        ComboBoxNom.Items.AddRange(GetJoueurs)
        ComboBoxMeilleurTemps.Items.Clear()
        ComboBoxMeilleurTemps.Items.AddRange(MeilleursTemps(GetJoueurs))

        ComboBoxNom.Text = Nothing
        ComboBoxMeilleurTemps.Text = Nothing
        TextBoxDate.Text = Nothing
        TextBoxTempsTotal.Text = Nothing
        TextBoxNbParties.Text = Nothing
    End Sub

    Private Sub AfficherJoueur()
        ComboBoxNom.Text = joueur.GetNom
        ComboBoxMeilleurTemps.Text = joueur.GetMeilleurTemps
        TextBoxDate.Text = joueur.GetDateCréation
        TextBoxNbParties.Text = joueur.GetNbPartiesJouées
        TextBoxTempsTotal.Text = joueur.GetTempsTotal
    End Sub

    Private Sub ComboBoxNom_SelectedValueChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxNom.SelectedValueChanged
        For Each j As Joueur In GetJoueurs()
            If j.GetNom().Equals(ComboBoxNom.Text) Then
                joueur = j
                AfficherJoueur()
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub ComboBoxMeilleurTemps_SelectedValueChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxMeilleurTemps.SelectedValueChanged
        For Each j As Joueur In GetJoueurs()
            If j.GetMeilleurTemps.ToString.Equals(ComboBoxMeilleurTemps.Text) Then
                joueur = j
                AfficherJoueur()
            Else
                Continue For
            End If
        Next
    End Sub

    Private Sub ButtonSupprimerJoueur_Click(sender As Object, e As EventArgs) _
        Handles ButtonSupprimerJoueur.Click
        If MsgBox(
                "Êtes-vous sûr de vouloir supprimer ce joueur?",
                vbYesNo,
                "Supprimer un joueur") = vbYes Then
            Remove(joueur.GetNom)
            TableDesScores_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub ButtonSupprimerTousJoueurs_Click(sender As Object, e As EventArgs) _
        Handles ButtonSupprimerTousJoueurs.Click
        If MsgBox(
                "Êtes-vous sûr de vouloir supprimer tous les joueurs?",
                vbYesNo,
                "Supprimer un joueur") = vbYes And
            MsgBox(
            "Veuillez confirmer une seconde fois votre demande",
            vbYesNo,
            "Confirmer") = vbYes Then

            Remove()
            ButtonMenu_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) _
        Handles ButtonMenu.Click
        MenuAccueil.Show()
        Hide()
    End Sub

    Private Sub Sort(sender As Object, e As EventArgs) _
        Handles BoutonAlpha.Click, BoutonMeilleurScore.Click
        If sender.Equals(BoutonAlpha) Then
            ComboBoxNom.Sorted = True
        ElseIf sender.Equals(BoutonMeilleurScore) Then
            With ComboBoxMeilleurTemps
                Dim scores As Integer() =
                New Integer(.Items.Count - 1) {}
                For i = 0 To (.Items.Count - 1)
                    scores(i) = Integer.Parse(.Items(i))
                Next
                Array.Sort(scores)
                Dim scores_ As String() =
                New String(.Items.Count - 1) {}
                For i = 0 To (.Items.Count - 1)
                    scores_(i) = scores(i).ToString
                Next
                .Items.Clear()
                .Items.AddRange(scores_)
            End With
        End If
    End Sub
End Class
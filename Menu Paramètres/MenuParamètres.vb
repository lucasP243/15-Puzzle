Public Class MenuParamètres

    Private Sub MenuParamètres_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        TrackBarTaille.Value = GetTaille()
        LabelTaille_.Text = TrackBarTaille.Value & "x" & TrackBarTaille.Value
        TextBoxTemps.Text = GetTempsAccordé()
        TextBoxPath.Text = GetPath()
        LabelTailleWarning.Visible = Integer.Parse(TrackBarTaille.Value) > 4
    End Sub

    Private Sub TrackBarTaille_ValueChanged(sender As Object, e As EventArgs) _
        Handles TrackBarTaille.ValueChanged
        LabelTaille_.Text = TrackBarTaille.Value & "x" & TrackBarTaille.Value
        LabelTailleWarning.Visible = Integer.Parse(TrackBarTaille.Value) > 4
    End Sub

    Private Sub BoutonParcourir_Click(sender As Object, e As EventArgs) _
        Handles BoutonParcourir.Click
        Dim browser As FolderBrowserDialog = New FolderBrowserDialog()
        If browser.ShowDialog = DialogResult.OK Then
            TextBoxPath.Text = browser.SelectedPath
        End If
    End Sub

    Private Sub Valider(sender As Object, e As EventArgs) _
        Handles BoutonValider.Click
        SetTaille(TrackBarTaille.Value)
        SetTemps(Integer.Parse(TextBoxTemps.Text))
        SetPath(TextBoxPath.Text)
        Quitter(Nothing, Nothing)
    End Sub
    Private Sub Quitter(sender As Object, e As EventArgs) _
        Handles BoutonAnnuler.Click
        MenuAccueil.Show()
        Hide()
    End Sub
End Class
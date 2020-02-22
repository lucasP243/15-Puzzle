Public Class Jeu

    Dim boutons As Button(,)

    Private Sub Jeu_Load() Handles MyBase.Load
        LabelNom.Text = Taquin.GetJoueur.GetNom
        LabelMeilleurTemps.Text = Taquin.GetJoueur.GetMeilleurTemps & "'"

        PanelTaquin.Controls.Clear()
        boutons = New Button(GetTaille() - 1, GetTaille() - 1) {}
        Dim origin As Point = PanelTaquin.Location,
            offset As Integer = 10, totalSize As Integer = 360
        For i As Integer = 0 To GetTaille() - 1
            For j As Integer = 0 To GetTaille() - 1
                boutons(i, j) = New Button With {
                    .Font = New Font(
                    "Brush Script MT",
                    26 - GetTaille(),
                    FontStyle.Bold,
                    GraphicsUnit.Point,
                    0),
                    .Location = New Point(
                    offset + (j * totalSize / GetTaille()),
                    offset + (i * totalSize / GetTaille())),
                    .Size = New Size(
                    width:=totalSize / GetTaille(),
                    height:=totalSize / GetTaille()),
                    .Visible = True,
                    .Name = i & "_" & j
                }
                PanelTaquin.Controls.Add(boutons(i, j))
                AddHandler boutons(i, j).Click, AddressOf BoutonTaquin_Click
            Next
        Next
        InitialiserTaquin()
        ActualiserAffichage()

        If GetTaille() > 4 Then
            BoutonRésoudre.Enabled = False
        End If

        LabelTemps.Text = GetTempsRestant()
        Visible = True
        Refresh()
        Initialiser()
    End Sub

    Private Sub Initialiser()
        Dim N As Integer = 25 * GetTaille() ' Nombre de mouvements au mélange
        MélangerTaquin(N)

        TimerJeu.Start()
        Enabled = True

    End Sub

    Private Sub TimerJeu_Tick(sender As Object, e As EventArgs) _
        Handles TimerJeu.Tick
        DécrémTemps()
        LabelTemps.Text = GetTempsRestant()
        If (GetTempsRestant() = 0) Then
            FinDePartie(False)
        End If
    End Sub

    Private Sub BoutonTaquin_Click(sender As Button, e As EventArgs)
        Dim x, y As Integer
        x = sender.Name.Split("_")(0)
        y = sender.Name.Split("_")(1)
        Déplacer(x, y)
        If (EstRésolu()) Then
            FinDePartie(True)
        End If
    End Sub



    Private Sub FinDePartie(aGagné As Boolean)
        TimerJeu.Stop()
        Taquin.GetJoueur.SubmitTemps(
            GetTempsAccordé() - GetTempsRestant(),
            aGagné)

        If (aGagné) Then
            Dim msg As String =
                "Vous avez gagné cette partie !" _
                & Environment.NewLine _
                & "Temps : " _
                & (GetTempsAccordé() - GetTempsRestant()) _
                & "s" _
                & Environment.NewLine _
                & "Meilleur temps : " _
                & Taquin.GetJoueur.GetMeilleurTemps _
                & "s"
            MsgBox(msg, MsgBoxStyle.Information, "Gagné!")
        Else
            MsgBox("Vous avez perdu !", MsgBoxStyle.Critical, "Perdu!")
        End If
        MenuAccueil.Show()
        Close()
    End Sub

    Public Sub ActualiserAffichage()
        For Each b As Button In boutons
            Dim x, y As Integer
            x = b.Name.Split("_")(0)
            y = b.Name.Split("_")(1)
            b.Visible = Not GetTab(x, y) = 0
            b.Text = GetTab(x, y)
        Next
        PanelTaquin.Refresh()
    End Sub

    Private Sub BoutonExit_Click(sender As Object, e As EventArgs) _
        Handles BoutonExit.Click
        TimerJeu.Stop()
        If MsgBox(
                "Voulez-vous vraiment abandonner la partie en cours?",
                MsgBoxStyle.YesNo,
                "Abandon") = MsgBoxResult.Yes Then
            FinDePartie(False)
        Else
            TimerJeu.Start()
        End If
    End Sub

    Private Sub BoutonRésoudre_Click(sender As Object, e As EventArgs) _
        Handles BoutonRésoudre.Click
        TimerJeu.Stop()
        If MsgBox("Êtes-vous sûr de vouloir résoudre le taquin? " &
                  "Ce processus peut prendre un certain temps, " &
                  "et la victoire ne vous sera pas comptée.",
                    MsgBoxStyle.YesNo, "Résoudre") = vbYes Then
            Enabled = False
            Résoudre()
            FinDePartie(False)
        Else
            TimerJeu.Start()
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Console.WriteLine(keyData)
        If keyData = Keys.Down Then
            Déplacer("NORD")
            Return True
        ElseIf keyData = Keys.Left Then
            Déplacer("EST")
            Return True
        ElseIf keyData = Keys.Right Then
            Déplacer("OUEST")
            Return True
        ElseIf keyData = Keys.Up Then
            Déplacer("SUD")
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function
End Class
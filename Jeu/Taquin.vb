Public Module Taquin

    ' Attributs et procédures réglés par le formulaire "Paramètres"
    Private taille As Integer, tempsAccordé As Integer

    ' Getters et Setters des paramètres
    Sub SetTaille(taille As Integer)
        Taquin.taille = taille
    End Sub
    Sub SetTemps(temps As Integer)
        Taquin.tempsAccordé = temps
    End Sub

    Function GetTaille() As Integer
        Return taille
    End Function
    Function GetTempsAccordé() As Integer
        Return tempsAccordé
    End Function


    ' Attributs représentant la partie en cours
    Private tab As Integer(,)
    Private joueur As Joueur
    Private posVide As Integer()
    Private tempsRestant As Integer

    ' Getter et Setter de joueur
    Sub SetJoueur(joueur As Joueur)
        Taquin.joueur = joueur
    End Sub
    Function GetJoueur() As Joueur
        Return joueur
    End Function

    'Getter de tab aux coordonnées demandées
    Function GetTab(x As Integer, y As Integer) As Integer
        Return tab(x, y)
    End Function

    'Getter et décrémenteur de tempsRestant
    Function GetTempsRestant() As Integer
        Return tempsRestant
    End Function
    Sub DécrémTemps()
        tempsRestant -= 1
    End Sub

    ' Sub InitialiserTaquin
    ' Initialise un taquin résolu et le mélange en N mouvements
    Public Sub InitialiserTaquin()
        posVide = New Integer(1) _
            {taille - 1, taille - 1}
        tempsRestant = tempsAccordé

        tab = New Integer(taille - 1, taille - 1) {}
        For i As Integer = 0 To taille - 1
            For j As Integer = 0 To taille - 1
                tab(i, j) = ((i * taille) + j + 1) Mod (taille * taille)
            Next
        Next
    End Sub
    Public Sub MélangerTaquin(N As Integer)
        Dim r As New Random()
        Dim directions As String() = {"NORD", "EST", "OUEST", "SUD"}
        For i As Integer = 0 To N
            Déplacer(directions(r.Next(directions.Length)))
            Threading.Thread.Sleep(10)
        Next
    End Sub

    Public Function EstRésolu() As Boolean
        For i = 0 To taille - 2
            For j = 0 To taille - 2
                If Not ((tab(i, j) + 1 = tab(i, j + 1) Or
                    tab(i, j) + 1 = tab(i, j + 1) + taille) And
                    (tab(i, j) + taille = tab(i + 1, j) Or
                    (tab(i, j) Mod taille = 0 And tab(i + 1, j) = 0))) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    ' Sub Déplacer
    ' Déplacer la case aux coordonnées (x, y) si elle est adjacente à la vide
    ' Déplace la case vide dans la direction demandée
    Sub Déplacer(x As Integer, y As Integer)

        If posVide(0) > 0 And x = posVide(0) - 1 And y = posVide(1) Then ' NORD
            Swap(
                tab(posVide(0), posVide(1)),
                tab(posVide(0) - 1, posVide(1)))
            posVide(0) -= 1

        ElseIf x = posVide(0) And y = (posVide(1) + 1) Mod taille Then ' EST
            Swap(
                tab(posVide(0), posVide(1)),
                tab(posVide(0), (posVide(1) + 1) Mod taille))
            posVide(1) = (posVide(1) + 1) Mod taille

        ElseIf x = posVide(0) And y = (posVide(1) + taille - 1) Mod taille Then ' OUEST
            Swap(
                tab(posVide(0), posVide(1)),
                tab(posVide(0), (posVide(1) + taille - 1) Mod taille))
            posVide(1) = (posVide(1) + taille - 1) Mod taille

        ElseIf posVide(0) < taille - 1 And x = posVide(0) + 1 And y = posVide(1) Then ' SUD
            Swap(
                tab(posVide(0), posVide(1)),
                tab(posVide(0) + 1, posVide(1)))
            posVide(0) += 1

        End If
        Jeu.ActualiserAffichage()
    End Sub
    Sub Déplacer(direction As String)
        If direction = "NORD" Then
            Déplacer((posVide(0) - 1) Mod taille, posVide(1))
        ElseIf direction = "EST" Then
            Déplacer(posVide(0), (posVide(1) + 1) Mod taille)
        ElseIf direction = "OUEST" Then
            Déplacer(posVide(0), (posVide(1) + taille - 1) Mod taille)
        ElseIf direction = "SUD" Then
            Déplacer((posVide(0) + 1) Mod taille, posVide(1))
        End If
    End Sub
    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    ' Sub Résoudre
    ' Lance un processus de résolution du taquin et l'interprête
    Public Sub Résoudre()

        ' Initialise et lance le processus
        Dim solveur As New Process()
        With solveur.StartInfo
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .UseShellExecute = False
            .CreateNoWindow = True
            .Arguments = Nothing
            .FileName = ".\Solveur.exe"
        End With

        solveur.Start()

        ' Écrit sur le in du processus
        With solveur.StandardInput
            .Write(taille & " " & taille)
            For i = 0 To taille - 1
                For j = 0 To taille - 1
                    If tab(i, j) = 0 Then
                        .Write(" #")
                    Else
                        .Write(" " & tab(i, j))
                    End If
                Next
            Next
            .Close()
        End With
        solveur.WaitForExit()

        ' Lit et interprète le out du processus
        Dim déplacements = New String("")
        With solveur.StandardOutput
            Dim line As String = .ReadLine
            While line <> Nothing

                If line.Trim = "NORD" Then
                    Déplacer("NORD")
                    Jeu.ActualiserAffichage()
                    Threading.Thread.Sleep(250)

                ElseIf line.Trim = "EST" Then
                    Déplacer("EST")
                    Jeu.ActualiserAffichage()
                    Threading.Thread.Sleep(250)

                ElseIf line.Trim = "SUD" Then
                    Déplacer("SUD")
                    Jeu.ActualiserAffichage()
                    Threading.Thread.Sleep(250)

                ElseIf line.Trim = "OUEST" Then
                    Déplacer("OUEST")
                    Jeu.ActualiserAffichage()
                    Threading.Thread.Sleep(250)

                End If
                line = .ReadLine
            End While
        End With
        solveur.Close()
    End Sub

End Module

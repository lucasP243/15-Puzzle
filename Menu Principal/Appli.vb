Imports System.IO

Module Appli

    Public TJoueurs As List(Of Joueur)

    Public Sub Main()
        TJoueurs = New List(Of Joueur)
        LireJoueurs()

        Application.Run(MenuAccueil)
    End Sub

    ' Function Existe
    ' Paramètre "nom" - String
    ' Retourne True si ce nom existe dans la liste des joueurs, False sinon
    Public Function Existe(nom As String) As Boolean
        Return GetJoueur(nom) IsNot Nothing
    End Function

    ' Function GetJoueur
    ' Paramètre "nom" - String
    ' Retourne le joueur au nom spécifié s'il existe dans la liste, Nothing sinon
    Public Function GetJoueur(nom As String) As Joueur
        For i As Integer = 0 To TJoueurs.Count - 1
            If TJoueurs(i).GetNom = nom Then
                Return TJoueurs(i)
            End If
        Next
        Return Nothing
    End Function


    ' Sub AjouterJoueur
    ' Ajoute un joueur à la liste de joueurs
    Public Sub AjouterJoueur(nom As String)
        TJoueurs.Add(New Joueur(nom))
    End Sub


    ' Sub LireJoueurs
    ' Lit la liste de joueurs sérialisée et sauvegardée dans ".\joueurs\data.txt"
    Private Sub LireJoueurs()

        ' Création du répertoire .\Joueurs s'il n'existe pas
        My.Computer.FileSystem.CreateDirectory(".\joueurs")

        ' Initialisation de f sérialisateur au format binaire et e flux d'entrée du fichier data.txt
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter =
            New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim e As IO.Stream =
            New IO.FileStream(".\joueurs\data.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None)

        ' Essaie de caster la liste sérialisée. Échoue si le fichier n'est pas désérialisable (corrompu) et le supprime
        Try
            TJoueurs = DirectCast(F.Deserialize(e), List(Of Joueur))
        Catch ex As Runtime.Serialization.SerializationException
            MsgBox("Données corrompues",, "Erreur")
            e.Close()
            My.Computer.FileSystem.DeleteFile(".\joueurs\data.txt")
        End Try
        e.Close()
    End Sub


    ' Sub EnregistrerJoueurs
    ' Sérialise et écrit la liste des joueurs dans ".\joueurs\data.txt"
    Public Sub EnregistrerJoueurs()
        Dim F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim s As IO.Stream = New IO.FileStream(".\joueurs\data.txt", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        F.Serialize(s, TJoueurs)
        s.Close()
    End Sub
End Module

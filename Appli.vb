Imports System.IO

Module Appli

    Private TJoueurs As List(Of Joueur)
    Private Path As String

    Public Function GetPath() As String
        Return Path
    End Function

    Public Sub SetPath(path As String)
        Appli.Path = path
    End Sub

    Public Sub Main()
        TJoueurs = New List(Of Joueur)
        Charger()

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
    ' Retourne le joueur au nom spécifié s'il existe dans la liste,
    ' Nothing sinon
    Public Function GetJoueur(nom As String) As Joueur
        For i As Integer = 0 To TJoueurs.Count - 1
            If TJoueurs(i).GetNom = nom Then
                Return TJoueurs(i)
            End If
        Next
        Return Nothing
    End Function

    ' Function GetJoueurs
    ' Retourne la liste des joueurs existants dans l'application
    Public Function GetJoueurs() As Joueur()
        Return TJoueurs.ToArray
    End Function

    ' Sub Remove
    ' Paramètre "nom" - String
    ' Supprime le joueur au nom spécifié, ou tous les joueurs si non spécifié
    Public Sub Remove(nom As String)
        TJoueurs.Remove(GetJoueur(nom))
    End Sub
    Public Sub Remove()
        TJoueurs.Clear()
    End Sub

    ' Sub AjouterJoueur
    ' Ajoute un joueur à la liste de joueurs
    Public Sub AjouterJoueur(nom As String)
        TJoueurs.Add(New Joueur(nom))
    End Sub


    ' Sub Charger
    ' Charge la configuration et restaure les joueurs sauvegardés
    Private Sub Charger()

        If My.Computer.FileSystem.FileExists(".\config.dat") Then
            Dim config As StreamReader = New StreamReader(".\config.dat")
            Path = config.ReadLine
            SetTaille(config.ReadLine)
            SetTemps(config.ReadLine)
            config.Close()
        Else
            Path = ".\joueurs"
            SetTaille(4)
            SetTemps(120)
        End If

        ' Création du répertoire s'il n'existe pas
        My.Computer.FileSystem.CreateDirectory(Path)

        ' Initialisation de f sérialisateur au format binaire 
        ' et e flux d'entrée du fichier data.txt
        Dim F As Runtime.Serialization.Formatters.Binary.BinaryFormatter =
            New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim e As Stream =
            New FileStream(
            Path & "\data.dat",
            FileMode.OpenOrCreate,
            FileAccess.Read,
            FileShare.None)

        ' Essaie de caster la liste sérialisée. Échoue si le fichier
        ' n'est pas désérialisable (corrompu) et le supprime
        Try
            TJoueurs = DirectCast(F.Deserialize(e), List(Of Joueur))
        Catch ex As Runtime.Serialization.SerializationException
            MsgBox("Données inexistantes ou corrompues",, "Erreur")
            e.Close()
            My.Computer.FileSystem.DeleteFile(Path & "\data.dat")
        End Try
        e.Close()
    End Sub


    ' Sub Sauvegarder
    ' Sauvegarde la configuration et les joueurs enregistrés
    Public Sub Sauvegarder()

        Dim config As StreamWriter = New StreamWriter(".\config.dat")
        config.WriteLine(Path)
        config.WriteLine(GetTaille)
        config.WriteLine(GetTempsAccordé)
        config.Close()

        Dim F = New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim s As Stream =
            New FileStream(
            Path & "\data.dat",
            FileMode.Create,
            FileAccess.Write,
            FileShare.None)
        F.Serialize(s, TJoueurs)
        s.Close()
    End Sub
End Module

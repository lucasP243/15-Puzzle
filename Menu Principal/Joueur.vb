<Serializable()> Public Class Joueur

    Private ReadOnly nom As String
    Private ReadOnly dateCréation As Date
    Private meilleurTemps As Integer
    Private nbPartiesJouées As Integer
    Private tempsTotal As Integer


    ' Sub New
    ' Paramètre "nom" - String
    ' Construit un nouveau joueur au nom donné
    Public Sub New(nom As String)
        Me.nom = nom
        dateCréation = Date.Now
        meilleurTemps = nbPartiesJouées = tempsTotal = 0
    End Sub

    ' Sub Joue
    ' Incrémente de 1 le nombre de parties jouées du joueur 
    ' et le définit comme joueur actuel du taquin
    Public Sub Joue()
        nbPartiesJouées += 1
        SetJoueur(Me)
    End Sub

    ' Sub SubmitTemps
    ' Prends le temps du joueur ayant fini sa partie, et actualise
    ' le tempsTotal, ainsi que le meilleurTemps
    Public Sub SubmitTemps(temps As Integer, aGagné As Boolean)
        tempsTotal += temps
        If aGagné And (meilleurTemps = 0 Or temps < meilleurTemps) Then
            meilleurTemps = temps
        End If
    End Sub

    ' Function GetNom
    ' Retourne le nom du joueur
    Public Function GetNom() As String
        Return nom
    End Function


    ' Function GetDateCréation
    ' Retourne la date de création du joueur
    Public Function GetDateCréation() As Date
        Return dateCréation
    End Function


    ' Function GetMeilleurTemps
    ' Retourne le meilleur temps du joueur
    Public Function GetMeilleurTemps() As Integer
        Return meilleurTemps
    End Function


    ' Function GetNbPartiesJouées
    ' Retourne le nombre de parties jouées par le joueur
    Public Function GetNbPartiesJouées() As Integer
        Return nbPartiesJouées
    End Function
    ' Function GetTempsTotal
    ' Retourne le nombre de parties jouées par le joueur
    Public Function GetTempsTotal() As Integer
        Return tempsTotal
    End Function


    ' Function ToString
    ' Retourne une chaine de caractère contenant le nom du joueur
    Public Overrides Function ToString() As String
        Return Me.nom
    End Function

End Class

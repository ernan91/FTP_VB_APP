Imports System.Net

Public Class Form1

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click


        Try
            ' Obtenir les informations de connexion à partir des contrôles TextBox.
            Dim username As String = TextBoxUsername.Text
            Dim password As String = TextBoxPassword.Text
            Dim ftpAddress As String = TextBoxFtpAddress.Text


            ' Vérifier que les champs ne sont pas vides.
            If String.IsNullOrEmpty(TextBoxUsername.Text) Then
                MessageBox.Show("Veuillez entrer un nom d'utilisateur.")
                Return
            End If

            ' Créer une demande FTP pour se connecter au serveur.
            If String.IsNullOrEmpty(ftpAddress) Then
                MessageBox.Show("Veuillez saisir une adresse FTP valide.")
            Else
                ' Créer une demande FTP pour se connecter au serveur.
                Dim request As FtpWebRequest = DirectCast(WebRequest.Create(ftpAddress), FtpWebRequest)
                request.Credentials = New NetworkCredential(username, password)
                request.Method = WebRequestMethods.Ftp.ListDirectory
                ' Envoyer la commande FTP pour lister les fichiers du répertoire racine.
                Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)


                ' Afficher un message de connexion réussie et fermer le formulaire de connexion.
                MessageBox.Show("Connexion réussie!")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If


    Catch ex As WebException
            ' Si une exception WebException se produit, afficher un message d'erreur.
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        End Try
    End Sub


    'Private Sub TextBoxFTP_GotFocus(sender As Object, e As EventArgs) Handles TextBoxFtpAddress.GotFocus
    '    If TextBoxFtpAddress.Text = "ftp://" Then
    '        TextBoxFtpAddress.Text = ""
    '    End If
    'End Sub

    'Private Sub TextBoxFTP_LostFocus(sender As Object, e As EventArgs) Handles TextBoxFtpAddress.LostFocus
    '    If String.IsNullOrEmpty(TextBoxFtpAddress.Text) Then
    '        TextBoxFtpAddress.Text = "ftp://"
    '    End If

    'End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub TextBoxFtpAddress_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFtpAddress.TextChanged

    End Sub

    Private Sub ButtonConnect_Click_1(sender As Object, e As EventArgs) Handles ButtonConnect.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles HostLabel.Click

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles TitleForm.Click

    End Sub
End Class

Using System;
Using System.Net;
Using System.Windows.Forms;

Namespace FTPApp
{
    Partial Public Class LoginForm :  Form
    {
        Public LoginForm()
        {
            InitializeComponent();
        }

        Private void buttonConnect_Click(Object sender, EventArgs e)
        {
            Try
            {
                // Obtenir les informations de connexion à partir des contrôles TextBox.
                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;
                String ftpAddress = textBoxFtpAddress.Text;

                // Créer une demande FTP pour se connecter au serveur.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpAddress);
                request.Credentials = New NetworkCredential(username, password);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                // Envoyer la commande FTP pour lister les fichiers du répertoire racine.
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                // Afficher un message de connexion réussie et fermer le formulaire de connexion.
                MessageBox.Show("Connexion réussie!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            Catch (WebException ex)
            {
                // Si une exception WebException se produit, afficher un message d'erreur.
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}

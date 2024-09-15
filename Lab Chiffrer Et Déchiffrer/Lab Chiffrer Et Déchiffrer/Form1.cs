using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiffrerEtDechiffrer
{
    public partial class Form1 : Form
    {
        public enum NomAlgorithme
        {
            Aucun, TripleDES, AES, DSA, RSA
        }

        Object algo { get; set; } = null; // Permet de conserver la clé intacte entre les opérations
        byte[] hash { get; set; } = null; // Utile pour l'algorithme DSA

        public Form1()
        {
            InitializeComponent();

            this.algorithme.Items.AddRange(Enum.GetNames(typeof(NomAlgorithme)));
            this.algorithme.SelectedIndex = 0; // Aucun algorithme par défaut
        }

        private void algorithme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)this.algorithme.SelectedItem == NomAlgorithme.Aucun.ToString())
            {
                // On vide le contenu du champ cles
                this.cles.Text = "";
                this.tailleCle.Text = "Taille de la clé : 0 bit";
                algo = null;
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.TripleDES.ToString())
            {
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.GenerateKey();
                tdes.GenerateIV(); // On génère aussi un vecteur d'initialisation
                this.cles.Text = BitConverter.ToString(tdes.Key);
                this.tailleCle.Text = "Taille de la clé : " + tdes.KeySize + " bits";
                algo = tdes;
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.AES.ToString())
            {
                RijndaelManaged aes = new RijndaelManaged();
                aes.GenerateKey();
                aes.GenerateIV();
                this.cles.Text = BitConverter.ToString(aes.Key);
                this.tailleCle.Text = "Taille de la clé : " + aes.KeySize + " bits";
                algo = aes;
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.DSA.ToString())
            {
                DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
                this.cles.Text = dsa.ToXmlString(true);
                this.tailleCle.Text = "Taille de la clé : " + dsa.KeySize + " bits";
                algo = dsa;
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.RSA.ToString())
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                this.cles.Text = rsa.ToXmlString(true);
                this.tailleCle.Text = "Taille de la clé : " + rsa.KeySize + " bits";
                algo = rsa;
            }
        }

        private void chiffrer_Click(object sender, EventArgs e)
        {
            if ((string)this.algorithme.SelectedItem == NomAlgorithme.Aucun.ToString())
            {
                // Puisqu'aucun algorithme n'est choisi, on conserve le texte de l'utilisateur en sortie
                this.texteTransforme.Text = this.texteUtilisateur.Text;
                return;
            }

            byte[] donneesBrutes = UTF8Encoding.UTF8.GetBytes(this.texteUtilisateur.Text);
            byte[] donneesTransformees = null;

            if ((string)this.algorithme.SelectedItem == NomAlgorithme.TripleDES.ToString())
            {
                TripleDESCryptoServiceProvider tdes = (TripleDESCryptoServiceProvider)algo;
                ICryptoTransform encrypteur = tdes.CreateEncryptor(tdes.Key, tdes.IV);
                donneesTransformees = encrypteur.TransformFinalBlock(donneesBrutes, 0, donneesBrutes.Length);
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.AES.ToString())
            {
                RijndaelManaged aes = (RijndaelManaged)algo;
                ICryptoTransform encrypteur = aes.CreateEncryptor(aes.Key, aes.IV);
                donneesTransformees = encrypteur.TransformFinalBlock(donneesBrutes, 0, donneesBrutes.Length);
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.DSA.ToString())
            {
                DSACryptoServiceProvider dsa = (DSACryptoServiceProvider)algo;
                hash = new SHA1Managed().ComputeHash(donneesBrutes);
                donneesTransformees = dsa.SignData(donneesBrutes);
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.RSA.ToString())
            {
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)algo;
                donneesTransformees = rsa.Encrypt(donneesBrutes, true);
            }

            // On affiche les données chiffrées à l'utilisateur
            this.texteTransforme.Text = Convert.ToBase64String(donneesTransformees, 0, donneesTransformees.Length);
        }

        private void dechiffrer_Click(object sender, EventArgs e)
        {
            if ((string)this.algorithme.SelectedItem == NomAlgorithme.Aucun.ToString())
            {
                // Puisqu'aucun algorithme n'est choisi, on conserve le texte de l'utilisateur en sortie
                this.texteTransforme.Text = this.texteUtilisateur.Text;
                return;
            }

            byte[] donneesBrutes = Convert.FromBase64String(this.texteUtilisateur.Text);
            byte[] donneesTransformees = null;

            if ((string)this.algorithme.SelectedItem == NomAlgorithme.TripleDES.ToString())
            {
                TripleDESCryptoServiceProvider tdes = (TripleDESCryptoServiceProvider)algo;
                ICryptoTransform decrypteur = tdes.CreateDecryptor(tdes.Key, tdes.IV);
                donneesTransformees = decrypteur.TransformFinalBlock(donneesBrutes, 0, donneesBrutes.Length);
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.AES.ToString())
            {
                RijndaelManaged aes = (RijndaelManaged)algo;
                ICryptoTransform decrypteur = aes.CreateDecryptor(aes.Key, aes.IV);
                donneesTransformees = decrypteur.TransformFinalBlock(donneesBrutes, 0, donneesBrutes.Length);
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.DSA.ToString())
            {
                DSACryptoServiceProvider dsa = (DSACryptoServiceProvider)algo;
                this.texteTransforme.Text = (dsa.VerifySignature(hash, donneesBrutes) ? "Signature valide !" : "Signature invalide !");
                return;
            }
            else if ((string)this.algorithme.SelectedItem == NomAlgorithme.RSA.ToString())
            {
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)algo;
                donneesTransformees = rsa.Decrypt(donneesBrutes, true);
            }

            // On affiche les données déchiffrées à l'utilisateur
            this.texteTransforme.Text = UTF8Encoding.UTF8.GetString(donneesTransformees);
        }
    }
}

/*
 
1. Un vecteur d'initialisation est une séquence de bits aléatoire qui est utilisée avec la clé de chiffrement
pour chiffrer un message. Le vecteur d'initialisation permet de créer un message chiffré différent à chaque
fois même en utilisant la même clé. Cela empêche ceux qui ne connaissent pas la clé de trouver des pistes
pour deviner la clé en connaissant le message déchiffrer.

4. RSA produit des messages chiffrés plus longs que DSA, mais les deux algorithmes utilisent des clés de
1024 bits.

5. Le programme produit des exceptions car il est impossible de déchiffrer les messages. Un des problèmes
est que la clé de chiffrement des deux algorithmes ne fait pas la même taille.
 
*/
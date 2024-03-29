﻿using calendrier.view;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace calendrier
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            // Vérifie le nom d'utilisateur et le mot de passe
            if (TB_Username.Text == "clem" && TB_Password.Password == "clem")
            {
                // Crée la vue du tableau de bord
                var dashboardView = new view_dashboard(); // Assurez-vous de remplacer DashboardView par le nom de votre classe de vue du tableau de bord

                // Remplace le contenu des deux parties de la grille
                Ecran.Children.Clear(); // Efface tout contenu existant dans la grille

                Grid.SetColumnSpan(dashboardView, 2);

                Ecran.Children.Add(dashboardView);
            }
            else
            {
                // Affiche un message d'erreur
                MessageBox.Show("Accès refusé. Nom d'utilisateur ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }





    }
}



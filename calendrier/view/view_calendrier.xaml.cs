using System;
using System.Collections.Generic;
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

namespace calendrier.view
{
    /// <summary>
    /// Logique d'interaction pour view_calendrier.xaml
    /// </summary>
    public partial class view_calendrier : UserControl
    {
        public view_calendrier()
        {
            InitializeComponent();
            // Abonnez-vous à l'événement ScriptErrorsSuppressedChanged pour intercepter les erreurs de script
            webBrowser.Navigating += WebBrowser_Navigating;
        }
        private void WebBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            // Inspectez le contenu de la page ici
            // Vous pouvez rechercher des erreurs de script ou d'autres problèmes
            // Par exemple, vous pouvez utiliser JavaScript pour inspecter la page
        }

    }
}

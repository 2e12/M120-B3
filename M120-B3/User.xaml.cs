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

namespace M120_B3
{
    /// <summary>
    /// Interaktionslogik für User.xaml
    /// </summary>
    public partial class User : UserControl
    {
        public string _Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { 
                SetValue(UsernameProperty, value);
                UsernameLabel.Content = value;
            }
        }

        public static readonly DependencyProperty UsernameProperty = DependencyProperty.Register(
          "Username",
          typeof(String),
          typeof(User),
          new PropertyMetadata("")
        );

        public User()
        {
            InitializeComponent();
        }
    }
}

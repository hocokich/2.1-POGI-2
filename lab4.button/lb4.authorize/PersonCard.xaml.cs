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
using System.Xml.Linq;

namespace lb4.authorize
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class PersonCard : UserControl
    {
        public PersonCard()
        {
            InitializeComponent();

            //pcName.TextChanged += login_TextChanged; // назначение обработчика изменения логина 
            //pass.TextChanged += pass_TextChanged; // назначение обработчика изменения пароля

        }

        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }
        public ImageSource Pic
        {
            get { return (ImageSource)GetValue(PicProperty); }
            set { SetValue(PicProperty, value); }
        }

        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
         "login", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(PersonCard), // тип данных элемента управления
         new PropertyMetadata(null, LoginChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра
        public static readonly DependencyProperty PicProperty = DependencyProperty.Register(
         "pcPic", // имя параметра в разметке
         typeof(ImageSource), // тип данных параметра
         typeof(PersonCard), // тип данных элемента управления
         new PropertyMetadata(null, PicChanged)); // метаданные - значение параметра по умолчанию и обработчик изменения параметра

        private static void LoginChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.pcName.Content = loginForm.Login;
        }
        private static void PicChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.pcPic.Source = loginForm.Pic;
            loginForm.picLb.Opacity = 0;
        }

        private void validateData()
        {
            // длина логина должна быть не менее 4 символов,
            // а длина пароля - не менее 8 символов
            bool isDataValid = pcName.Content.ToString().Count() >= 5;

            if (isDataValid)
                ok.IsEnabled = true;
            else
                ok.IsEnabled = false;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            Login = null;
            Pic = null;

            pcName.Content = "Имя";

            pcAbout.Content = "О себе";

            pcStatus.Content = "Статус";

            picLb.Opacity = 100;
        }
    }
}

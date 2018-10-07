using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using IoC.Core.Services;

namespace IoC.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUuidService _uuidService;
        private readonly IUserService _userService;

        public MainWindow(IUuidService uuidService, IUserService userService)
        {
            _uuidService = uuidService;
            _userService = userService;

            InitializeComponent();

            aLabel.Content = uuidService.GetUuid();
            bLabel.Content = userService.GetCurrentUserName();
        }
    }
}

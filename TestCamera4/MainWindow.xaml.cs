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
using WebcamCapturer.Core;
//using WebcamCapturer.Controls.WPF;

namespace TestCamera4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            var view = new WebcamCaptureWindow();
            var presenter = new WebcamCapturePresenter(view);

            //view.Show();
        }
//        public void test(){
//            var view = new WebcamCaptureWindow()
//var presenter = new WebcamCapturePresenter(view);
//            presenter.Show();
//        }
    }
}

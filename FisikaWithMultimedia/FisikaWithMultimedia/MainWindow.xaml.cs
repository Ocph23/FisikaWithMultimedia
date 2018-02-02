using FirstFloor.ModernUI.Windows.Controls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FisikaWithMultimedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window
    {
        private double skala;
        private double detik;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            kecepatan.Text = (Convert.ToDouble(jarak.Text) / Convert.ToDouble(waktu.Text)).ToString() + "km/Jam";
            TranslateTransform trans = new TranslateTransform();
            ex2.RenderTransform = trans;
           // DoubleAnimation anim1 = new DoubleAnimation(top, 0 - top, TimeSpan.FromSeconds(10));
            DoubleAnimation anim2 = new DoubleAnimation(ex2.Width/2, border1.Width, TimeSpan.FromSeconds(Convert.ToDouble(waktu.Text) * detik));
          //  trans.BeginAnimation(TranslateTransform.XProperty, anim1);
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);
        }

        private void Trans_Changed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Ex2_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.skala = Convert.ToDouble(skalacm.Text) * 37.795275590551178;
            border1.Width = Convert.ToDouble(jarak.Text) * skala;
            this.detik = Convert.ToDouble(skalaw.Text) * 1;

            var w = System.Windows.SystemParameters.PrimaryScreenWidth;
        }
    }
}

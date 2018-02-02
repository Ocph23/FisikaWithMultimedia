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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace FisikaWithMultimedia
{
    /// <summary>
    /// Interaction logic for Parabola.xaml
    /// </summary>
    public partial class Parabola : Window
    {
        public Parabola()
        {
            InitializeComponent();

            DoubleAnimation anim2 = new DoubleAnimation(0,360, TimeSpan.FromSeconds(2));
           // anim2.AutoReverse = true;
            anim2.RepeatBehavior = RepeatBehavior.Forever;
            //  trans.BeginAnimation(TranslateTransform.XProperty, anim1);
            TranslateTransform trans = new TranslateTransform();
            //rotate.BeginAnimation(AxisAngleRotation3D.AngleProperty, anim2);
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);
            //rotate.Angle = 30;
        }
    }
}

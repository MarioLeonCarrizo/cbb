using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace cbb.ui
{
    public class BasePage : Page
    {
        public PageAnimationType Animation { get; set; } = PageAnimationType.Fade;
        public float AnimationDuration { get; set; } = 0.3f;
        public BasePage()
        {
            if(Animation != PageAnimationType.None)
            {
                Visibility = Visibility.Collapsed;
            }

            Loaded += BasePage_Loaded;
        }

        private void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            AnimatePage();
        }

        private void AnimatePage()
        {
            if (Animation == PageAnimationType.None)
                return;
            else if (Animation == PageAnimationType.Fade)
            {
                var anim = new DoubleAnimation
                {
                    From = 0.0,
                    To = 1.0,
                    Duration = TimeSpan.FromSeconds(AnimationDuration * 3),
                    DecelerationRatio = 0.85f,
                };

                BeginAnimation(OpacityProperty, anim);
                Visibility = Visibility.Visible;
            }
            else
            {
                var storyBoard = new Storyboard();
                var anim = new ThicknessAnimation
                {
                    Duration = new Duration(TimeSpan.FromSeconds(AnimationDuration)),
                    From = new Thickness(640, 0, 640, 0),
                    To = new Thickness(0),
                    DecelerationRatio = 0.85f,
                };

                BeginAnimation(MarginProperty, anim);
                Visibility = Visibility.Visible;
            }
        }
    }
}

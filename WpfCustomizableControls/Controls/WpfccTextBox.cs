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

namespace WpfCustomizableControls.Controls
{
    /// <summary>
    /// Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
    ///
    /// Paso 1a) Usar este control personalizado en un archivo XAML existente en el proyecto actual.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomizableControls.Controls"
    ///
    ///
    /// Paso 1b) Usar este control personalizado en un archivo XAML existente en otro proyecto.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomizableControls.Controls;assembly=WpfCustomizableControls.Controls"
    ///
    /// Tendrá también que agregar una referencia de proyecto desde el proyecto en el que reside el archivo XAML
    /// hasta este proyecto y recompilar para evitar errores de compilación:
    ///
    ///     Haga clic con el botón secundario del mouse en el proyecto de destino en el Explorador de soluciones y seleccione
    ///     "Agregar referencia"->"Proyectos"->[Busque y seleccione este proyecto]
    ///
    ///
    /// Paso 2)
    /// Prosiga y utilice el control en el archivo XAML.
    ///
    ///     <MyNamespace:WpfccTextBox/>
    ///
    /// </summary>
    public class WpfccTextBox : TextBox
    {
        static WpfccTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfccTextBox), new FrameworkPropertyMetadata(typeof(WpfccTextBox)));
        }

        #region Icon

        #region Visibility

        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(bool), typeof(WpfccTextBox), new PropertyMetadata(true));

        #endregion

        #region Font

        public FontFamily IconFont
        {
            get { return (FontFamily)GetValue(IconFontProperty); }
            set { SetValue(IconFontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFont.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontProperty =
            DependencyProperty.Register("IconFont", typeof(FontFamily), typeof(WpfccTextBox), new PropertyMetadata(new FontFamily("Segoe MDL2 Assets")));

        #endregion

        #region Icon

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(WpfccTextBox), new PropertyMetadata("\uE128"));

        #endregion

        #region Size

        public double IconSize
        {
            get { return (double)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double), typeof(WpfccTextBox), new PropertyMetadata((double)16));

        #endregion

        #region Brushes

        #region Foreground

        public Brush IconForeground
        {
            get { return (Brush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register("IconForeground", typeof(Brush), typeof(WpfccTextBox), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        #endregion

        #region ForegroundHover

        public Brush IconForegroundHover
        {
            get { return (Brush)GetValue(IconForegroundHoverProperty); }
            set { SetValue(IconForegroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconForegroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundHoverProperty =
            DependencyProperty.Register("IconForegroundHover", typeof(Brush), typeof(WpfccTextBox), new PropertyMetadata(new SolidColorBrush(Colors.CornflowerBlue)));

        #endregion

        #endregion

        #endregion

        #region Brushes        

        #region BorderBrushHover

        public Brush BorderBrushHover
        {
            get { return (Brush)GetValue(BorderBrushHoverProperty); }
            set { SetValue(BorderBrushHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderBrushHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush), typeof(WpfccTextBox), new PropertyMetadata(new SolidColorBrush(Colors.CornflowerBlue)));

        #endregion        

        #endregion

        #region Placeholder
       
        #region Foreground

        public Brush PlaceholderForeground
        {
            get { return (Brush)GetValue(PlaceholderForegroundProperty); }
            set { SetValue(PlaceholderForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceholderForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderForegroundProperty =
            DependencyProperty.Register("PlaceholderForeground", typeof(Brush), typeof(WpfccTextBox), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        #endregion

        #region Text

        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceholderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(WpfccTextBox), new PropertyMetadata("This is a placeholder!"));

        #endregion

        #endregion

        #region Border

        #region CornerRadius

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(WpfccTextBox), new PropertyMetadata(new CornerRadius(5)));

        #endregion

        #endregion
    }
}

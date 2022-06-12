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
    ///     <MyNamespace:WpfccExpander/>
    ///
    /// </summary>
    public class WpfccExpander : Expander
    {
        static WpfccExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfccExpander), new FrameworkPropertyMetadata(typeof(WpfccExpander)));
        }


        #region Brushes

        #region HeaderBrush

        public Brush HeaderBrush
        {
            get { return (Brush)GetValue(HeaderBrushProperty); }
            set { SetValue(HeaderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderBrushProperty =
            DependencyProperty.Register("HeaderBrush", typeof(Brush), typeof(WpfccExpander), new PropertyMetadata(new SolidColorBrush(Colors.Gray)));

        #endregion

        #region ContentBrush

        public Brush ContentBrush
        {
            get { return (Brush)GetValue(ContentBrushProperty); }
            set { SetValue(ContentBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentBrushProperty =
            DependencyProperty.Register("ContentBrush", typeof(Brush), typeof(WpfccExpander), new PropertyMetadata(new SolidColorBrush(Colors.LightGray)));

        #endregion

        #endregion

        #region ExpandIcon

        #region Foreground

        public Brush IconForeground
        {
            get { return (Brush)GetValue(IconForegroundProperty); }
            set { SetValue(IconForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconForegroundProperty =
            DependencyProperty.Register("IconForeground", typeof(Brush), typeof(WpfccExpander), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        #endregion

        #region Font

        public FontFamily IconFont
        {
            get { return (FontFamily)GetValue(IconFontProperty); }
            set { SetValue(IconFontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFont.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontProperty =
            DependencyProperty.Register("IconFont", typeof(FontFamily), typeof(WpfccExpander), new PropertyMetadata(new FontFamily("Segoe MDL2 Assets")));

        #endregion

        #endregion
    }
}

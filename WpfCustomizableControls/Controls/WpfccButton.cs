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
    ///     <MyNamespace:WpfccButton/>
    ///
    /// </summary>
    public class WpfccButton : Button
    {
        static WpfccButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfccButton), new FrameworkPropertyMetadata(typeof(WpfccButton)));
        }

        public enum _Layout
        {
            OnlyText,
            OnlyIcon,
            IconText
        };

        public enum _IconAlignment
        {
            Left,
            Top,
            Right,
            Bottom            
        };

        public _Layout Layout
        {
            get { return (_Layout)GetValue(LayoutProperty); }
            set { SetValue(LayoutProperty, value); }
        }
        
        public static readonly DependencyProperty LayoutProperty =
            DependencyProperty.Register("Layout", typeof(_Layout), typeof(WpfccButton), new PropertyMetadata(_Layout.IconText));



        public _IconAlignment IconAlignment
        {
            get { return (_IconAlignment)GetValue(IconAlignmentProperty); }
            set { SetValue(IconAlignmentProperty, value); }
        }
        
        public static readonly DependencyProperty IconAlignmentProperty =
            DependencyProperty.Register("IconAlignment", typeof(_IconAlignment), typeof(WpfccButton), new PropertyMetadata(_IconAlignment.Left));        


        #region Icon

        #region Font

        public FontFamily IconFont
        {
            get { return (FontFamily)GetValue(IconFontProperty); }
            set { SetValue(IconFontProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFont.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFontProperty =
            DependencyProperty.Register("IconFont", typeof(FontFamily), typeof(WpfccButton), new PropertyMetadata(new FontFamily("Segoe MDL2 Assets")));

        #endregion

        #region Icon

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(WpfccButton), new PropertyMetadata("\uE128"));

        #endregion

        #region Size

        public double IconSize
        {
            get { return (double)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double), typeof(WpfccButton), new PropertyMetadata((double)16));

        #endregion

        #endregion

        #region Border

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(WpfccButton), new PropertyMetadata(new CornerRadius(5)));

        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    ///     <MyNamespace:WpfccScrollBar/>
    ///
    /// </summary>
    public class WpfccScrollBar : ScrollBar
    {
        static WpfccScrollBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WpfccScrollBar), new FrameworkPropertyMetadata(typeof(WpfccScrollBar)));
        }

        #region Brushes

        #region Background

        public new Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public new static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(WpfccScrollBar), new PropertyMetadata(Brushes.DarkGray));

        #endregion

        #region ThumbBrush

        public Brush ThumbBrush
        {
            get { return (Brush)GetValue(ThumbBrushProperty); }
            set { SetValue(ThumbBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThumBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThumbBrushProperty =
            DependencyProperty.Register("ThumbBrush", typeof(Brush), typeof(WpfccScrollBar), new PropertyMetadata(Brushes.Black));

        #endregion

        #endregion

        #region Hover

        #region ThumBrushHover
        public Brush ThumbBrushHover
        {
            get { return (Brush)GetValue(ThumbBrushHoverProperty); }
            set { SetValue(ThumbBrushHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ThumBrushHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThumbBrushHoverProperty =
            DependencyProperty.Register("ThumbBrushHover", typeof(Brush), typeof(WpfccScrollBar), new PropertyMetadata(Brushes.Gray));

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
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(WpfccScrollBar), new PropertyMetadata(new CornerRadius(5)));

        #endregion
    }
}

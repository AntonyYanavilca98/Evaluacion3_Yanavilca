//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Evaluacion3.DatePickerExample.xaml", "DatePickerExample.xaml", typeof(global::Evaluacion3.DatePickerExample))]

namespace Evaluacion3 {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("DatePickerExample.xaml")]
    public partial class DatePickerExample : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.DatePicker startDatePicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.DatePicker endDatePicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch includeSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label resultLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(DatePickerExample));
            startDatePicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.DatePicker>(this, "startDatePicker");
            endDatePicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.DatePicker>(this, "endDatePicker");
            includeSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "includeSwitch");
            resultLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "resultLabel");
        }
    }
}
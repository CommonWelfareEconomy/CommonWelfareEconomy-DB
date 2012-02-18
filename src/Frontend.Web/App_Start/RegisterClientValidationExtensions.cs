using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Frontend.Web.App_Start.RegisterClientValidationExtensions), "Start")]
 
namespace Frontend.Web.App_Start {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();            
        }
    }
}
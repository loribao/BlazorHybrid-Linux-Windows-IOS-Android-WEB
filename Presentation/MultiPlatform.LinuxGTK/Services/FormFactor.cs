using Presentation.Shared.Services;

namespace MultiPlatform.LinuxGTK.Services
{
    public class FormFactor : IFormFactor
    {
        public string GetFormFactor()
        {
            return "Gtk Linux";
        }

        public string GetPlatform()
        {
            return "Linux" + " - ";
        }
    }
}

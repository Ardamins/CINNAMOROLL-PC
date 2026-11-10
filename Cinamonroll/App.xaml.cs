using System.Windows;

namespace Cinnamoroll
{
    public partial class App : Application
    {
        // Variables globales para la configuración
        public static string ProveedorIA = "Ollama";
        public static string UrlIA = "http://localhost:11434/api/generate";
        public static string ApiKey = "";
        public static string ModeloIA = "llama3";
    }
}
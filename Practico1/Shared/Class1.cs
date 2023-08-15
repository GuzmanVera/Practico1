namespace Shared
{
    public class Persona
    {
        public String nombre { get; set; } = "--Sin Nombre--";
        public String apellido { get; set; } = "--Sin Apellido--";

        private String documento = "";
        public String Documento
        {
            get { return documento; }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("Documento incorrecto");
                }
                else
                {
                    documento = value.ToUpper();
                }
            }
        }

        public DateTime fechaNac { get; set; }
    }
}
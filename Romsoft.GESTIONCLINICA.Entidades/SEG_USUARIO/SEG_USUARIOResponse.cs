using Romsoft.GESTIONCLINICA.Entidades.Core;

namespace Romsoft.GESTIONCLINICA.Entidades.SEG_USUARIO
{
    public class SEG_USUARIOResponse : EntityAuditable
    {
        public int id_usuario { get; set; }
        public int id_rol { get; set; }
        public string RolNombre { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string nro_documento { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string estado { get; set; }
        public int Cantidad { get; set; }
    }
}

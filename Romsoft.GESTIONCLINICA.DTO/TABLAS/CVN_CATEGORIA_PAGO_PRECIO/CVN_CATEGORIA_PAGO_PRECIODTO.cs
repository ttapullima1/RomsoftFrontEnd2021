using Romsoft.GESTIONCLINICA.DTO.Core;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_CATEGORIA_PAGO_PRECIO
{
    public class CVN_CATEGORIA_PAGO_PRECIODTO : EntityAuditableDTO
    {
        public int id_categoria_pago_precio { get; set; }

        public int id_tarifario_segus { get; set; } //-- Padre de la tabla CVN_TARIFARIO_SEGUS
        public int id_categoria_pago { get; set; }

        public string c_codigo { get; set; }

        public string t_descripcion { get; set; }

        public decimal n_precio_sol { get; set; }

        public decimal n_precio_usd { get; set; }
    }
}

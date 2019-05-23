using System;

namespace ENTIDADES
{
    class TABLAENTRADA
    {
        public int Codigoturno { get; set; }
        public string NIT { get; set; }
        public string Placa { get; set; }
        public string CodigoTipoVehiculo { get; set; }
        public string CodigoTipoServicio { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public int ValorPagar { get; set; }
        public int PorcentajeDescuento { get; set; }
        public int ValorDescuento { get; set; }
        public int TotalServicio { get; set; }
        public DateTime TotalTiempo { get; set; }
        public DateTime FechaIngreso { get; set; }
  
    }
}

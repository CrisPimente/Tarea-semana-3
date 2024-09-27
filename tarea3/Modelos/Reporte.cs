using System;
using System.ComponentModel.DataAnnotations;

class Reporte{
    public string Id = Guid.NewGuid().ToString();
    
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required (ErrorMessage = "El campo Descripcion es requerido")]
    
    public string Descripcion { get; set; } = "";

    public double CostoEstimado { get; set; } = 0;

    public int Muertos { get; set; } = 0;

    public int Heridos { get; set; } = 0;

    public int VehiculosInvolucrados { get; set;} = 0;
}
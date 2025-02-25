using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BarberShop.Models
{
    public class ClientModel
    {
        // Fields
        private int cliente_id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo_electronico;

        //Properties
        [DisplayName("Id Cliente")]
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        [DisplayName("Nombre Cliente")]
        [Required(ErrorMessage ="Nombre de cliente es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Nombre debe tener entre 3 y 50 characters")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DisplayName("Apellido Cliente")]
        [Required(ErrorMessage = "Apellido de cliente es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Apellido debe tener entre 3 y 50 characters")]
        public string Apellido { get => apellido; set => apellido = value; }
        [DisplayName("Telefono Cliente")]
        [StringLength(11, MinimumLength = 3, ErrorMessage = "El numero de telefono debe tener entre 11 characters")]
        public string Telefono { get => telefono; set => telefono = value; }
        [DisplayName("Correo Cliente")]
        public string Correo_Electronico { get => correo_electronico; set => correo_electronico = value; }

    }
}

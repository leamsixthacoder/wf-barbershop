using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop.Views
{
    public interface IClientView
    {
        // Properties - Fields
        string Cliente_id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; } 
        string Telefono { get; set; } 
        string Correo_Electronico { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPetListBindingSource(BindingSource clientList);
        void Show();
    }
}

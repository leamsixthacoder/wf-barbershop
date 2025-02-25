using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop.Views
{
    public partial class ClientView : Form, IClientView
    {
        private string message;
        private bool isSuccesful;
        private bool isEdit;

        public ClientView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(detail_tab);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btn_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            search_client.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public string Cliente_id { get => txt_client_id.Text; set => txt_client_id.Text = value; }
        public string Nombre { get => txt_client_name.Text; set => txt_client_name.Text = value; }
        public string Apellido { get => txt_client_lastname.Text; set => txt_client_lastname.Text = value; }
        public string Telefono { get => txt_client_telefono.Text; set => txt_client_telefono.Text = value; }
        public string Correo_Electronico { get => txt_client_email.Text; set => txt_client_email.Text = value; }
        public string SearchValue { get => search_client.Text; set => search_client.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccesful { get => isSuccesful; set => isSuccesful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource clientList)
        {
            dgv_client.DataSource = clientList;
        }
    }
}

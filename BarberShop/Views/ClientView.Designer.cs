namespace BarberShop.Views
{
    partial class ClientView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.list_tab = new System.Windows.Forms.TabPage();
            this.btn_delete_client = new System.Windows.Forms.Button();
            this.btn_edit_client = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.search_client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detail_tab = new System.Windows.Forms.TabPage();
            this.txt_client_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_client_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_client_lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.list_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.detail_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 59);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.list_tab);
            this.tabControl1.Controls.Add(this.detail_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 549);
            this.tabControl1.TabIndex = 2;
            // 
            // list_tab
            // 
            this.list_tab.Controls.Add(this.btn_delete_client);
            this.list_tab.Controls.Add(this.btn_edit_client);
            this.list_tab.Controls.Add(this.btn_add_client);
            this.list_tab.Controls.Add(this.dgv_client);
            this.list_tab.Controls.Add(this.btn_search);
            this.list_tab.Controls.Add(this.search_client);
            this.list_tab.Controls.Add(this.label2);
            this.list_tab.Location = new System.Drawing.Point(4, 34);
            this.list_tab.Name = "list_tab";
            this.list_tab.Padding = new System.Windows.Forms.Padding(3);
            this.list_tab.Size = new System.Drawing.Size(1004, 511);
            this.list_tab.TabIndex = 0;
            this.list_tab.Text = "Listado Clientes";
            this.list_tab.UseVisualStyleBackColor = true;
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.BackColor = System.Drawing.Color.Red;
            this.btn_delete_client.FlatAppearance.BorderSize = 0;
            this.btn_delete_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_client.Location = new System.Drawing.Point(833, 212);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Size = new System.Drawing.Size(148, 49);
            this.btn_delete_client.TabIndex = 6;
            this.btn_delete_client.Text = "Eliminar Cliente";
            this.btn_delete_client.UseVisualStyleBackColor = false;
            // 
            // btn_edit_client
            // 
            this.btn_edit_client.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_edit_client.FlatAppearance.BorderSize = 0;
            this.btn_edit_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_client.Location = new System.Drawing.Point(833, 147);
            this.btn_edit_client.Name = "btn_edit_client";
            this.btn_edit_client.Size = new System.Drawing.Size(148, 49);
            this.btn_edit_client.TabIndex = 5;
            this.btn_edit_client.Text = "Editar Cliente";
            this.btn_edit_client.UseVisualStyleBackColor = false;
            // 
            // btn_add_client
            // 
            this.btn_add_client.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_add_client.FlatAppearance.BorderSize = 0;
            this.btn_add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.Location = new System.Drawing.Point(833, 77);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(148, 49);
            this.btn_add_client.TabIndex = 4;
            this.btn_add_client.Text = "Añadir Cliente";
            this.btn_add_client.UseVisualStyleBackColor = false;
            // 
            // dgv_client
            // 
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Location = new System.Drawing.Point(40, 77);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.RowHeadersWidth = 51;
            this.dgv_client.RowTemplate.Height = 24;
            this.dgv_client.Size = new System.Drawing.Size(778, 426);
            this.dgv_client.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(721, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // search_client
            // 
            this.search_client.Location = new System.Drawing.Point(40, 41);
            this.search_client.Name = "search_client";
            this.search_client.Size = new System.Drawing.Size(675, 30);
            this.search_client.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente:";
            // 
            // detail_tab
            // 
            this.detail_tab.BackColor = System.Drawing.Color.White;
            this.detail_tab.Controls.Add(this.txt_client_email);
            this.detail_tab.Controls.Add(this.label7);
            this.detail_tab.Controls.Add(this.txt_client_telefono);
            this.detail_tab.Controls.Add(this.label6);
            this.detail_tab.Controls.Add(this.txt_client_lastname);
            this.detail_tab.Controls.Add(this.label5);
            this.detail_tab.Controls.Add(this.txt_client_name);
            this.detail_tab.Controls.Add(this.label4);
            this.detail_tab.Controls.Add(this.txt_client_id);
            this.detail_tab.Controls.Add(this.label3);
            this.detail_tab.Location = new System.Drawing.Point(4, 34);
            this.detail_tab.Name = "detail_tab";
            this.detail_tab.Padding = new System.Windows.Forms.Padding(3);
            this.detail_tab.Size = new System.Drawing.Size(1004, 511);
            this.detail_tab.TabIndex = 1;
            this.detail_tab.Text = "Detalle Cliente";
            // 
            // txt_client_email
            // 
            this.txt_client_email.Location = new System.Drawing.Point(513, 259);
            this.txt_client_email.Name = "txt_client_email";
            this.txt_client_email.Size = new System.Drawing.Size(453, 30);
            this.txt_client_email.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Correo Electronico";
            // 
            // txt_client_telefono
            // 
            this.txt_client_telefono.Location = new System.Drawing.Point(35, 259);
            this.txt_client_telefono.Name = "txt_client_telefono";
            this.txt_client_telefono.Size = new System.Drawing.Size(453, 30);
            this.txt_client_telefono.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono";
            // 
            // txt_client_lastname
            // 
            this.txt_client_lastname.Location = new System.Drawing.Point(514, 167);
            this.txt_client_lastname.Name = "txt_client_lastname";
            this.txt_client_lastname.Size = new System.Drawing.Size(453, 30);
            this.txt_client_lastname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Location = new System.Drawing.Point(34, 167);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(453, 30);
            this.txt_client_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres";
            // 
            // txt_client_id
            // 
            this.txt_client_id.Location = new System.Drawing.Point(34, 61);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(151, 30);
            this.txt_client_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente Id:";
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientView";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.list_tab.ResumeLayout(false);
            this.list_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.detail_tab.ResumeLayout(false);
            this.detail_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage list_tab;
        private System.Windows.Forms.TabPage detail_tab;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox search_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete_client;
        private System.Windows.Forms.Button btn_edit_client;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_client_id;
        private System.Windows.Forms.TextBox txt_client_lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_client_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_client_email;
        private System.Windows.Forms.Label label7;
    }
}
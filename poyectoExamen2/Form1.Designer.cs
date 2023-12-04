namespace poyectoExamen2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.emailUsuarioTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.otroUsuarioTxt = new MaterialSkin.Controls.MaterialRadioButton();
            this.GuardarEmpleadoBtn = new MaterialSkin.Controls.MaterialButton();
            this.mujerUsuarioTxt = new MaterialSkin.Controls.MaterialRadioButton();
            this.hombreUsuarioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.direccionUsuarioTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.apellidoUsuarioTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.nombreUsuarioTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lista = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuscarUsuarioBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1568, 700);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialDrawer1);
            this.tabPage3.Controls.Add(this.emailUsuarioTxt);
            this.tabPage3.Controls.Add(this.otroUsuarioTxt);
            this.tabPage3.Controls.Add(this.GuardarEmpleadoBtn);
            this.tabPage3.Controls.Add(this.mujerUsuarioTxt);
            this.tabPage3.Controls.Add(this.hombreUsuarioBtn);
            this.tabPage3.Controls.Add(this.direccionUsuarioTxt);
            this.tabPage3.Controls.Add(this.apellidoUsuarioTxt);
            this.tabPage3.Controls.Add(this.nombreUsuarioTxt);
            this.tabPage3.ImageKey = "icons8-persona-30.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1560, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-333, 379);
            this.materialDrawer1.Margin = new System.Windows.Forms.Padding(4);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(333, 148);
            this.materialDrawer1.TabIndex = 12;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // emailUsuarioTxt
            // 
            this.emailUsuarioTxt.AnimateReadOnly = false;
            this.emailUsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailUsuarioTxt.Depth = 0;
            this.emailUsuarioTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailUsuarioTxt.Hint = "Email:";
            this.emailUsuarioTxt.LeadingIcon = null;
            this.emailUsuarioTxt.Location = new System.Drawing.Point(33, 351);
            this.emailUsuarioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailUsuarioTxt.MaxLength = 50;
            this.emailUsuarioTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.emailUsuarioTxt.Multiline = false;
            this.emailUsuarioTxt.Name = "emailUsuarioTxt";
            this.emailUsuarioTxt.Size = new System.Drawing.Size(613, 50);
            this.emailUsuarioTxt.TabIndex = 10;
            this.emailUsuarioTxt.Text = "";
            this.emailUsuarioTxt.TrailingIcon = null;
            // 
            // otroUsuarioTxt
            // 
            this.otroUsuarioTxt.AutoSize = true;
            this.otroUsuarioTxt.Depth = 0;
            this.otroUsuarioTxt.Location = new System.Drawing.Point(285, 417);
            this.otroUsuarioTxt.Margin = new System.Windows.Forms.Padding(0);
            this.otroUsuarioTxt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.otroUsuarioTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.otroUsuarioTxt.Name = "otroUsuarioTxt";
            this.otroUsuarioTxt.Ripple = true;
            this.otroUsuarioTxt.Size = new System.Drawing.Size(65, 37);
            this.otroUsuarioTxt.TabIndex = 9;
            this.otroUsuarioTxt.TabStop = true;
            this.otroUsuarioTxt.Text = "Otro";
            this.otroUsuarioTxt.UseVisualStyleBackColor = true;
            // 
            // GuardarEmpleadoBtn
            // 
            this.GuardarEmpleadoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GuardarEmpleadoBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GuardarEmpleadoBtn.Depth = 0;
            this.GuardarEmpleadoBtn.HighEmphasis = true;
            this.GuardarEmpleadoBtn.Icon = null;
            this.GuardarEmpleadoBtn.Location = new System.Drawing.Point(33, 513);
            this.GuardarEmpleadoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GuardarEmpleadoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarEmpleadoBtn.Name = "GuardarEmpleadoBtn";
            this.GuardarEmpleadoBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GuardarEmpleadoBtn.Size = new System.Drawing.Size(99, 36);
            this.GuardarEmpleadoBtn.TabIndex = 8;
            this.GuardarEmpleadoBtn.Text = "REGISTRAR";
            this.GuardarEmpleadoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GuardarEmpleadoBtn.UseAccentColor = false;
            this.GuardarEmpleadoBtn.UseVisualStyleBackColor = true;
            this.GuardarEmpleadoBtn.Click += new System.EventHandler(this.GuardarEmpleadoBtn_Click_1);
            // 
            // mujerUsuarioTxt
            // 
            this.mujerUsuarioTxt.AutoSize = true;
            this.mujerUsuarioTxt.Depth = 0;
            this.mujerUsuarioTxt.Location = new System.Drawing.Point(169, 416);
            this.mujerUsuarioTxt.Margin = new System.Windows.Forms.Padding(0);
            this.mujerUsuarioTxt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mujerUsuarioTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mujerUsuarioTxt.Name = "mujerUsuarioTxt";
            this.mujerUsuarioTxt.Ripple = true;
            this.mujerUsuarioTxt.Size = new System.Drawing.Size(75, 37);
            this.mujerUsuarioTxt.TabIndex = 7;
            this.mujerUsuarioTxt.TabStop = true;
            this.mujerUsuarioTxt.Text = "Mujer";
            this.mujerUsuarioTxt.UseVisualStyleBackColor = true;
            // 
            // hombreUsuarioBtn
            // 
            this.hombreUsuarioBtn.AutoSize = true;
            this.hombreUsuarioBtn.Depth = 0;
            this.hombreUsuarioBtn.Location = new System.Drawing.Point(32, 417);
            this.hombreUsuarioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.hombreUsuarioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hombreUsuarioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.hombreUsuarioBtn.Name = "hombreUsuarioBtn";
            this.hombreUsuarioBtn.Ripple = true;
            this.hombreUsuarioBtn.Size = new System.Drawing.Size(91, 37);
            this.hombreUsuarioBtn.TabIndex = 6;
            this.hombreUsuarioBtn.TabStop = true;
            this.hombreUsuarioBtn.Text = "Hombre";
            this.hombreUsuarioBtn.UseVisualStyleBackColor = true;
            // 
            // direccionUsuarioTxt
            // 
            this.direccionUsuarioTxt.AnimateReadOnly = false;
            this.direccionUsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionUsuarioTxt.Depth = 0;
            this.direccionUsuarioTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.direccionUsuarioTxt.Hint = "Dirección:";
            this.direccionUsuarioTxt.LeadingIcon = null;
            this.direccionUsuarioTxt.Location = new System.Drawing.Point(33, 258);
            this.direccionUsuarioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccionUsuarioTxt.MaxLength = 50;
            this.direccionUsuarioTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.direccionUsuarioTxt.Multiline = false;
            this.direccionUsuarioTxt.Name = "direccionUsuarioTxt";
            this.direccionUsuarioTxt.Size = new System.Drawing.Size(613, 50);
            this.direccionUsuarioTxt.TabIndex = 4;
            this.direccionUsuarioTxt.Text = "";
            this.direccionUsuarioTxt.TrailingIcon = null;
            // 
            // apellidoUsuarioTxt
            // 
            this.apellidoUsuarioTxt.AnimateReadOnly = false;
            this.apellidoUsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellidoUsuarioTxt.Depth = 0;
            this.apellidoUsuarioTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.apellidoUsuarioTxt.Hint = "Apellidos:";
            this.apellidoUsuarioTxt.LeadingIcon = null;
            this.apellidoUsuarioTxt.Location = new System.Drawing.Point(33, 149);
            this.apellidoUsuarioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellidoUsuarioTxt.MaxLength = 50;
            this.apellidoUsuarioTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.apellidoUsuarioTxt.Multiline = false;
            this.apellidoUsuarioTxt.Name = "apellidoUsuarioTxt";
            this.apellidoUsuarioTxt.Size = new System.Drawing.Size(613, 50);
            this.apellidoUsuarioTxt.TabIndex = 3;
            this.apellidoUsuarioTxt.Text = "";
            this.apellidoUsuarioTxt.TrailingIcon = null;
            // 
            // nombreUsuarioTxt
            // 
            this.nombreUsuarioTxt.AnimateReadOnly = false;
            this.nombreUsuarioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreUsuarioTxt.Depth = 0;
            this.nombreUsuarioTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nombreUsuarioTxt.Hint = "Nombre:";
            this.nombreUsuarioTxt.LeadingIcon = null;
            this.nombreUsuarioTxt.Location = new System.Drawing.Point(33, 54);
            this.nombreUsuarioTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreUsuarioTxt.MaxLength = 50;
            this.nombreUsuarioTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.nombreUsuarioTxt.Multiline = false;
            this.nombreUsuarioTxt.Name = "nombreUsuarioTxt";
            this.nombreUsuarioTxt.Size = new System.Drawing.Size(613, 50);
            this.nombreUsuarioTxt.TabIndex = 0;
            this.nombreUsuarioTxt.Text = "";
            this.nombreUsuarioTxt.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lista);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.materialListView2);
            this.tabPage2.ImageKey = "icons8-factura-30.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1560, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Factura";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.AutoScroll = true;
            this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista.Location = new System.Drawing.Point(3, 91);
            this.lista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1554, 566);
            this.lista.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BuscarUsuarioBtn);
            this.panel1.Controls.Add(this.materialTextBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 89);
            this.panel1.TabIndex = 1;
            // 
            // BuscarUsuarioBtn
            // 
            this.BuscarUsuarioBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuscarUsuarioBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BuscarUsuarioBtn.Depth = 0;
            this.BuscarUsuarioBtn.HighEmphasis = true;
            this.BuscarUsuarioBtn.Icon = null;
            this.BuscarUsuarioBtn.Location = new System.Drawing.Point(447, 20);
            this.BuscarUsuarioBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BuscarUsuarioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuscarUsuarioBtn.Name = "BuscarUsuarioBtn";
            this.BuscarUsuarioBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BuscarUsuarioBtn.Size = new System.Drawing.Size(77, 36);
            this.BuscarUsuarioBtn.TabIndex = 1;
            this.BuscarUsuarioBtn.Text = "BUSCAR";
            this.BuscarUsuarioBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BuscarUsuarioBtn.UseAccentColor = false;
            this.BuscarUsuarioBtn.UseVisualStyleBackColor = true;
            this.BuscarUsuarioBtn.Click += new System.EventHandler(this.BuscarUsuarioBtn_Click);
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.Hint = "Nombre Cliente:";
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(13, 14);
            this.materialTextBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(404, 50);
            this.materialTextBox6.TabIndex = 0;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialListView2
            // 
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Depth = 0;
            this.materialListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(3, 2);
            this.materialListView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(1554, 655);
            this.materialListView2.TabIndex = 0;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1560, 659);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1560, 659);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Cerrar sección";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-persona-30.png");
            this.imageList1.Images.SetKeyName(1, "icons8-factura-30.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 766);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1259, 766);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Proyecto Examen";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox nombreUsuarioTxt;
        private MaterialSkin.Controls.MaterialTextBox direccionUsuarioTxt;
        private MaterialSkin.Controls.MaterialTextBox apellidoUsuarioTxt;
        private MaterialSkin.Controls.MaterialRadioButton mujerUsuarioTxt;
        private MaterialSkin.Controls.MaterialRadioButton hombreUsuarioBtn;
        private MaterialSkin.Controls.MaterialButton GuardarEmpleadoBtn;
        private MaterialSkin.Controls.MaterialRadioButton otroUsuarioTxt;
        private MaterialSkin.Controls.MaterialTextBox emailUsuarioTxt;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private MaterialSkin.Controls.MaterialButton BuscarUsuarioBtn;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private System.Windows.Forms.FlowLayoutPanel lista;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}


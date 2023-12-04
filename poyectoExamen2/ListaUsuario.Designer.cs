namespace poyectoExamen2
{
    partial class ListaUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuario));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.correo = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.numeroTelefono = new MaterialSkin.Controls.MaterialLabel();
            this.cargoLaboral = new MaterialSkin.Controls.MaterialLabel();
            this.numeroCedula = new MaterialSkin.Controls.MaterialLabel();
            this.fechaCumpleaños = new MaterialSkin.Controls.MaterialLabel();
            this.nombres = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox5);
            this.materialCard1.Controls.Add(this.pictureBox4);
            this.materialCard1.Controls.Add(this.pictureBox3);
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.correo);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.FotoPerfil);
            this.materialCard1.Controls.Add(this.numeroTelefono);
            this.materialCard1.Controls.Add(this.cargoLaboral);
            this.materialCard1.Controls.Add(this.numeroCedula);
            this.materialCard1.Controls.Add(this.fechaCumpleaños);
            this.materialCard1.Controls.Add(this.nombres);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(690, 153);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.MouseEnter += new System.EventHandler(this.ListaUsuario_MouseEnter);
            this.materialCard1.MouseLeave += new System.EventHandler(this.ListaUsuario_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::poyectoExamen2.Properties.Resources.icons8_correo_20;
            this.pictureBox5.Location = new System.Drawing.Point(646, 105);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::poyectoExamen2.Properties.Resources.icons8_cumpleaños_20;
            this.pictureBox4.Location = new System.Drawing.Point(646, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::poyectoExamen2.Properties.Resources.icons8_teléfono_sin_utilizar_20;
            this.pictureBox3.Location = new System.Drawing.Point(646, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::poyectoExamen2.Properties.Resources.icons8_identity_card_20;
            this.pictureBox2.Location = new System.Drawing.Point(646, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Depth = 0;
            this.correo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.correo.ImageList = this.imageList1;
            this.correo.Location = new System.Drawing.Point(430, 105);
            this.correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(210, 19);
            this.correo.TabIndex = 8;
            this.correo.Text = "edwin.noviember@gmial.com";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-identity-card-20.png");
            this.imageList1.Images.SetKeyName(1, "icons8-teléfono-sin-utilizar-20.png");
            this.imageList1.Images.SetKeyName(2, "icons8-cumpleaños-20.png");
            this.imageList1.Images.SetKeyName(3, "icons8-correo-20.png");
            this.imageList1.Images.SetKeyName(4, "icons8-maletín-20.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::poyectoExamen2.Properties.Resources.icons8_maletín_20;
            this.pictureBox1.Location = new System.Drawing.Point(160, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Image = global::poyectoExamen2.Properties.Resources.Imagen_de_WhatsApp_2023_10_25_a_las_16_09_47_bc72a12e_removebg_preview;
            this.FotoPerfil.Location = new System.Drawing.Point(17, 17);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(100, 90);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoPerfil.TabIndex = 6;
            this.FotoPerfil.TabStop = false;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.AutoSize = true;
            this.numeroTelefono.Depth = 0;
            this.numeroTelefono.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numeroTelefono.ImageList = this.imageList1;
            this.numeroTelefono.Location = new System.Drawing.Point(563, 58);
            this.numeroTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.Size = new System.Drawing.Size(77, 19);
            this.numeroTelefono.TabIndex = 5;
            this.numeroTelefono.Text = "0000-0000";
            // 
            // cargoLaboral
            // 
            this.cargoLaboral.AutoSize = true;
            this.cargoLaboral.Depth = 0;
            this.cargoLaboral.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cargoLaboral.ImageList = this.imageList1;
            this.cargoLaboral.Location = new System.Drawing.Point(197, 61);
            this.cargoLaboral.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargoLaboral.Name = "cargoLaboral";
            this.cargoLaboral.Size = new System.Drawing.Size(113, 19);
            this.cargoLaboral.TabIndex = 1;
            this.cargoLaboral.Text = "Gerente General";
            // 
            // numeroCedula
            // 
            this.numeroCedula.AutoSize = true;
            this.numeroCedula.Depth = 0;
            this.numeroCedula.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numeroCedula.ImageKey = "icons8-identity-card-20.png";
            this.numeroCedula.ImageList = this.imageList1;
            this.numeroCedula.Location = new System.Drawing.Point(509, 34);
            this.numeroCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.numeroCedula.Name = "numeroCedula";
            this.numeroCedula.Size = new System.Drawing.Size(131, 19);
            this.numeroCedula.TabIndex = 3;
            this.numeroCedula.Text = "001-31104-1010W";
            // 
            // fechaCumpleaños
            // 
            this.fechaCumpleaños.AutoSize = true;
            this.fechaCumpleaños.Depth = 0;
            this.fechaCumpleaños.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaCumpleaños.ImageList = this.imageList1;
            this.fechaCumpleaños.Location = new System.Drawing.Point(553, 83);
            this.fechaCumpleaños.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaCumpleaños.Name = "fechaCumpleaños";
            this.fechaCumpleaños.Size = new System.Drawing.Size(87, 19);
            this.fechaCumpleaños.TabIndex = 2;
            this.fechaCumpleaños.Text = "03/11/2004";
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Depth = 0;
            this.nombres.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nombres.Location = new System.Drawing.Point(130, 34);
            this.nombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(222, 19);
            this.nombres.TabIndex = 0;
            this.nombres.Text = "Saulo Miguel Cladera Gonzalez";
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialCard1);
            this.Name = "ListaUsuario";
            this.Size = new System.Drawing.Size(690, 153);
            this.MouseEnter += new System.EventHandler(this.ListaUsuario_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListaUsuario_MouseLeave);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel numeroTelefono;
        private MaterialSkin.Controls.MaterialLabel cargoLaboral;
        private MaterialSkin.Controls.MaterialLabel numeroCedula;
        private MaterialSkin.Controls.MaterialLabel fechaCumpleaños;
        private MaterialSkin.Controls.MaterialLabel nombres;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel correo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ImageList imageList1;
    }
}

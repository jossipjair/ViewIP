
namespace ViewIp
{
    partial class FrmViewIP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.LvIPRespuesta = new System.Windows.Forms.ListView();
            this.BtnFindIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIpActual = new System.Windows.Forms.Label();
            this.chIpRespuesta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.LvIPRespuesta);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ip Sin Respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP Respuesta";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(198, 35);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(163, 172);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // LvIPRespuesta
            // 
            this.LvIPRespuesta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIpRespuesta});
            this.LvIPRespuesta.FullRowSelect = true;
            this.LvIPRespuesta.HideSelection = false;
            this.LvIPRespuesta.Location = new System.Drawing.Point(14, 35);
            this.LvIPRespuesta.MultiSelect = false;
            this.LvIPRespuesta.Name = "LvIPRespuesta";
            this.LvIPRespuesta.Size = new System.Drawing.Size(163, 172);
            this.LvIPRespuesta.TabIndex = 0;
            this.LvIPRespuesta.UseCompatibleStateImageBehavior = false;
            // 
            // BtnFindIP
            // 
            this.BtnFindIP.BackgroundImage = global::ViewIp.Properties.Resources.buscando;
            this.BtnFindIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFindIP.Location = new System.Drawing.Point(460, 143);
            this.BtnFindIP.Name = "BtnFindIP";
            this.BtnFindIP.Size = new System.Drawing.Size(66, 66);
            this.BtnFindIP.TabIndex = 1;
            this.BtnFindIP.UseVisualStyleBackColor = true;
            this.BtnFindIP.Click += new System.EventHandler(this.BtnFindIP_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(409, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP ACTUAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtIpActual
            // 
            this.TxtIpActual.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIpActual.Location = new System.Drawing.Point(406, 37);
            this.TxtIpActual.Name = "TxtIpActual";
            this.TxtIpActual.Size = new System.Drawing.Size(183, 33);
            this.TxtIpActual.TabIndex = 3;
            this.TxtIpActual.Text = "0.0.0.0";
            this.TxtIpActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chIpRespuesta
            // 
            this.chIpRespuesta.Text = "Ip con Respuesta";
            // 
            // FrmViewIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 224);
            this.Controls.Add(this.TxtIpActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFindIP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewIP";
            this.Text = "ViewIP";
            this.Load += new System.EventHandler(this.FrmViewIP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView LvIPRespuesta;
        private System.Windows.Forms.Button BtnFindIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtIpActual;
        private System.Windows.Forms.ColumnHeader chIpRespuesta;
    }
}


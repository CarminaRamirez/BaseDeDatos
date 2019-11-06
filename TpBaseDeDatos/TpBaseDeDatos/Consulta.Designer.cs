namespace TpBaseDeDatos
{
    partial class Consulta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocheras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mconstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mterre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Zona";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Propiedades de una zona";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.tipodoc,
            this.nrodoc,
            this.zona,
            this.fecha,
            this.constr,
            this.dormi,
            this.baños,
            this.cocheras,
            this.mconstr,
            this.mterre,
            this.ori,
            this.ofer,
            this.valor,
            this.fechaprecio});
            this.dataGridView1.Location = new System.Drawing.Point(45, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(921, 124);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(45, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(45, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nro
            // 
            this.nro.HeaderText = "Nro Propiedad";
            this.nro.Name = "nro";
            this.nro.Visible = false;
            // 
            // tipodoc
            // 
            this.tipodoc.HeaderText = "Tipo Doc Propietario";
            this.tipodoc.Name = "tipodoc";
            this.tipodoc.Visible = false;
            // 
            // nrodoc
            // 
            this.nrodoc.HeaderText = "Nro Doc Propietario";
            this.nrodoc.Name = "nrodoc";
            this.nrodoc.Visible = false;
            // 
            // zona
            // 
            this.zona.HeaderText = "Nro Zona";
            this.zona.Name = "zona";
            this.zona.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Ingreso";
            this.fecha.Name = "fecha";
            this.fecha.Visible = false;
            // 
            // constr
            // 
            this.constr.HeaderText = "Tipo Construcción";
            this.constr.Name = "constr";
            this.constr.Visible = false;
            // 
            // dormi
            // 
            this.dormi.HeaderText = "Cant Dormitorios";
            this.dormi.Name = "dormi";
            this.dormi.Visible = false;
            // 
            // baños
            // 
            this.baños.HeaderText = "Cant Baños";
            this.baños.Name = "baños";
            this.baños.Visible = false;
            // 
            // cocheras
            // 
            this.cocheras.HeaderText = "Cant Cocheras";
            this.cocheras.Name = "cocheras";
            this.cocheras.Visible = false;
            // 
            // mconstr
            // 
            this.mconstr.HeaderText = "M2 Construidos";
            this.mconstr.Name = "mconstr";
            this.mconstr.Visible = false;
            // 
            // mterre
            // 
            this.mterre.HeaderText = "M2 Terreno";
            this.mterre.Name = "mterre";
            this.mterre.Visible = false;
            // 
            // ori
            // 
            this.ori.HeaderText = "Orientación";
            this.ori.Name = "ori";
            this.ori.Visible = false;
            // 
            // ofer
            // 
            this.ofer.HeaderText = "Modalidad Oferta";
            this.ofer.Name = "ofer";
            this.ofer.Visible = false;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.Visible = false;
            // 
            // fechaprecio
            // 
            this.fechaprecio.HeaderText = "Fecha Act Precio";
            this.fechaprecio.Name = "fechaprecio";
            this.fechaprecio.Visible = false;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1007, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn constr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormi;
        private System.Windows.Forms.DataGridViewTextBoxColumn baños;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocheras;
        private System.Windows.Forms.DataGridViewTextBoxColumn mconstr;
        private System.Windows.Forms.DataGridViewTextBoxColumn mterre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprecio;
    }
}
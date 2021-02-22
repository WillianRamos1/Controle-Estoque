
namespace CapaApresentacao
{
    partial class FrmMarcas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FecharForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabelaMarca = new System.Windows.Forms.DataGridView();
            this.btnNOVO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.RadiusElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDeletar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FecharForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // TopForm
            // 
            this.TopForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.TopForm.Controls.Add(this.label1);
            this.TopForm.Controls.Add(this.FecharForm);
            this.TopForm.Controls.Add(this.pictureBox1);
            this.TopForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopForm.Location = new System.Drawing.Point(0, 0);
            this.TopForm.Name = "TopForm";
            this.TopForm.Size = new System.Drawing.Size(1090, 44);
            this.TopForm.TabIndex = 0;
            this.TopForm.Paint += new System.Windows.Forms.PaintEventHandler(this.TopForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MARCAS";
            // 
            // FecharForm
            // 
            this.FecharForm.ErrorImage = null;
            this.FecharForm.Image = ((System.Drawing.Image)(resources.GetObject("FecharForm.Image")));
            this.FecharForm.Location = new System.Drawing.Point(1048, 6);
            this.FecharForm.Name = "FecharForm";
            this.FecharForm.Size = new System.Drawing.Size(30, 30);
            this.FecharForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FecharForm.TabIndex = 2;
            this.FecharForm.TabStop = false;
            this.FecharForm.Click += new System.EventHandler(this.FecharForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Mover
            // 
            this.Mover.Fixed = true;
            this.Mover.Horizontal = true;
            this.Mover.TargetControl = this.TopForm;
            this.Mover.Vertical = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.txtPesquisar.Location = new System.Drawing.Point(64, 91);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(365, 21);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "COD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(84, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(253, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // TabelaMarca
            // 
            this.TabelaMarca.AllowUserToAddRows = false;
            this.TabelaMarca.AllowUserToDeleteRows = false;
            this.TabelaMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TabelaMarca.BackgroundColor = System.Drawing.Color.White;
            this.TabelaMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TabelaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaMarca.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaMarca.DefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaMarca.Location = new System.Drawing.Point(18, 184);
            this.TabelaMarca.Name = "TabelaMarca";
            this.TabelaMarca.ReadOnly = true;
            this.TabelaMarca.RowHeadersVisible = false;
            this.TabelaMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaMarca.Size = new System.Drawing.Size(590, 293);
            this.TabelaMarca.TabIndex = 8;
            this.TabelaMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaMarca_CellContentClick);
            // 
            // btnNOVO
            // 
            this.btnNOVO.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnNOVO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnNOVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNOVO.BorderRadius = 7;
            this.btnNOVO.ButtonText = "NOVO";
            this.btnNOVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNOVO.DisabledColor = System.Drawing.Color.Gray;
            this.btnNOVO.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNOVO.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNOVO.Iconimage")));
            this.btnNOVO.Iconimage_right = null;
            this.btnNOVO.Iconimage_right_Selected = null;
            this.btnNOVO.Iconimage_Selected = null;
            this.btnNOVO.IconMarginLeft = 0;
            this.btnNOVO.IconMarginRight = 0;
            this.btnNOVO.IconRightVisible = true;
            this.btnNOVO.IconRightZoom = 0D;
            this.btnNOVO.IconVisible = true;
            this.btnNOVO.IconZoom = 60D;
            this.btnNOVO.IsTab = false;
            this.btnNOVO.Location = new System.Drawing.Point(13, 513);
            this.btnNOVO.Name = "btnNOVO";
            this.btnNOVO.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnNOVO.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnNOVO.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNOVO.selected = false;
            this.btnNOVO.Size = new System.Drawing.Size(178, 48);
            this.btnNOVO.TabIndex = 9;
            this.btnNOVO.Text = "NOVO";
            this.btnNOVO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNOVO.Textcolor = System.Drawing.Color.White;
            this.btnNOVO.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNOVO.Click += new System.EventHandler(this.btnNOVO_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 7;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 60D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(245, 513);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(178, 48);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 7;
            this.btnSalvar.ButtonText = "SALVAR";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Iconimage")));
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = true;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = true;
            this.btnSalvar.IconZoom = 60D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(741, 513);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(337, 48);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Textcolor = System.Drawing.Color.White;
            this.btnSalvar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderRadius = 7;
            this.btnImprimir.ButtonText = "IMPRIMIR";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Iconimage")));
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 60D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(649, 76);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(178, 48);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 7;
            this.btnExcel.ButtonText = "EXCEL";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcel.Iconimage")));
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 60D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(900, 76);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnExcel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(178, 48);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(649, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(649, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "CODIGO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(649, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "NOME";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(649, 278);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(429, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(649, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "DESCRIÇÃO";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(649, 371);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(429, 122);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.txtCodigo.Location = new System.Drawing.Point(659, 198);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 21);
            this.txtCodigo.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(659, 294);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(406, 21);
            this.txtNome.TabIndex = 22;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.txtDescricao.Location = new System.Drawing.Point(659, 387);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(406, 87);
            this.txtDescricao.TabIndex = 23;
            // 
            // RadiusElipse
            // 
            this.RadiusElipse.ElipseRadius = 7;
            this.RadiusElipse.TargetControl = this;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.BorderRadius = 7;
            this.btnDeletar.ButtonText = "DELETAR";
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Iconimage")));
            this.btnDeletar.Iconimage_right = null;
            this.btnDeletar.Iconimage_right_Selected = null;
            this.btnDeletar.Iconimage_Selected = null;
            this.btnDeletar.IconMarginLeft = 0;
            this.btnDeletar.IconMarginRight = 0;
            this.btnDeletar.IconRightVisible = true;
            this.btnDeletar.IconRightZoom = 0D;
            this.btnDeletar.IconVisible = true;
            this.btnDeletar.IconZoom = 60D;
            this.btnDeletar.IsTab = false;
            this.btnDeletar.Location = new System.Drawing.Point(482, 513);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDeletar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnDeletar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletar.selected = false;
            this.btnDeletar.Size = new System.Drawing.Size(178, 48);
            this.btnDeletar.TabIndex = 24;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletar.Textcolor = System.Drawing.Color.White;
            this.btnDeletar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 573);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNOVO);
            this.Controls.Add(this.TabelaMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarcas";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.TopForm.ResumeLayout(false);
            this.TopForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FecharForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FecharForm;
        private Bunifu.Framework.UI.BunifuDragControl Mover;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TabelaMarca;
        private Bunifu.Framework.UI.BunifuFlatButton btnNOVO;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private Bunifu.Framework.UI.BunifuElipse RadiusElipse;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletar;
    }
}
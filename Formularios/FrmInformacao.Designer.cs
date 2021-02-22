
namespace CapaApresentacao
{
    partial class FrmInformacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacao));
            this.elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormEsclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAceitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse2
            // 
            this.elipse2.ElipseRadius = 7;
            this.elipse2.TargetControl = this;
            // 
            // FormEsclarecer
            // 
            this.FormEsclarecer.Delay = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 243);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVISO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceitar.BorderRadius = 7;
            this.btnAceitar.ButtonText = "ACEITAR";
            this.btnAceitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceitar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceitar.Iconimage = null;
            this.btnAceitar.Iconimage_right = null;
            this.btnAceitar.Iconimage_right_Selected = null;
            this.btnAceitar.Iconimage_Selected = null;
            this.btnAceitar.IconMarginLeft = 0;
            this.btnAceitar.IconMarginRight = 0;
            this.btnAceitar.IconRightVisible = true;
            this.btnAceitar.IconRightZoom = 0D;
            this.btnAceitar.IconVisible = true;
            this.btnAceitar.IconZoom = 90D;
            this.btnAceitar.IsTab = false;
            this.btnAceitar.Location = new System.Drawing.Point(12, 440);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceitar.selected = false;
            this.btnAceitar.Size = new System.Drawing.Size(140, 48);
            this.btnAceitar.TabIndex = 7;
            this.btnAceitar.Text = "ACEITAR";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceitar.Textcolor = System.Drawing.Color.White;
            this.btnAceitar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha uma das opções abaixo.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(12, 273);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(346, 23);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "MENSAGEM";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 7;
            this.btnCancelar.ButtonText = "CANCELAR";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(218, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(140, 48);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformacao";
            this.Load += new System.EventHandler(this.FrmInformacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensagem;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormEsclarecer;
    }
}
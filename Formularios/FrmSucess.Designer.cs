
namespace CapaApresentacao
{
    partial class FrmSucess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucess));
            this.elipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormEsclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceitar = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 243);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(12, 259);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(346, 23);
            this.lblMensagem.TabIndex = 1;
            this.lblMensagem.Text = "MENSAGEM";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 75);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ação concluida com sucesso.\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAceitar.Location = new System.Drawing.Point(83, 424);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(133)))));
            this.btnAceitar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceitar.selected = false;
            this.btnAceitar.Size = new System.Drawing.Size(201, 48);
            this.btnAceitar.TabIndex = 3;
            this.btnAceitar.Text = "ACEITAR";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceitar.Textcolor = System.Drawing.Color.White;
            this.btnAceitar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // FrmSucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 500);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSucess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSucess";
            this.Load += new System.EventHandler(this.FrmSucess_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormEsclarecer;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
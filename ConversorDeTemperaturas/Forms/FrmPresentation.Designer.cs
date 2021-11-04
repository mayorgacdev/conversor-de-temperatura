
namespace ConversorDeTemperaturas.Forms
{
    partial class FrmPresentation
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
            this.dataResumen = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAresumen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDeResumen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDe = new System.Windows.Forms.ComboBox();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataResumen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataResumen
            // 
            this.dataResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResumen.Location = new System.Drawing.Point(20, 77);
            this.dataResumen.Name = "dataResumen";
            this.dataResumen.RowTemplate.Height = 25;
            this.dataResumen.Size = new System.Drawing.Size(676, 335);
            this.dataResumen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(320, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "A:";
            // 
            // cmbAresumen
            // 
            this.cmbAresumen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAresumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAresumen.FormattingEnabled = true;
            this.cmbAresumen.Location = new System.Drawing.Point(355, 33);
            this.cmbAresumen.Name = "cmbAresumen";
            this.cmbAresumen.Size = new System.Drawing.Size(193, 28);
            this.cmbAresumen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "De:";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGo.Location = new System.Drawing.Point(579, 32);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 31);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemperatura.Location = new System.Drawing.Point(170, 65);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(467, 23);
            this.txtTemperatura.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataResumen);
            this.groupBox1.Controls.Add(this.cmbDeResumen);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.cmbAresumen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 442);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen de conversiones";
            // 
            // cmbDeResumen
            // 
            this.cmbDeResumen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDeResumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeResumen.FormattingEnabled = true;
            this.cmbDeResumen.Location = new System.Drawing.Point(66, 33);
            this.cmbDeResumen.Name = "cmbDeResumen";
            this.cmbDeResumen.Size = new System.Drawing.Size(239, 28);
            this.cmbDeResumen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Conversion de temperaturas";
            // 
            // cmbDe
            // 
            this.cmbDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDe.FormattingEnabled = true;
            this.cmbDe.Location = new System.Drawing.Point(123, 31);
            this.cmbDe.Name = "cmbDe";
            this.cmbDe.Size = new System.Drawing.Size(226, 28);
            this.cmbDe.TabIndex = 14;
            // 
            // cmbA
            // 
            this.cmbA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(401, 31);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(236, 28);
            this.cmbA.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "A:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Temperatura:";
            // 
            // btnCalculos
            // 
            this.btnCalculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculos.Location = new System.Drawing.Point(93, 94);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(544, 23);
            this.btnCalculos.TabIndex = 19;
            this.btnCalculos.Text = "Calcular";
            this.btnCalculos.UseVisualStyleBackColor = true;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculos);
            this.groupBox2.Controls.Add(this.txtTemperatura);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbDe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbA);
            this.groupBox2.Location = new System.Drawing.Point(16, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 137);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FrmPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPresentation";
            this.Text = "FrmPresentation";
            this.Load += new System.EventHandler(this.FrmPresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResumen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataResumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAresumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDe;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.ComboBox cmbDeResumen;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
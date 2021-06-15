
namespace ProyectoEquipoSimulacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbXo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumaNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lbldisnor2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValorAcumulado = new System.Windows.Forms.TextBox();
            this.txtPiAprox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimites = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLimSupPi = new System.Windows.Forms.TextBox();
            this.txtLimInfPi = new System.Windows.Forms.TextBox();
            this.labelPi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoCorridas = new System.Windows.Forms.TextBox();
            this.dataGridViewPi = new System.Windows.Forms.DataGridView();
            this.NoCorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "M:";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(88, 57);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(108, 20);
            this.tbA.TabIndex = 4;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(88, 83);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(108, 20);
            this.tbC.TabIndex = 5;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(88, 135);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(108, 20);
            this.tbM.TabIndex = 7;
            this.tbM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbM_KeyPress);
            // 
            // tbXo
            // 
            this.tbXo.Location = new System.Drawing.Point(88, 109);
            this.tbXo.Name = "tbXo";
            this.tbXo.Size = new System.Drawing.Size(108, 20);
            this.tbXo.TabIndex = 6;
            this.tbXo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbXo_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNumero,
            this.ColumaNumeroGenerado});
            this.dataGridView1.Location = new System.Drawing.Point(48, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 268);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColumnaNumero
            // 
            this.ColumnaNumero.HeaderText = "Numero";
            this.ColumnaNumero.Name = "ColumnaNumero";
            // 
            // ColumaNumeroGenerado
            // 
            this.ColumaNumeroGenerado.HeaderText = "Numero Pseudoalatorio";
            this.ColumaNumeroGenerado.Name = "ColumaNumeroGenerado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numeros a generar:";
            // 
            // tbn
            // 
            this.tbn.Location = new System.Drawing.Point(151, 176);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(108, 20);
            this.tbn.TabIndex = 11;
            this.tbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbn_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Promedio de los numeros pseodoaleatorios:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Distribución normal:";
            this.label7.Visible = false;
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(318, 543);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(0, 16);
            this.lblpromedio.TabIndex = 14;
            this.lblpromedio.Visible = false;
            // 
            // lbldisnor2
            // 
            this.lbldisnor2.AutoSize = true;
            this.lbldisnor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisnor2.Location = new System.Drawing.Point(178, 568);
            this.lbldisnor2.Name = "lbldisnor2";
            this.lbldisnor2.Size = new System.Drawing.Size(0, 16);
            this.lbldisnor2.TabIndex = 15;
            this.lbldisnor2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.label8.Location = new System.Drawing.Point(95, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Generador de Numeros Pseodoalarorios";
            // 
            // btnPruebas
            // 
            this.btnPruebas.Location = new System.Drawing.Point(237, 109);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(75, 23);
            this.btnPruebas.TabIndex = 23;
            this.btnPruebas.Text = "Pruebas";
            this.btnPruebas.UseVisualStyleBackColor = true;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtValorAcumulado);
            this.panel1.Controls.Add(this.txtPiAprox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnLimites);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtLimSupPi);
            this.panel1.Controls.Add(this.txtLimInfPi);
            this.panel1.Controls.Add(this.labelPi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtTolerancia);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtNoCorridas);
            this.panel1.Controls.Add(this.dataGridViewPi);
            this.panel1.Controls.Add(this.btnPi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(357, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 548);
            this.panel1.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Valor acumulado";
            // 
            // txtValorAcumulado
            // 
            this.txtValorAcumulado.Enabled = false;
            this.txtValorAcumulado.Location = new System.Drawing.Point(115, 149);
            this.txtValorAcumulado.Name = "txtValorAcumulado";
            this.txtValorAcumulado.Size = new System.Drawing.Size(100, 20);
            this.txtValorAcumulado.TabIndex = 15;
            // 
            // txtPiAprox
            // 
            this.txtPiAprox.Enabled = false;
            this.txtPiAprox.Location = new System.Drawing.Point(427, 139);
            this.txtPiAprox.Name = "txtPiAprox";
            this.txtPiAprox.Size = new System.Drawing.Size(100, 20);
            this.txtPiAprox.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Valor Pi Aproximado";
            // 
            // btnLimites
            // 
            this.btnLimites.Location = new System.Drawing.Point(530, 65);
            this.btnLimites.Name = "btnLimites";
            this.btnLimites.Size = new System.Drawing.Size(75, 23);
            this.btnLimites.TabIndex = 12;
            this.btnLimites.Text = "Decisión";
            this.btnLimites.UseVisualStyleBackColor = true;
            this.btnLimites.Click += new System.EventHandler(this.btnLimites_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Lim Sup.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Lim Inf.";
            // 
            // txtLimSupPi
            // 
            this.txtLimSupPi.Enabled = false;
            this.txtLimSupPi.Location = new System.Drawing.Point(505, 97);
            this.txtLimSupPi.Name = "txtLimSupPi";
            this.txtLimSupPi.Size = new System.Drawing.Size(100, 20);
            this.txtLimSupPi.TabIndex = 9;
            // 
            // txtLimInfPi
            // 
            this.txtLimInfPi.Enabled = false;
            this.txtLimInfPi.Location = new System.Drawing.Point(300, 100);
            this.txtLimInfPi.Name = "txtLimInfPi";
            this.txtLimInfPi.Size = new System.Drawing.Size(100, 20);
            this.txtLimInfPi.TabIndex = 8;
            // 
            // labelPi
            // 
            this.labelPi.AutoSize = true;
            this.labelPi.Location = new System.Drawing.Point(71, 56);
            this.labelPi.Name = "labelPi";
            this.labelPi.Size = new System.Drawing.Size(0, 13);
            this.labelPi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tolerancia (%)";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(300, 71);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Numero de corridas";
            // 
            // txtNoCorridas
            // 
            this.txtNoCorridas.Location = new System.Drawing.Point(115, 87);
            this.txtNoCorridas.Name = "txtNoCorridas";
            this.txtNoCorridas.Size = new System.Drawing.Size(100, 20);
            this.txtNoCorridas.TabIndex = 3;
            // 
            // dataGridViewPi
            // 
            this.dataGridViewPi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoCorrida,
            this.UPs,
            this.SPs,
            this.dis,
            this.sec,
            this.vacum});
            this.dataGridViewPi.Location = new System.Drawing.Point(0, 236);
            this.dataGridViewPi.Name = "dataGridViewPi";
            this.dataGridViewPi.Size = new System.Drawing.Size(640, 254);
            this.dataGridViewPi.TabIndex = 2;
            // 
            // NoCorrida
            // 
            this.NoCorrida.HeaderText = "No Corrida";
            this.NoCorrida.Name = "NoCorrida";
            // 
            // UPs
            // 
            this.UPs.HeaderText = "1er No Pseudoaleatorio";
            this.UPs.Name = "UPs";
            // 
            // SPs
            // 
            this.SPs.HeaderText = "2do No Pseudoaleatorio";
            this.SPs.Name = "SPs";
            // 
            // dis
            // 
            this.dis.HeaderText = "Distancia";
            this.dis.Name = "dis";
            // 
            // sec
            // 
            this.sec.HeaderText = "En sector";
            this.sec.Name = "sec";
            // 
            // vacum
            // 
            this.vacum.HeaderText = "Valor acumulado";
            this.vacum.Name = "vacum";
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(74, 115);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 1;
            this.btnPi.Text = "Calcular";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldisnor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbXo);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbXo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumaNumeroGenerado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPruebas;
        public System.Windows.Forms.Label lblpromedio;
        public System.Windows.Forms.Label lbldisnor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.DataGridView dataGridViewPi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoCorridas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label labelPi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLimSupPi;
        private System.Windows.Forms.TextBox txtLimInfPi;
        private System.Windows.Forms.Button btnLimites;
        private System.Windows.Forms.TextBox txtPiAprox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValorAcumulado;
        private System.Windows.Forms.Label label16;
    }
}


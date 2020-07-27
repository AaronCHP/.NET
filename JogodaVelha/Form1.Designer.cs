namespace JogodaVelha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.gbJogadores = new System.Windows.Forms.GroupBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.gbEmpate = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            this.gbPlacar.SuspendLayout();
            this.gbJogadores.SuspendLayout();
            this.gbEmpate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Controls.Add(this.btnReiniciar);
            this.pnlTop.Controls.Add(this.btnSair);
            this.pnlTop.Controls.Add(this.btnIniciar);
            this.pnlTop.Controls.Add(this.gbOpcoes);
            this.pnlTop.Controls.Add(this.gbPlacar);
            this.pnlTop.Controls.Add(this.gbJogadores);
            this.pnlTop.Location = new System.Drawing.Point(0, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(551, 138);
            this.pnlTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmpate);
            this.groupBox1.Location = new System.Drawing.Point(407, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empates";
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.ForeColor = System.Drawing.Color.Black;
            this.lblEmpate.Location = new System.Drawing.Point(30, 37);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(0, 13);
            this.lblEmpate.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Location = new System.Drawing.Point(273, 103);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(69, 103);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(459, 103);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.rbO);
            this.gbOpcoes.Controls.Add(this.rbX);
            this.gbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gbOpcoes.Location = new System.Drawing.Point(181, 3);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(93, 84);
            this.gbOpcoes.TabIndex = 2;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(28, 51);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(33, 17);
            this.rbO.TabIndex = 1;
            this.rbO.Text = "O";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(28, 25);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(32, 17);
            this.rbX.TabIndex = 0;
            this.rbX.TabStop = true;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.lblPlacar1);
            this.gbPlacar.Controls.Add(this.lblPlacar2);
            this.gbPlacar.ForeColor = System.Drawing.Color.Black;
            this.gbPlacar.Location = new System.Drawing.Point(278, 3);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(123, 84);
            this.gbPlacar.TabIndex = 1;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.AutoSize = true;
            this.lblPlacar1.Location = new System.Drawing.Point(29, 30);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(0, 13);
            this.lblPlacar1.TabIndex = 5;
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.AutoSize = true;
            this.lblPlacar2.Location = new System.Drawing.Point(29, 54);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(0, 13);
            this.lblPlacar2.TabIndex = 6;
            // 
            // gbJogadores
            // 
            this.gbJogadores.Controls.Add(this.txtJogador2);
            this.gbJogadores.Controls.Add(this.txtJogador1);
            this.gbJogadores.Controls.Add(this.lblJogador1);
            this.gbJogadores.Controls.Add(this.lblJogador2);
            this.gbJogadores.ForeColor = System.Drawing.Color.Black;
            this.gbJogadores.Location = new System.Drawing.Point(3, 3);
            this.gbJogadores.Name = "gbJogadores";
            this.gbJogadores.Size = new System.Drawing.Size(172, 84);
            this.gbJogadores.TabIndex = 0;
            this.gbJogadores.TabStop = false;
            this.gbJogadores.Text = "Jogadores";
            // 
            // txtJogador2
            // 
            this.txtJogador2.Location = new System.Drawing.Point(28, 50);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(95, 20);
            this.txtJogador2.TabIndex = 4;
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(28, 25);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(95, 20);
            this.txtJogador1.TabIndex = 3;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Location = new System.Drawing.Point(25, 30);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(54, 13);
            this.lblJogador1.TabIndex = 1;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Location = new System.Drawing.Point(25, 57);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(54, 13);
            this.lblJogador2.TabIndex = 2;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(158, 73);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(234, 73);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(310, 73);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(158, 149);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(234, 149);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(310, 149);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(158, 225);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(234, 225);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(310, 225);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // gbEmpate
            // 
            this.gbEmpate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(65)))));
            this.gbEmpate.Controls.Add(this.btn9);
            this.gbEmpate.Controls.Add(this.btn8);
            this.gbEmpate.Controls.Add(this.btn7);
            this.gbEmpate.Controls.Add(this.btn6);
            this.gbEmpate.Controls.Add(this.btn5);
            this.gbEmpate.Controls.Add(this.btn4);
            this.gbEmpate.Controls.Add(this.btn3);
            this.gbEmpate.Controls.Add(this.btn2);
            this.gbEmpate.Controls.Add(this.btn1);
            this.gbEmpate.Enabled = false;
            this.gbEmpate.Location = new System.Drawing.Point(0, 145);
            this.gbEmpate.Name = "gbEmpate";
            this.gbEmpate.Size = new System.Drawing.Size(551, 364);
            this.gbEmpate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(550, 516);
            this.Controls.Add(this.gbEmpate);
            this.Controls.Add(this.pnlTop);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.gbJogadores.ResumeLayout(false);
            this.gbJogadores.PerformLayout();
            this.gbEmpate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.GroupBox gbJogadores;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Panel gbEmpate;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpate;
    }
}


namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelPuntaje = new System.Windows.Forms.Label();
            this.jugadorActual = new System.Windows.Forms.PictureBox();
            this.c1f1 = new System.Windows.Forms.Button();
            this.c2f1 = new System.Windows.Forms.Button();
            this.c3f1 = new System.Windows.Forms.Button();
            this.c1f2 = new System.Windows.Forms.Button();
            this.c1f3 = new System.Windows.Forms.Button();
            this.c2f2 = new System.Windows.Forms.Button();
            this.c2f3 = new System.Windows.Forms.Button();
            this.c3f2 = new System.Windows.Forms.Button();
            this.c3f3 = new System.Windows.Forms.Button();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorActual)).BeginInit();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPuntaje
            // 
            this.LabelPuntaje.BackColor = System.Drawing.Color.White;
            this.LabelPuntaje.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.LabelPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPuntaje.Location = new System.Drawing.Point(81, 52);
            this.LabelPuntaje.Name = "LabelPuntaje";
            this.LabelPuntaje.Size = new System.Drawing.Size(194, 51);
            this.LabelPuntaje.TabIndex = 0;
            this.LabelPuntaje.Text = "0";
            // 
            // jugadorActual
            // 
            this.jugadorActual.BackColor = System.Drawing.Color.White;
            this.jugadorActual.Image = ((System.Drawing.Image)(resources.GetObject("jugadorActual.Image")));
            this.jugadorActual.Location = new System.Drawing.Point(448, 51);
            this.jugadorActual.Name = "jugadorActual";
            this.jugadorActual.Size = new System.Drawing.Size(54, 54);
            this.jugadorActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jugadorActual.TabIndex = 10;
            this.jugadorActual.TabStop = false;
            // 
            // c1f1
            // 
            this.c1f1.BackColor = System.Drawing.Color.White;
            this.c1f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c1f1.Location = new System.Drawing.Point(72, 161);
            this.c1f1.Name = "c1f1";
            this.c1f1.Size = new System.Drawing.Size(124, 120);
            this.c1f1.TabIndex = 11;
            this.c1f1.Text = " ";
            this.c1f1.UseVisualStyleBackColor = false;
            this.c1f1.Click += new System.EventHandler(this.c1f1_Click);
            // 
            // c2f1
            // 
            this.c2f1.BackColor = System.Drawing.Color.White;
            this.c2f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c2f1.Location = new System.Drawing.Point(227, 161);
            this.c2f1.Name = "c2f1";
            this.c2f1.Size = new System.Drawing.Size(124, 120);
            this.c2f1.TabIndex = 12;
            this.c2f1.Text = " ";
            this.c2f1.UseVisualStyleBackColor = false;
            this.c2f1.Click += new System.EventHandler(this.c2f1_Click);
            // 
            // c3f1
            // 
            this.c3f1.BackColor = System.Drawing.Color.White;
            this.c3f1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c3f1.Location = new System.Drawing.Point(378, 161);
            this.c3f1.Name = "c3f1";
            this.c3f1.Size = new System.Drawing.Size(124, 120);
            this.c3f1.TabIndex = 13;
            this.c3f1.Text = " ";
            this.c3f1.UseVisualStyleBackColor = false;
            this.c3f1.Click += new System.EventHandler(this.c3f1_Click);
            // 
            // c1f2
            // 
            this.c1f2.BackColor = System.Drawing.Color.White;
            this.c1f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c1f2.Location = new System.Drawing.Point(72, 308);
            this.c1f2.Name = "c1f2";
            this.c1f2.Size = new System.Drawing.Size(124, 120);
            this.c1f2.TabIndex = 14;
            this.c1f2.Text = " ";
            this.c1f2.UseVisualStyleBackColor = false;
            this.c1f2.Click += new System.EventHandler(this.c1f2_Click);
            // 
            // c1f3
            // 
            this.c1f3.BackColor = System.Drawing.Color.White;
            this.c1f3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c1f3.Location = new System.Drawing.Point(72, 453);
            this.c1f3.Name = "c1f3";
            this.c1f3.Size = new System.Drawing.Size(124, 120);
            this.c1f3.TabIndex = 15;
            this.c1f3.Text = " ";
            this.c1f3.UseVisualStyleBackColor = false;
            this.c1f3.Click += new System.EventHandler(this.c1f3_Click);
            // 
            // c2f2
            // 
            this.c2f2.BackColor = System.Drawing.Color.White;
            this.c2f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c2f2.Location = new System.Drawing.Point(227, 308);
            this.c2f2.Name = "c2f2";
            this.c2f2.Size = new System.Drawing.Size(124, 120);
            this.c2f2.TabIndex = 16;
            this.c2f2.Text = " ";
            this.c2f2.UseVisualStyleBackColor = false;
            this.c2f2.Click += new System.EventHandler(this.c2f2_Click);
            // 
            // c2f3
            // 
            this.c2f3.BackColor = System.Drawing.Color.White;
            this.c2f3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c2f3.Location = new System.Drawing.Point(227, 453);
            this.c2f3.Name = "c2f3";
            this.c2f3.Size = new System.Drawing.Size(124, 120);
            this.c2f3.TabIndex = 17;
            this.c2f3.Text = " ";
            this.c2f3.UseVisualStyleBackColor = false;
            this.c2f3.Click += new System.EventHandler(this.c2f3_Click);
            // 
            // c3f2
            // 
            this.c3f2.BackColor = System.Drawing.Color.White;
            this.c3f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c3f2.Location = new System.Drawing.Point(378, 308);
            this.c3f2.Name = "c3f2";
            this.c3f2.Size = new System.Drawing.Size(124, 120);
            this.c3f2.TabIndex = 18;
            this.c3f2.Text = " ";
            this.c3f2.UseVisualStyleBackColor = false;
            this.c3f2.Click += new System.EventHandler(this.c3f2_Click);
            // 
            // c3f3
            // 
            this.c3f3.BackColor = System.Drawing.Color.White;
            this.c3f3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.c3f3.Location = new System.Drawing.Point(378, 453);
            this.c3f3.Name = "c3f3";
            this.c3f3.Size = new System.Drawing.Size(124, 120);
            this.c3f3.TabIndex = 19;
            this.c3f3.Text = " ";
            this.c3f3.UseVisualStyleBackColor = false;
            this.c3f3.Click += new System.EventHandler(this.c3f3_Click);
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.Black;
            this.panelAviso.Controls.Add(this.botonAceptar);
            this.panelAviso.Controls.Add(this.labelAviso);
            this.panelAviso.Location = new System.Drawing.Point(12, 161);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(554, 160);
            this.panelAviso.TabIndex = 20;
            this.panelAviso.Visible = false;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.BackColor = System.Drawing.Color.Transparent;
            this.labelAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.ForeColor = System.Drawing.Color.White;
            this.labelAviso.Location = new System.Drawing.Point(142, 37);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(265, 37);
            this.labelAviso.TabIndex = 0;
            this.labelAviso.Text = "Jugada invalida.";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(215, 96);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(118, 34);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.Diseño_sin_título__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.c3f3);
            this.Controls.Add(this.c3f2);
            this.Controls.Add(this.c2f3);
            this.Controls.Add(this.c2f2);
            this.Controls.Add(this.c1f3);
            this.Controls.Add(this.c1f2);
            this.Controls.Add(this.c3f1);
            this.Controls.Add(this.c2f1);
            this.Controls.Add(this.c1f1);
            this.Controls.Add(this.jugadorActual);
            this.Controls.Add(this.LabelPuntaje);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.jugadorActual)).EndInit();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelPuntaje;
        private System.Windows.Forms.PictureBox jugadorActual;
        private System.Windows.Forms.Button c1f1;
        private System.Windows.Forms.Button c2f1;
        private System.Windows.Forms.Button c3f1;
        private System.Windows.Forms.Button c1f2;
        private System.Windows.Forms.Button c1f3;
        private System.Windows.Forms.Button c2f2;
        private System.Windows.Forms.Button c2f3;
        private System.Windows.Forms.Button c3f2;
        private System.Windows.Forms.Button c3f3;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Button botonAceptar;
    }
}


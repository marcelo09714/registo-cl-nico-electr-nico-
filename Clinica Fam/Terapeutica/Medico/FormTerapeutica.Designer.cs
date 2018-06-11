namespace Terapeutica
{
    partial class FormTerapeutica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.textBoxPosology = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewTerapies = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerapies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posologia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAdd_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(607, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(135, 335);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(547, 20);
            this.textBoxMedName.TabIndex = 12;
            this.textBoxMedName.Click += new System.EventHandler(this.ButtonAdd_click);
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Location = new System.Drawing.Point(135, 365);
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(547, 20);
            this.numericUpDownQtd.TabIndex = 13;
            // 
            // textBoxPosology
            // 
            this.textBoxPosology.Location = new System.Drawing.Point(135, 395);
            this.textBoxPosology.Name = "textBoxPosology";
            this.textBoxPosology.Size = new System.Drawing.Size(547, 20);
            this.textBoxPosology.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Gravar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Pesquisar ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewTerapies
            // 
            this.dataGridViewTerapies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTerapies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTerapies.Location = new System.Drawing.Point(24, 13);
            this.dataGridViewTerapies.Name = "dataGridViewTerapies";
            this.dataGridViewTerapies.Size = new System.Drawing.Size(658, 316);
            this.dataGridViewTerapies.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(12, 429);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Voltar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormTerapeutica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 464);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridViewTerapies);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxPosology);
            this.Controls.Add(this.numericUpDownQtd);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTerapeutica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terapeutica";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerapies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.TextBox textBoxPosology;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewTerapies;
        private System.Windows.Forms.Button button6;
    }
}
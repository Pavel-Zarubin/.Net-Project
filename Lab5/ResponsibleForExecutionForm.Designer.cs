
namespace Lab5
{
    partial class ResponsibleForExecutionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.fioRFE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionRFE = new System.Windows.Forms.TextBox();
            this.tvResponsibleForExecution = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivision_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.subdivision_nameRFE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idRFE = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvResponsibleForExecution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idRFE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fioRFE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.positionRFE);
            this.panel1.Controls.Add(this.tvResponsibleForExecution);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subdivision_nameRFE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idRFE);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 452);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(607, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "fio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fioRFE
            // 
            this.fioRFE.Location = new System.Drawing.Point(636, 186);
            this.fioRFE.Name = "fioRFE";
            this.fioRFE.Size = new System.Drawing.Size(120, 20);
            this.fioRFE.TabIndex = 63;
            this.fioRFE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(573, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "position";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // positionRFE
            // 
            this.positionRFE.Location = new System.Drawing.Point(636, 150);
            this.positionRFE.Name = "positionRFE";
            this.positionRFE.Size = new System.Drawing.Size(120, 20);
            this.positionRFE.TabIndex = 61;
            this.positionRFE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tvResponsibleForExecution
            // 
            this.tvResponsibleForExecution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvResponsibleForExecution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subdivision_name,
            this.position,
            this.fio});
            this.tvResponsibleForExecution.Location = new System.Drawing.Point(13, 12);
            this.tvResponsibleForExecution.Name = "tvResponsibleForExecution";
            this.tvResponsibleForExecution.Size = new System.Drawing.Size(449, 401);
            this.tvResponsibleForExecution.TabIndex = 60;
            this.tvResponsibleForExecution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // subdivision_name
            // 
            this.subdivision_name.HeaderText = "subdivision_name";
            this.subdivision_name.Name = "subdivision_name";
            // 
            // position
            // 
            this.position.HeaderText = "position";
            this.position.Name = "position";
            // 
            // fio
            // 
            this.fio.HeaderText = "fio";
            this.fio.Name = "fio";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(704, 390);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 59;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(597, 390);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 58;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(483, 390);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 57;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(509, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "subdivision_name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // subdivision_nameRFE
            // 
            this.subdivision_nameRFE.Location = new System.Drawing.Point(636, 110);
            this.subdivision_nameRFE.Name = "subdivision_nameRFE";
            this.subdivision_nameRFE.Size = new System.Drawing.Size(120, 20);
            this.subdivision_nameRFE.TabIndex = 55;
            this.subdivision_nameRFE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(497, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "ResposibleForExecutionDetails";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(611, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idRFE
            // 
            this.idRFE.Location = new System.Drawing.Point(636, 68);
            this.idRFE.Name = "idRFE";
            this.idRFE.Size = new System.Drawing.Size(120, 20);
            this.idRFE.TabIndex = 52;
            this.idRFE.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ResponsibleForExecutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ResponsibleForExecutionForm";
            this.Text = "ResponsibleForExecutionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvResponsibleForExecution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idRFE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fioRFE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionRFE;
        private System.Windows.Forms.DataGridView tvResponsibleForExecution;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subdivision_nameRFE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idRFE;
    }
}
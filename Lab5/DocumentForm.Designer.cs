
namespace Lab5
{
    partial class DocumentForm
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
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.responsibleForExecutionD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eventD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contentD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numberD = new System.Windows.Forms.TextBox();
            this.tvDocument = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleforexecution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idD = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.responsibleForExecutionD);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.eventD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contentD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numberD);
            this.panel1.Controls.Add(this.tvDocument);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idD);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 450);
            this.panel1.TabIndex = 0;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(846, 389);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(739, 389);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 16;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(625, 389);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 15;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // responsibleForExecutionD
            // 
            this.responsibleForExecutionD.FormattingEnabled = true;
            this.responsibleForExecutionD.Location = new System.Drawing.Point(778, 251);
            this.responsibleForExecutionD.Name = "responsibleForExecutionD";
            this.responsibleForExecutionD.Size = new System.Drawing.Size(121, 21);
            this.responsibleForExecutionD.TabIndex = 14;
            this.responsibleForExecutionD.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(598, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "responsible_for_execution";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // eventD
            // 
            this.eventD.FormattingEnabled = true;
            this.eventD.Location = new System.Drawing.Point(778, 213);
            this.eventD.Name = "eventD";
            this.eventD.Size = new System.Drawing.Size(121, 21);
            this.eventD.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(717, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "event";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(717, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "content";
            // 
            // contentD
            // 
            this.contentD.Location = new System.Drawing.Point(778, 177);
            this.contentD.Name = "contentD";
            this.contentD.Size = new System.Drawing.Size(120, 20);
            this.contentD.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(736, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateD
            // 
            this.dateD.Location = new System.Drawing.Point(778, 141);
            this.dateD.Name = "dateD";
            this.dateD.Size = new System.Drawing.Size(120, 20);
            this.dateD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(716, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numberD
            // 
            this.numberD.Location = new System.Drawing.Point(778, 109);
            this.numberD.Name = "numberD";
            this.numberD.Size = new System.Drawing.Size(120, 20);
            this.numberD.TabIndex = 4;
            // 
            // tvDocument
            // 
            this.tvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.date,
            this.content,
            this.event1,
            this.responsibleforexecution});
            this.tvDocument.Location = new System.Drawing.Point(9, 12);
            this.tvDocument.Name = "tvDocument";
            this.tvDocument.Size = new System.Drawing.Size(583, 400);
            this.tvDocument.TabIndex = 3;
            this.tvDocument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // content
            // 
            this.content.HeaderText = "content";
            this.content.Name = "content";
            // 
            // event1
            // 
            this.event1.HeaderText = "event";
            this.event1.Name = "event1";
            // 
            // responsibleforexecution
            // 
            this.responsibleforexecution.HeaderText = "responsible_for_execution";
            this.responsibleforexecution.Name = "responsibleforexecution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(738, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DocumentDetails";
            this.label2.Click += new System.EventHandler(this.DocumentDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(753, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idD
            // 
            this.idD.Location = new System.Drawing.Point(778, 67);
            this.idD.Name = "idD";
            this.idD.Size = new System.Drawing.Size(120, 20);
            this.idD.TabIndex = 0;
            this.idD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentForm";
            this.Text = "DocumentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown idD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tvDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn event1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleforexecution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contentD;
        private System.Windows.Forms.ComboBox responsibleForExecutionD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox eventD;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
    }
}
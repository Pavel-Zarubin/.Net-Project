
namespace Lab5
{
    partial class CorrespondentForm
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
            this.fioC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionC = new System.Windows.Forms.TextBox();
            this.tvCorrespondent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivision_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.subdivision_nameC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idC = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvCorrespondent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fioC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.positionC);
            this.panel1.Controls.Add(this.tvCorrespondent);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subdivision_nameC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idC);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(609, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "fio";
            // 
            // fioC
            // 
            this.fioC.Location = new System.Drawing.Point(638, 192);
            this.fioC.Name = "fioC";
            this.fioC.Size = new System.Drawing.Size(120, 20);
            this.fioC.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(575, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "position";
            // 
            // positionC
            // 
            this.positionC.Location = new System.Drawing.Point(638, 156);
            this.positionC.Name = "positionC";
            this.positionC.Size = new System.Drawing.Size(120, 20);
            this.positionC.TabIndex = 48;
            // 
            // tvCorrespondent
            // 
            this.tvCorrespondent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvCorrespondent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subdivision_name,
            this.position,
            this.fio});
            this.tvCorrespondent.Location = new System.Drawing.Point(15, 18);
            this.tvCorrespondent.Name = "tvCorrespondent";
            this.tvCorrespondent.Size = new System.Drawing.Size(449, 401);
            this.tvCorrespondent.TabIndex = 47;
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
            this.bDelete.Location = new System.Drawing.Point(706, 396);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 46;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(599, 396);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 45;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(485, 396);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 44;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(511, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "subdivision_name";
            // 
            // subdivision_nameC
            // 
            this.subdivision_nameC.Location = new System.Drawing.Point(638, 116);
            this.subdivision_nameC.Name = "subdivision_nameC";
            this.subdivision_nameC.Size = new System.Drawing.Size(120, 20);
            this.subdivision_nameC.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(580, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "CorrespondentDetails";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(613, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "id";
            // 
            // idC
            // 
            this.idC.Location = new System.Drawing.Point(638, 74);
            this.idC.Name = "idC";
            this.idC.Size = new System.Drawing.Size(120, 20);
            this.idC.TabIndex = 39;
            // 
            // CorrespondentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CorrespondentForm";
            this.Text = "CorrespondentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvCorrespondent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fioC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox positionC;
        private System.Windows.Forms.DataGridView tvCorrespondent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivision_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subdivision_nameC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idC;
    }
}
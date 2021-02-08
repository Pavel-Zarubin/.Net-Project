
namespace Lab5
{
    partial class UserForm
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
            this.tvUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idUser = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tvUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tvUser
            // 
            this.tvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password,
            this.is_auth});
            this.tvUser.Location = new System.Drawing.Point(13, 13);
            this.tvUser.Name = "tvUser";
            this.tvUser.Size = new System.Drawing.Size(444, 150);
            this.tvUser.TabIndex = 0;
            this.tvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // is_auth
            // 
            this.is_auth.HeaderText = "is_auth";
            this.is_auth.Name = "is_auth";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passwordUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usernameUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idUser);
            this.panel1.Controls.Add(this.tvUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 239);
            this.panel1.TabIndex = 1;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(701, 184);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 26;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(594, 184);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 25;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(480, 184);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 24;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(553, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // passwordUser
            // 
            this.passwordUser.Location = new System.Drawing.Point(627, 135);
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Size = new System.Drawing.Size(120, 20);
            this.passwordUser.TabIndex = 22;
            this.passwordUser.UseSystemPasswordChar = true;
            this.passwordUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(550, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernameUser
            // 
            this.usernameUser.Location = new System.Drawing.Point(627, 100);
            this.usernameUser.Name = "usernameUser";
            this.usernameUser.Size = new System.Drawing.Size(120, 20);
            this.usernameUser.TabIndex = 18;
            this.usernameUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(622, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "UserDetails";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(602, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(627, 58);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(120, 20);
            this.idUser.TabIndex = 15;
            this.idUser.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_auth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idUser;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
    }
}
namespace CustomControl
{
    partial class frmTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagv = new System.Windows.Forms.DataGridView();
            this.cuComboBox1 = new CustomControl.CUComboBox();
            this.cuTimer1 = new CustomControl.CUTimer();
            this.ucTextBox1 = new CustomControl.CUTextBox();
            this.cuDataGrideView1 = new CustomControl.CUDataGrideView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cuTimer1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cuComboBox1);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ComboxBox";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagv);
            this.groupBox4.Location = new System.Drawing.Point(12, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 325);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Record";
            // 
            // datagv
            // 
            this.datagv.AllowUserToAddRows = false;
            this.datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagv.Location = new System.Drawing.Point(3, 22);
            this.datagv.Name = "datagv";
            this.datagv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagv.Size = new System.Drawing.Size(547, 300);
            this.datagv.TabIndex = 0;
            this.datagv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_CellContentClick);
            // 
            // cuComboBox1
            // 
            this.cuComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuComboBox1.Index = 0;
            this.cuComboBox1.Item = "Select Option";
            this.cuComboBox1.Location = new System.Drawing.Point(9, 42);
            this.cuComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuComboBox1.Name = "cuComboBox1";
            this.cuComboBox1.Size = new System.Drawing.Size(207, 63);
            this.cuComboBox1.TabIndex = 0;
            this.cuComboBox1.AddItemIntoList += new System.EventHandler(this.cuComboBox1_AddItemIntoList);
            // 
            // cuTimer1
            // 
            this.cuTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuTimer1.Interval = -1;
            this.cuTimer1.IsEnable = true;
            this.cuTimer1.Location = new System.Drawing.Point(67, 42);
            this.cuTimer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuTimer1.Name = "cuTimer1";
            this.cuTimer1.Size = new System.Drawing.Size(46, 43);
            this.cuTimer1.StopAt = 10;
            this.cuTimer1.TabIndex = 0;
            this.cuTimer1.Load += new System.EventHandler(this.cuTimer1_Load_1);
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ucTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox1.Location = new System.Drawing.Point(9, 30);
            this.ucTextBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Size = new System.Drawing.Size(173, 77);
            this.ucTextBox1.TabIndex = 0;
            this.ucTextBox1.Txtlenght = 3;
            // 
            // cuDataGrideView1
            // 
            this.cuDataGrideView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuDataGrideView1.Location = new System.Drawing.Point(569, 163);
            this.cuDataGrideView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuDataGrideView1.Name = "cuDataGrideView1";
            this.cuDataGrideView1.Size = new System.Drawing.Size(135, 139);
            this.cuDataGrideView1.TabIndex = 5;
            this.cuDataGrideView1.Delete += new System.EventHandler(this.cuDataGrideView1_Delete);
            this.cuDataGrideView1.Search += new System.EventHandler(this.cuDataGrideView1_Search);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 497);
            this.Controls.Add(this.cuDataGrideView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Form";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CUTextBox ucTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CUTimer cuTimer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CUComboBox cuComboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView datagv;
        private CUDataGrideView cuDataGrideView1;
    }
}

